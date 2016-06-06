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
using smoCommon = Microsoft.SqlServer.Management.Common;
using smo = Microsoft.SqlServer.Management.Smo;

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

        private void button2_Click(object sender, EventArgs e)
        {
            string _instance = "localhost";
            string _repertoireSauvegarde = @"C:\Documents and Settings\Guillaume\SQLSave";

            string _horodatage = DateTime.Now.ToString("yyyyMMdd_hhmmss");
            smoCommon.ServerConnection sc = new smoCommon.ServerConnection(_instance);
            sc.Connect();
            smo.Server myServer = new smo.Server(sc);
            foreach (smo.Database myDb in myServer.Databases)
            {
                if (myDb.Name == "GEST_INFIRMERIE")
                {
                    smo.Backup myBackup = new smo.Backup();
                    myBackup.Database = myDb.Name;

                    // Définit le type de sauvegarde à effectuer  (base ou log)
                    myBackup.Action = smo.BackupActionType.Database;

                    // Sauvegarde FULL = false, Sauvegarde DIFF = true
                    myBackup.Incremental = false;

                    // Activation de la compression de la sauvegarde
                    myBackup.CompressionOption = smo.BackupCompressionOptions.Default;

                    // Ajout du device. Ici il s'agit d'un fichier mais on pourrait envisager une sauvegarde sur bande
                    myBackup.Devices.AddDevice(_repertoireSauvegarde + myDb.Name + "_" + _horodatage + ".bak", smo.DeviceType.File);
                    try
                    {
                        myBackup.SqlBackup(myServer);
                        Console.WriteLine(myDb.Name + " sauvegardée à " + DateTime.Now.ToString());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            sc.Disconnect();
        }
    }
}
