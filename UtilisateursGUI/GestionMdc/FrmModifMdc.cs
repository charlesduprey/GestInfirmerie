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
        int numSelectionne;
        string libelle;
        #region Gestion du formulaire
        #region Initialisation du Formulaire de modification
        public FrmModifMdc()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            UtilisateursBLL.GestionMedicament.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Eleve"]);

            #region Remplissage du combobox des noms de médicaments
            // Création d'un objet List d'Eleves à afficher dans la liste
            listeMdc = GestionMedicament.GetMedicaments();

            MdcLbl.DataSource = listeMdc;
            MdcLbl.DisplayMember = "LblMdc";
            MdcLbl.ValueMember = "IdMdc";

            numSelectionne = (int)MdcLbl.SelectedValue;
            #endregion
        }
        #endregion

        #region Attributs de l'application
        List<Medicament> listeMdc;
        //private int numSelectionne;
        #endregion

        #region Boutons du formulaire
        #region Bouton Sauvegarde
        private void saveBtn_Click(object sender, EventArgs e)
        {
            libelle = MdcLbl.Text;
            MessageBox.Show("idMedic = " + numSelectionne + ", libelle medic = " + MdcLbl.Text + ".");

            #region Création d'un médicament
            Medicament unMedicament = new Medicament(
                (int)MdcLbl.SelectedValue,
                MdcLbl.Text
            );
            GestionMedicament.ModifierMedicament(unMedicament);
            #endregion
        }
        #endregion

        #region Bouton Fermer
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion
        #endregion

        //#region Actions concernant la liste déroulante des libellés des médicaments
        //private void MdcLbl_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    numSelectionne = (int)MdcLbl.SelectedValue;
        //    libelle = MdcLbl.Text;
        //    MessageBox.Show("idMedic = " + numSelectionne + ", libelle medic = " + libelle + ".");
        //}
        //#endregion
    }
}
