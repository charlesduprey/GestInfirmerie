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

            numSelectionne = (int)nomElv_cmbx.SelectedIndex;
            #endregion

            #region Remplissage des cases
            if (listeEleves[numSelectionne].ArchiveEleve == false)
            {
                prenomEleve_txt.Text = listeEleves[numSelectionne].Prenom;
                dateTimePicker1.Text = listeEleves[numSelectionne].Date_naissance.ToString();

                lblClasse_cmbx.DataSource = GestionClasse.GetClasses();
                lblClasse_cmbx.DisplayMember = "LibelleClasse";
                lblClasse_cmbx.SelectedIndex = listeEleves[numSelectionne].Id_classe;
            }
            #endregion
            #endregion
        }
        #endregion

        #region Attributs de l'application
        private int numSelectionne;
        //  private int nbClasse;
        //  private int ind = 0;
        private List<Eleve> listeEleves; // initialisation de la liste
        // private List<string> listeNomClasses;
        private int numMedicSelect;
        List<Medicament> liste;
        #endregion

        #region Boutons du formulaire
        #region Boutons Sauvegarder
        private void saveBtn_Click(object sender, EventArgs e)
        {
            #region Création d'une visite
            Visite uneVisite = new Visite(
                motifTxtbx.Text,
                commentTxtbx.Text,
                int.Parse(poulsNumUpDown.Text),
                tellPrYes.Checked,
                backHomeYes.Checked,
                hospitalYes.Checked,
                DateTime.Parse(dateVstPicker.Text),
                DateTime.Parse(dateTimeArv.Text),
                DateTime.Parse(dateTimeDep.Text),
                //nomElv_cmbx.SelectedIndex + 1
                (int)nomElv_cmbx.SelectedValue
            );
            GestionVisite.CreerVisite(uneVisite);
            #endregion

            if (int.Parse(qteNumUpDown.Text) > 0)
            {
                int idVisite = GestionVisite.GetIdVstMax();

                #region Insertion d'une prescription
                Prescription unePrescription = new Prescription(
                    idVisite,
                    (int)lblMdc_list.SelectedValue,
                    int.Parse(qteNumUpDown.Text)
                );

                GestionPrescription.CreerPrescription(unePrescription);
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
        #endregion

        #region Actions concernant la liste déroulante des noms des élèves
        private void nomElv_list_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int numSelectionne = (int)nomElv_cmbx.SelectedIndex;

            #region Remplissage des cases
            prenomEleve_txt.Text = listeEleves[numSelectionne].Prenom;
            dateTimePicker1.Text = listeEleves[numSelectionne].Date_naissance.ToString();

            lblClasse_cmbx.DataSource = GestionClasse.GetClasses();
            lblClasse_cmbx.DisplayMember = "NiveauClasse" + "LibelleClasse";
            lblClasse_cmbx.SelectedIndex = listeEleves[numSelectionne].Id_classe;

            // lblClasse_cmbx.DataSource = GestionEleve.GetLeNomDeClasse(nbClasse); //GestionEleve.GetLeNomDeClasse(listeEleves[numSelectionne].Id_classe);
            // lblClasse_cmbx.DisplayMember = "LibelleClasse";
            #endregion
        }
        #endregion
    }
}