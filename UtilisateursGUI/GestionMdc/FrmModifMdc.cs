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
        #region Gestion du formulaire
        #region Initialisation du formulaire
        public FrmModifMdc()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            UtilisateursBLL.GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Eleve"]);

            // Création d'un objet List de médicaments à afficher dans la liste
            listeMedicaments = GestionMedicament.GetMedicaments();

            libelleMdcCmbx.DataSource = listeMedicaments;
            libelleMdcCmbx.DisplayMember = "LblMdc";
            libelleMdcCmbx.ValueMember = "IdMdc";

            int id = (int)libelleMdcCmbx.SelectedValue;
        }
        #endregion

        #region Attributs de l'application
        private List<Medicament> listeMedicaments;
        int id;
        #endregion

        #region Boutons du formulaire
        #region Bouton sauvegarder
        private void saveBtn_Click(object sender, EventArgs e)
        {
            //Medicament unMedicament = new Medicament((int)libelleMdcCmbx.SelectedValue, libelleMdcCmbx.Text);
            MessageBox.Show("id = " + id + ", libelle = " + libelleMdcCmbx.Text + "");

            Medicament unMedicament = new Medicament(id, libelleMdcCmbx.Text);

            GestionMedicament.ModifierMedicament(unMedicament);

            // Initializes the variables to pass to the MessageBox.Show method.
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(
                this,
                "Élève enregistré. Souhaitez-vous en saisir un autre ?",
                "Valider",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (result == DialogResult.No)
            {
                this.Close();
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
        #endregion

        #region Action en fonction du combobox
        private void libelleMdcCmbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id = (int)libelleMdcCmbx.SelectedValue;
        }
        #endregion
    }
}
