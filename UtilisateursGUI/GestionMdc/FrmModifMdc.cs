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
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            UtilisateursBLL.GestionMedicament.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Eleve"]);

            #region
            // Création d'un objet List d'Eleves à afficher dans la liste
            listeMdc = GestionMedicament.GetMedicaments();

            libelleMdcLbl.DataSource = listeMdc;
            libelleMdcLbl.DisplayMember = "LblMdc";
            libelleMdcLbl.ValueMember = "IdMdc";

            numSelectionne = (int)libelleMdcLbl.SelectedIndex;
            #endregion
        }

        List<Medicament> listeMdc;
        private int numSelectionne;


        private void saveBtn_Click(object sender, EventArgs e)
        {
            #region Création d'un médicament
            Medicament unMedicament = new Medicament(
                (int)libelleMdcLbl.SelectedValue,
                libelleMdcLbl.Text
            );
            GestionMedicament.ModifierMedicament(unMedicament);
            #endregion
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Actions concernant la liste déroulante des libellés des médicaments
        private void libelleMdcLbl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int numSelectionne = (int)libelleMdcLbl.SelectedIndex;
        }
        #endregion

    }
}
