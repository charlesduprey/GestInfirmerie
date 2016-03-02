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

namespace UtilisateursGUI.GestionMdc
{
    public partial class FrmSuprMdc : Form
    {
        #region Gestion du formulaire
        #region Initialisation du formulaire
        public FrmSuprMdc()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            UtilisateursBLL.GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Eleve"]);

            // Création d'un objet List de médicaments à afficher dans la liste
            liste = GestionMedicament.GetMedicaments();

            lblMdc_list.DataSource = liste;
            lblMdc_list.DisplayMember = "LblMdc";
            lblMdc_list.ValueMember = "IdMdc";

            numSelectionne = (int)lblMdc_list.SelectedIndex;
        }
        #endregion

        #region Attributs communs à certaines méthodes
        private int numSelectionne;
        List<Medicament> liste;
        #endregion

        #region Bouton Fermer
        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion

        #region Actions concernant la liste déroulante des libellés des médicaments
        private void lblMdc_list_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int numSelectionne = (int)lblMdc_list.SelectedIndex;
        }
        #endregion

        #region Boutons du formulaire
        #region Bouton archiver
        private void archBtn_Click(object sender, EventArgs e)
        {
            // Récupération des données du formulaire
            string libelle = liste[numSelectionne].LblMdc;
            bool ach = liste[numSelectionne].ArchivageMdc;
            Medicament unMedicament = new Medicament(numSelectionne, libelle, ach);

            // Appel de la méthode SupprimerMedicament() de la GestionMedicament
            GestionMedicament.ArchiveMedicament(unMedicament);
        }
        #endregion

        #region Bouton Supprimer
        private void suprBtn_Click(object sender, EventArgs e)
        {
            // Récupération des données du formulaire
            string libelle = liste[numSelectionne].LblMdc;
            bool ach = liste[numSelectionne].ArchivageMdc;
            
            // Appel de la méthode SupprimerMedicament() de la GestionMedicament
            int nbEnr = GestionMedicament.SupprimerMedicament(numSelectionne);

            #region Message s'il existe des médicaments prescrits
            if (nbEnr != 0)
            {
                MessageBox.Show("L'élément a été prescrit, il ne peut pas être suprimé mais archivé !",
                    "Message",
                    MessageBoxButtons.OK);
            }
            #endregion
        }
        #endregion
        #endregion
    }
}