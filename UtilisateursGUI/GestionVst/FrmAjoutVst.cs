using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using UtilisateursBO; // Référence la couche BO
using UtilisateursBLL; // Référence la couche BLL

namespace UtilisateursGUI.GestionVst
{
    public partial class FrmAjoutVst : Form
    {
        #region Gestion du formulaire
        #region Initialisation du Formulaire de modification
        public FrmAjoutVst()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            UtilisateursBLL.GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Eleve"]);

            // Ce code définit le format du contrôle pour afficher une heure au lieu
            // d'une date et permet à l'utilisateur de modifier l'heure qui est affichée.
            this.dateTimeArv.Format = DateTimePickerFormat.Time;
            this.dateTimeArv.ShowUpDown = true;

            this.dateTimeDep.Format = DateTimePickerFormat.Time;
            this.dateTimeDep.ShowUpDown = true;

            #region Liste medicaments
            // Création d'un objet List de médicaments à afficher dans la liste    
            liste = GestionMedicament.GetMedicaments();

            lblMdc_list.DataSource = liste;
            lblMdc_list.DisplayMember = "LblMdc";
            lblMdc_list.ValueMember = "IdMdc";

            numMedicSelect = (int)lblMdc_list.SelectedValue;
            #endregion

            #region Informations élèves non archivés
            #region Liste id
            // Création d'un objet List d'Eleves à afficher dans la liste
            listeEleves = GestionEleve.GetElevesNonArchives();

            nomElv_cmbx.DataSource = listeEleves;
            nomElv_cmbx.DisplayMember = "Nom";
            nomElv_cmbx.ValueMember = "Id_eleves";
            #endregion

            #region Remplissage des cases
            numSelectionne = (int)nomElv_cmbx.SelectedIndex;

            if (listeEleves[numSelectionne].ArchiveEleve == false)
            {
                prenomElvLbl.Text = listeEleves[numSelectionne].Prenom;
                dateNaissanceLbl.Text = listeEleves[numSelectionne].Date_naissance.ToString();
                libelleClasseLbl.Text = GestionClasse.GetUneClasse(listeEleves[numSelectionne].Id_classe).NiveauClasse + " " + GestionClasse.GetUneClasse(listeEleves[numSelectionne].Id_classe).LibelleClasse;
            }
            #endregion

            #region Boutons radios
            #region Retour à la maison
            if (backHomeYes.Checked == true)
            {
                backHomeNo.Checked = false;
            }
            else if (backHomeNo.Checked == true)
            {
                backHomeYes.Checked = false;
            }
            #endregion

            #region Hopital
            if (hospitalYes.Checked == true)
            {
                hospitalNo.Checked = false;
            }
            else if (hospitalNo.Checked == true)
            {
                hospitalYes.Checked = false;
            }
            #endregion

            #region Parents informés
            if (tellPrYes.Checked == true)
            {
                tellPrNo.Checked = false;
            }
            else if (tellPrNo.Checked == true)
            {
                tellPrYes.Checked = false;
            }
            #endregion
            #endregion
            #endregion
        }
        #endregion

        #region Attributs de l'application
        private int numSelectionne;
        private int numMedicSelect;
        //  private int nbClasse;
        //  private int ind = 0;
        private List<Eleve> listeEleves; // initialisation de la liste
        private List<Medicament> liste;
        #endregion

        #region Actions concernant la liste déroulante des noms des élèves
        private void nomElv_list_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int numSelectionne = (int)nomElv_cmbx.SelectedIndex;

            #region Remplissage des cases
            prenomElvLbl.Text = listeEleves[numSelectionne].Prenom;
            dateNaissanceLbl.Text = listeEleves[numSelectionne].Date_naissance.ToString();
            libelleClasseLbl.Text = GestionClasse.GetUneClasse(listeEleves[numSelectionne].Id_classe).NiveauClasse + " " + GestionClasse.GetUneClasse(listeEleves[numSelectionne].Id_classe).LibelleClasse;
            #endregion
        }
        #endregion

        #region Boutons du formulaire
        #region Boutons Sauvegarder
        private void saveBtn_Click(object sender, EventArgs e)
        {
            #region Si les champs de la visite sont vides
            if (string.IsNullOrEmpty(motifTxtbx.Text) ||
                string.IsNullOrEmpty(commentTxtbx.Text) ||
                int.Parse(poulsNumUpDown.Text) < 0 ||
                int.Parse(poulsNumUpDown.Text) == null)
            {
                #region Affichage du MessageBox.
                MessageBox.Show(
                    this,
                    "Certains champs du formulaire sont vides ou incorrects ! Remplissez-les pour continuer.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                #endregion
            }
            #endregion
            #region Condition impossible car l'élève ne peut pas rentrer chez lui et aller à l'hôpital
            else if (backHomeYes.Checked == true &&
                        hospitalYes.Checked == true)
            {
                #region Affichage du MessageBox
                MessageBox.Show(
                    this,
                    "Attention, l'élève ne peut pas aller à l'hôpital et chez lui en même temps !",
                    "Prescription",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                #endregion
            }
            #endregion
            #region Si tout va bien
            else
            {
                #region Si un médicament a été prescrit
                if (int.Parse(qteNumUpDown.Text) > 0)
                {
                    createVst();
                    createPrcpt();

                    #region Affichage du MessageBox
                    DialogResult result = MessageBox.Show(
                        this,
                        "La visite et la prescription ont bien été enregistrés !",
                        "Valider",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk,
                        MessageBoxDefaultButton.Button1);
                    #endregion
                }
                #endregion
                #region Si la quantité des médicaments == 0, on propose la prescription
                else if (int.Parse(qteNumUpDown.Text) == 0)
                {
                    #region Affichage du MessageBox et récupération du résultat
                    DialogResult result = MessageBox.Show(
                        this,
                        "Souhaitez-vous prescrire un médicament ?",
                        "Prescription",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);
                    #endregion

                    #region Actions en fonction du message de validation
                    if (result == DialogResult.No)
                    {
                        createVst();
                        #region Affichage du MessageBox et récupération du résultat
                        result = MessageBox.Show(
                            this,
                            "Souhaitez-vous prescrire un médicament ?",
                            "Prescription",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1);
                        #endregion

                        // Fermeture du formulaire si l'utilisateur ne souhaite pas saisir d'autres visites
                        if (result == DialogResult.No)
                        {
                            this.Close();
                        }
                        // Vidage des champs si l'utilisateur souhaite saisir d'autre(s) visite(s)
                        else
                        {
                            motifTxtbx.Text = string.Empty;
                            commentTxtbx.Text = string.Empty;
                            poulsNumUpDown.Text = "0";
                            tellPrNo.Checked = true;
                            backHomeNo.Checked = true;
                            hospitalNo.Checked = true;
                            qteNumUpDown.Text = string.Empty;
                        }
                    }
                    #endregion
                }
                #endregion
            }
            #endregion
        }
        #endregion

        #region Bouton Annuler
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion

        #region Contrôles de saisies
        #region Contrôle de saisie sur le motif de la visite
        private void motifTxtbx_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(motifTxtbx.Text))
            {
                // Set the error if the name is not valid.
                errProMotif.SetError(this.motifTxtbx, "Le motif de la visite est requis et ne dois pas être vide !");
            }
            else if (isLetter(nomEleve.Text) == false)
            {
                // Set the error if the name is not valid.
                errProMotif.SetError(this.motifTxtbx, "Le motif de la visite ne doit pas contenir de chiffres !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProMotif.SetError(this.motifTxtbx, String.Empty);
            }
        }
        #endregion

        #region Contrôle de saisie sur le commentaire de la visite
        private void commentTxtbx_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(commentTxtbx.Text))
            {
                // Set the error if the name is not valid.
                errProComment.SetError(this.commentTxtbx, "Le commentaire de la visite est requis et ne dois pas être vide !");
            }
            else if (isLetter(commentTxtbx.Text) == false)
            {
                // Set the error if the name is not valid.
                errProComment.SetError(this.commentTxtbx, "Le commentaire de la visite ne doit pas contenir de chiffres !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProComment.SetError(this.commentTxtbx, String.Empty);
            }
        }
        #endregion

        #region Contrôle de saisie sur le pouls de l'élève
        private void poulsNumUpDown_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(poulsNumUpDown.Text))
            {
                // Set the error if the name is not valid.
                errProPouls.SetError(this.poulsNumUpDown, "Le pouls est requis et ne dois pas être vide !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProPouls.SetError(this.poulsNumUpDown, String.Empty);
            }
        }
        #endregion

        #region Contrôle de saisie sur le retour à domicile
        private void backHomeGroup_Validating(object sender, CancelEventArgs e)
        {
            if (hospitalYes.Checked == true && backHomeYes.Checked == true)
            {
                // Set the error if the name is not valid.
                errProBackHome.SetError(this.backHomeYes, "L'élève ne peut pas rentrer chez lui et aller à l'hopital !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProBackHome.SetError(this.backHomeYes, String.Empty);
            }
        }
        #endregion

        #region Contrôle de saisie sur l'hôpital
        private void hospitalGroup_Validating(object sender, CancelEventArgs e)
        {
            if (hospitalYes.Checked == true && backHomeYes.Checked == true)
            {
                // Set the error if the name is not valid.
                errProBackHome.SetError(this.hospitalYes, "L'élève ne peut pas rentrer chez lui et aller à l'hôpital !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProBackHome.SetError(this.hospitalYes, String.Empty);
            }
        }
        #endregion

        #region Contrôle de saisie sur l'enregistrement de la visite.
        private void saveBtn_Validating(object sender, CancelEventArgs e)
        {

        }
        #endregion
        #endregion

        #region Méthodes pour faciliter le traitement
        #region Méthode vérifiant le contenu des champs textes
        public bool isLetter(string sReceive)
        {
            bool bResult;
            bResult = true;
            foreach (char cWork in sReceive)
            {
                if (char.IsLetter(cWork) == false)
                {
                    bResult = false;
                }
            }

            return bResult;
        }
        #endregion

        #region Création d'une visite
        private void createVst()
        {
            GestionVisite.CreerVisite(
                new Visite(
                    motifTxtbx.Text,
                    commentTxtbx.Text,
                    int.Parse(poulsNumUpDown.Text),
                    tellPrYes.Checked,
                    backHomeYes.Checked,
                    hospitalYes.Checked,
                    DateTime.Parse(dateVstPicker.Text),
                    DateTime.Parse(dateTimeArv.Text),
                    DateTime.Parse(dateTimeDep.Text),
                    (int)nomElv_cmbx.SelectedValue));
        }
        #endregion

        #region Création d'une prescription
        private void createPrcpt()
        {
            int idVisite = GestionVisite.GetIdVstMax();

            Prescription unePrescription = new Prescription(
                        idVisite,
                        (int)lblMdc_list.SelectedValue,
                        int.Parse(qteNumUpDown.Text)
            );

            GestionPrescription.CreerPrescription(unePrescription);
        }
        #endregion
        #endregion
        #endregion
    }
}