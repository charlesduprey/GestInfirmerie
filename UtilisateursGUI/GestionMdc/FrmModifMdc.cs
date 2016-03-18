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
    public partial class FrmModifMdc : Form
    {
        public FrmModifMdc()
        {
            #region Initialisation de la form
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            UtilisateursBLL.GestionMedicament.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Eleve"]);


            listeMedicaments = GestionMedicament.GetMedicaments();

            nommedic.DataSource = listeMedicaments;
            nommedic.DisplayMember = "LblMdc";
            nommedic.ValueMember = "IdMdc";

            numSelectionne = (int)nommedic.SelectedIndex;

            //if (listeMedicaments[numSelectionne].ArchivageMdc == false)
            //{
            //    libellemedic.Text = listeMedicaments[numSelectionne].LblMdc;
            //}
            #endregion
        }

        #region Attributs de l'application
        private int numSelectionne;
        private List<Medicament> listeMedicaments;
        private int idMdc;
        #endregion

        #region Bouton pour sauvegarder la modification
        private void savemodif_Click(object sender, EventArgs e)
        {
            #region Création de la liste pour récupérer les élèves
            List<Medicament> liste = new List<Medicament>();
            liste = GestionMedicament.GetMedicaments();
            #endregion

            Medicament unMedicament = new Medicament(idMdc, nommedic.Text, false);

            #region Création de la liste pour récupérer les medicaments
            //Medicament unMedicament = new Medicament(
            //    (int)nommedic.SelectedValue,
            //    nommedic.Text
            //);
            GestionMedicament.ModifierMedicament(unMedicament);
            MessageBox.Show("idMdc = " + idMdc + ", nom eleve = " + nommedic.Text );
            #endregion
        }
        #endregion

        #region Bouton pour fermer l'application
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
