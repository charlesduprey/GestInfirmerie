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
            string nomMedic = (nomMdc_txt.Text);
            bool achivMedic = false;

            Medicament mdc;
            mdc = new Medicament(nomMedic, achivMedic);

            GestionMedicament.CreerMedicament(mdc);
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
