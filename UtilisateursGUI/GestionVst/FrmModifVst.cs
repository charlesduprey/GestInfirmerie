using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UtilisateursGUI.GestionVst
{
    public partial class FrmModifVst : Form
    {
        #region
        public FrmModifVst()
        {
            InitializeComponent();
        }
        #endregion

        #region Boutons du formulaire
        #region Bouton sauvegarder
        private void saveBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Bouton fermer
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion
    }
}
