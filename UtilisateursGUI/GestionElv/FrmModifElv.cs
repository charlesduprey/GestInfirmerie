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

namespace UtilisateursGUI.GestionElv
{
    public partial class FrmModifElv : Form
    {
        #region Gestion du formulaire
        #region Initialisation du Formulaire de modification
        public FrmModifElv()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            UtilisateursBLL.GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Eleve"]);

            #region Initialisation des listes
            // Création d'un objet List d'Eleves à afficher dans la liste
            listeEleves = GestionEleve.GetElevesNonArchives();

            // Création d'un objet List de classes à afficher dans la liste
            listeClasses = GestionClasse.GetClasses();
            #endregion


            for (int id = 0; id < listeClasses.Count; id++)
            {
                listeLibelleClasse.Add(
                    new Classe(
                        listeClasses[id].IdClasse,
                        listeClasses[id].NiveauClasse + " " + listeClasses[id].LibelleClasse));
            }

            nomElv_cmbx.DataSource = listeEleves;
            nomElv_cmbx.DisplayMember = "Nom";
            nomElv_cmbx.ValueMember = "Id_eleves";

            numSelectionne = (int)nomElv_cmbx.SelectedValue;

            #region Remplissage des cases
            if (listeEleves[numSelectionne].ArchiveEleve == false)
            {
                prenomEleve_txt.Text = listeEleves[numSelectionne].Prenom;
                dateNaissancePicker.Text = listeEleves[numSelectionne].Date_naissance.ToString();
                telEleve_txt.Text = listeEleves[numSelectionne].Tel_eleve.ToString();
                telParent_txt.Text = listeEleves[numSelectionne].Tel_parent.ToString();
                TierTempsTrue.Checked = listeEleves[numSelectionne].Tier_temps;
                commentSante_text.Text = listeEleves[numSelectionne].Commentaire_sante;

                lblClasse_cmbx.DataSource = listeLibelleClasse;
                lblClasse_cmbx.DisplayMember = "LibelleClasse";
                lblClasse_cmbx.ValueMember = "IdClasse";
            }

            #region Brouillon
            /*
            nbClasse = listeEleves[numSelectionne].Id_classe;
            listeNomClasses = new List<string>();
            nbClasse = GestionClasse.GetClasses().Count;
            listeNomClasses.Add(GestionEleve.GetLeNomDeClasse(numSelectionne));
            
            while (ind <= nbClasse)
            {
                listeNomClasses.Add(GestionEleve.GetLeNomDeClasse(ind));
                ind++;
            }

            lblClasse_cmbx.DataSource = listeNomClasses; //GestionEleve.GetLeNomDeClasse(listeEleves[numSelectionne].Id_classe);
            lblClasse_cmbx.DisplayMember = "LibelleClasse";

            while (ind <= GestionClasse.GetClasses().Count)
            {
                lblClasse_cmbx.Value[ind] = GestionEleve.GetLeNomDeClasse(ind);
                ind++;
            }*/
            #endregion
            #endregion
        }
        #endregion

        #region Attributs de l'application
        private int numSelectionne;
        private List<Eleve> listeEleves; // initialisation de la liste
        private List<Classe> listeLibelleClasse = new List<Classe>();
        private List<Classe> listeClasses;
        #endregion

        #region Boutons du formulaire
        #region Bouton Enregistrer
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomElv_cmbx.Text) || string.IsNullOrEmpty(prenomEleve_txt.Text) || (int)lblClasse_cmbx.SelectedValue == 0 || string.IsNullOrEmpty(commentSante_text.Text))
            {
                #region Affichage du MessageBox.
                MessageBox.Show(
                    this,
                    "Le formulaire est vide ! Remplissez-le si nécessaire",
                    "Valider",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                #endregion
            }
            else
            {
                #region Affichage du MessageBox.
                DialogResult result = MessageBox.Show(
                this,
                "Voulez-vous archiver l'élève numéro " + numSelectionne + " ? ",
                "Archivage",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
                #endregion

                #region Actions en fonction du message de validation.
                if (result == DialogResult.Yes)
                {
                    #region Rassemblement et modification des infos de l'élève
                    // Rassemblement des infos de l'élève
                    // int id_eleve = (int)nomElv_cmbx.SelectedValue;
                    Eleve unEleve = new Eleve(
                        numSelectionne,
                        nomElv_cmbx.Text,
                        prenomEleve_txt.Text,
                        DateTime.Parse(dateNaissancePicker.Text),
                        int.Parse(telEleve_txt.Text),
                        int.Parse(telParent_txt.Text),
                        TierTempsTrue.Checked,
                        commentSante_text.Text,
                        (int)lblClasse_cmbx.SelectedValue,
                        false);

                    // Modification de l'élève
                    GestionEleve.ModifierEleve(unEleve);
                    #endregion

                    #region Affichage du MessageBox.
                    MessageBox.Show(
                        this,
                        "L'élève numéro " + numSelectionne + " a bien été archivé ",
                        "Archivage",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);
                    #endregion
                }
                #endregion
            }
        }
        #endregion

        #region Bouton Archiver
        private void archBtn_Click(object sender, EventArgs e)
        {
            #region Affichage du MessageBox.
            DialogResult result = MessageBox.Show(
                this,
                "Voulez-vous archiver l'élève numéro " + numSelectionne + " ? ",
                "Archivage",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            #endregion

            #region Actions en fonction du message de validation.
            if (result == DialogResult.Yes)
            {
                // Méthode pour archiver l'élève
                GestionEleve.ArchiveEleve(numSelectionne);

                #region Affichage du MessageBox.
                MessageBox.Show(
                    this,
                    "L'élève numéro " + numSelectionne + " a bien été archivé ",
                    "Archivage",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                #endregion
            }
            #endregion
        }
        #endregion

        #region Bouton Supprimer
        private void suprBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomElv_cmbx.Text) || string.IsNullOrEmpty(prenomEleve_txt.Text) || (int)lblClasse_cmbx.SelectedValue == 0 || string.IsNullOrEmpty(commentSante_text.Text))
            {
                #region Affichage du MessageBox.
                MessageBox.Show(
                    this,
                    "Certains champs du formulaire sont vides ! Remplissez-les pour continuer.",
                    "Valider",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                #endregion
            }
            else
            {
                int id = int.Parse(nomElv_cmbx.SelectedValue.ToString());
                
                #region Affichage du MessageBox.
                DialogResult result = MessageBox.Show(
                    this,
                    "Voulez-vous supprimer l'élève " + id + " ?",
                    "Suppression",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                #endregion

                // Contrôle de la possibilité de suppression (afilié à aucune visite)
                bool trouve = GestionEleve.TrouverEleve(id);

                if (trouve == true)
                {
                    trouve = true;
                    MessageBox.Show(
                        "Impossible de supprimer l'élève " + id + " Vous pouvez cependant l'achiver.",
                        "Suppression",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                else
                {
                    GestionEleve.SupprimerEleve(id);
                }
                // supression si oui
            }
        }
        #endregion

        #region Bouton Fermer
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion

        #region Actions concernant la liste déroulante des noms des élèves
        private void nomElv_list_SelectionChangeCommitted(object sender, EventArgs e)
        {
            numSelectionne = (int)nomElv_cmbx.SelectedValue;

            #region Remplissage des cases
            prenomEleve_txt.Text = listeEleves[numSelectionne].Prenom;
            dateNaissancePicker.Text = listeEleves[numSelectionne].Date_naissance.ToString();
            telEleve_txt.Text = listeEleves[numSelectionne].Tel_eleve.ToString();
            telParent_txt.Text = listeEleves[numSelectionne].Tel_parent.ToString();
            TierTempsTrue.Checked = listeEleves[numSelectionne].Tier_temps;
            commentSante_text.Text = listeEleves[numSelectionne].Commentaire_sante;

            lblClasse_cmbx.DataSource = listeLibelleClasse;
            lblClasse_cmbx.DisplayMember = "LibelleClasse";
            lblClasse_cmbx.ValueMember = "IdClasse";
            #endregion
        }
        #endregion

        #region Contrôles de saisies
        #region Contrôle de saisie sur le nom de l'élève
        private void nomElv_cmbx_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(nomElv_cmbx.Text))
            {
                // Set the error if the name is not valid.
                errProNom.SetError(this.nomElv_cmbx, "Le nom est requis et ne dois pas être vide !");
            }
            else if (isLetter(nomEleve.Text) == false)
            {
                // Set the error if the name is not valid.
                errProNom.SetError(this.nomElv_cmbx, "Le nom ne doit pas contenir de chiffres !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProNom.SetError(this.nomElv_cmbx, String.Empty);
            }
        }
        #endregion

        #region Contrôle de saisie sur le prénom de l'élève
        private void prenomEleve_txt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(prenomEleve_txt.Text))
            {
                // Set the error if the name is not valid.
                errProNom.SetError(this.prenomEleve_txt, "Le prénom est requis et ne dois pas être vide !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProNom.SetError(this.prenomEleve_txt, String.Empty);
            }
        }
        #endregion

        #region Contrôle de saisie sur la date de naissance de l'élève
        private void dateNaissancePicker_Validating(object sender, CancelEventArgs e)
        {
            DateTime date;
            if (DateTime.Parse(dateNaissancePicker.Text) == DateTime.Now)
            {
                // Set the error if the name is not valid.
                errProDateNaissance.SetError(this.dateNaissancePicker, "L'élève ne peut être né aujourd'hui !");
            }
            else if (!DateTime.TryParse(dateNaissancePicker.Text, out date))
            {
                // Set the error if the name is not valid.
                errProDateNaissance.SetError(this.dateNaissancePicker, "La date est incorrecte !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProDateNaissance.SetError(this.dateNaissancePicker, String.Empty);
            }
        }
        #endregion

        #region Contrôle de saisie sur le téléphone de l'élève
        private void telEleve_txt_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(telEleve_txt.Text))
            {
                // Set the error if the name is not valid.
                errProTelPar.SetError(this.telParent_txt, "Le numéro de téléphone de l'élève est requis et ne dois pas être vide !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProTelEleve.SetError(this.telEleve_txt, String.Empty);
            }
        }
        #endregion

        #region Contrôle de saisie sur le téléphone des parents
        private void telParent_txt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(telParent_txt.Text))
            {
                // Set the error if the name is not valid.
                errProTelPar.SetError(this.telParent_txt, "Le numéro de téléphone des parents est requis et ne dois pas être vide !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProTelPar.SetError(this.telParent_txt, String.Empty);
            }
        }
        #endregion

        #region Contrôle de saisie sur le libellé de la classe
        private void lblClasse_cmbx_Validating(object sender, CancelEventArgs e)
        {
            if ((int)lblClasse_cmbx.SelectedValue == 0)
            {
                // Set the error if the name is not valid.
                errProClasse.SetError(this.lblClasse_cmbx, "Veuillez sélectionner une classe !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProClasse.SetError(this.lblClasse_cmbx, String.Empty);
            }
        }
        #endregion

        #region Contrôle de saisie sur le commentaire
        private void commentSante_text_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(commentSante_text.Text))
            {
                // Set the error if the name is not valid.
                errProCommentaire.SetError(this.commentSante_text, "Le commentaire est requis et ne dois pas être vide !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProCommentaire.SetError(this.commentSante_text, String.Empty);
            }
        }
        #endregion
        #endregion

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
        #endregion   
    }
}