using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilisateursGUI;
using CSV_import_export;


namespace UtilisateursGUI
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void btnImportCSV_Click(object sender, EventArgs e)
        {
            frmMain frmCsv = new frmMain();
            frmCsv.ShowDialog(); // ouverture du formulaire
            frmCsv.Close(); // fermeture du formulaire
        }
        
    }
}
