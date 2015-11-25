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
        #region Initialisation du menu
        public Menu()
        {
            InitializeComponent();
        }
        #endregion

        #region Bouton pour appeler le datagridview
        private void appelMdlLectue_Click(object sender, EventArgs e)
        {
            FrmModuleLecture FrmModLect;
            FrmModLect = new FrmModuleLecture();
            FrmModLect.ShowDialog(); // ouverture du formulaire
            FrmModLect.Close(); // fermeture du formulaire
        }
        #endregion

        #region Bouton Fermer
        private void fmrButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
