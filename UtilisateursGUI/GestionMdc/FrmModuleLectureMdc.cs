using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using UtilisateursBLL; // Référence la couche Bll
using UtilisateursBO;
using UtilisateursGUI.GestionMdc; // Référence la couche BO

namespace UtilisateursGUI.GestionMdc
{
    public partial class FrmModuleLectureMdc : Form
    {
        #region Gestion du projet
        #region Initialisation du formulaire
        public FrmModuleLectureMdc()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionMedicament.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Eleve"]);

            // Blocage de la génération automatique des colonnes
            MedicsView.AutoGenerateColumns = false;

            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();
            IdColumn.DataPropertyName = "IdMdc";
            IdColumn.HeaderText = "Identifiant du médicament";

            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn LblColumn = new DataGridViewTextBoxColumn();
            LblColumn.DataPropertyName = "LblMdc";
            LblColumn.HeaderText = "Libelle";

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn ArchiveColumn = new DataGridViewTextBoxColumn();
            ArchiveColumn.DataPropertyName = "ArchivageMdc";
            ArchiveColumn.HeaderText = "Archive";

            // Ajout des 2 en-têtes de colonne au datagridview
            MedicsView.Columns.Add(IdColumn);
            MedicsView.Columns.Add(LblColumn);
            MedicsView.Columns.Add(ArchiveColumn);

            // Définition du style apporté au datagridview
            MedicsView.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            MedicsView.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<Medicament> liste = new List<Medicament>();
            liste = GestionMedicament.GetMedicaments();

            // Rattachement de la List à la source de données du datagridview
            MedicsView.DataSource = liste;

            /*
            // On définit le nombre de lignes nécessaires en comptant le nombre d'éléments dans la liste
            MedicsView.Rows.Add(GestionMedicament.GetMedicaments().Count);

            // remplissage des lignes du datagridview
            for (int i = 0; i < GestionMedicament.GetMedicaments().Count; i++)
            {
                MedicsView[0, i].Value = GestionMedicament.GetMedicaments()[i].IdMdc;
                MedicsView[1, i].Value = GestionMedicament.GetMedicaments()[i].LblMdc;
                MedicsView[2, i].Value = GestionMedicament.GetMedicaments()[i].ArchMdc;
            }*/
        }
        #endregion

        #region Bouton Fermer
        private void fmrButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion

        #region Boutons de l'application
        #region Bouton Ajouter
        private void ajoutBtn_Click(object sender, EventArgs e)
        {
            FrmAjoutMdc frmAjout = new FrmAjoutMdc();
            frmAjout.ShowDialog(); // ouverture du formulaire
            frmAjout.Close(); // fermeture du formulaire
        }
        #endregion

        #region Bouton Modifier
        private void modifBtn_Click(object sender, EventArgs e)
        {
            FrmModifMdc frmModif = new FrmModifMdc();
            frmModif.ShowDialog(); // ouverture du formulaire
            frmModif.Close(); // fermeture du formulaire
        }
        #endregion
        #endregion

        #region Bouton Actualiser
        private void actualiserBtn_Click(object sender, EventArgs e)
        {
            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<Medicament> liste = new List<Medicament>();
            liste = GestionMedicament.GetMedicaments();

            // Rattachement de la List à la source de données du datagridview
            MedicsView.DataSource = liste;

            /*  // Effacement de toutes les lignes
             *  MedicsView.Rows.Clear();
             * 
             *  // On définit le nombre de lignes nécessaires en comptant le nombre d'éléments dans la liste
             *  MedicsView.Rows.Add(GestionMedicament.GetMedicaments().Count);
             *  
             *  #region remplissage des lignes du datagridview
             *  for (int i = 0; i < GestionMedicament.GetMedicaments().Count; i++)
             *  {
             *      MedicsView[0, i].Value = GestionMedicament.GetMedicaments()[i].IdMdc;
             *      MedicsView[1, i].Value = GestionMedicament.GetMedicaments()[i].LblMdc;
             *      MedicsView[2, i].Value = GestionMedicament.GetMedicaments()[i].ArchMdc;
             *  }
             *  #endregion
             */
        }
        #endregion
    }
}
