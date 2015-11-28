using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilisateursBLL;
using UtilisateursBO;

namespace UtilisateursGUI.GestionMdc
{
    public partial class FrmAjoutMdc : Form
    {
        public FrmAjoutMdc()
        {
            InitializeComponent();
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
