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
    }
}
