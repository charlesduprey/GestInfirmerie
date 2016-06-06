using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilisateursBLL;
using UtilisateursBO; // Référence la couche BLL
using System.Configuration;

namespace UtilisateursGUI.GestionMdc
{
    public partial class FrmAjoutMdc : Form
    {
        public FrmAjoutMdc()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            UtilisateursBLL.GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Eleve"]);
        }

        private void enrBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomMdc_txt.Text))
            {
                #region Affichage du MessageBox.
                MessageBox.Show(
                    this,
                    "Le libellé du médicament est vide ou est incorrect ! Remplissez-le pour continuer.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                #endregion
            }
            else
            {
                string nomMedic = (nomMdc_txt.Text);
                bool achivMedic = false;

                Medicament mdc;
                mdc = new Medicament(nomMedic, achivMedic);

                GestionMedicament.CreerMedicament(mdc);

                #region Affichage du MessageBox.
                MessageBox.Show(
                    this,
                    "Le médicament a bien été enregistré !",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                #endregion
            }
        }

        private void nomMdc_txt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(nomMdc_txt.Text))
            {
                // Set the error if the name is not valid.
                errProMdcTxt.SetError(this.nomMdc_txt, "Le libellé du médicament est requis et ne dois pas être vide !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProMdcTxt.SetError(this.nomMdc_txt, String.Empty);
            }
        }

        private void enrBtn_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(nomMdc_txt.Text))
            {
                // Set the error if the name is not valid.
                errProSave.SetError(this.nomMdc_txt, "Le libellé du médicament est requis et ne dois pas être vide !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProSave.SetError(this.nomMdc_txt, String.Empty);
            }
        }
    }
}
