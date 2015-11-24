using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UtilisateursGUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void appelMdlLectue_Click(object sender, EventArgs e)
        {
            FrmModuleLecture FrmModLect;
            FrmModLect = new FrmModuleLecture();
            FrmModLect.ShowDialog(); // ouverture du formulaire
            FrmModLect.Close(); // fermeture du formulaire
        }

        private void fmrButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
