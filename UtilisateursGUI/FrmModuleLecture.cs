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
using UtilisateursBO; // Référence la couche BO

namespace UtilisateursGUI
{
    public partial class FrmModuleLecture : Form
    {
        public FrmModuleLecture()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Eleve"]);

            // Blocage de la génération automatique des colonnes
            StudentsView.AutoGenerateColumns = false;

            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();
            IdColumn.DataPropertyName = "id_eleves";
            IdColumn.HeaderText = "Identifiant del'élève";

            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();
            NomColumn.DataPropertyName = "nom";
            NomColumn.HeaderText = "Nom";

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn PrenomColumn = new DataGridViewTextBoxColumn();
            PrenomColumn.DataPropertyName = "prenom";
            PrenomColumn.HeaderText = "Prénom";

            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn dateNaissanceColumn = new DataGridViewTextBoxColumn();
            dateNaissanceColumn.DataPropertyName = "date_naissance";
            dateNaissanceColumn.HeaderText = "Date de naissance";

            // Création d'une en-tête de colonne pour la colonne 5
            DataGridViewTextBoxColumn TelEleveColumn = new DataGridViewTextBoxColumn();
            TelEleveColumn.DataPropertyName = "tel_eleve";
            TelEleveColumn.HeaderText = "Telephone de l'élève";

            // Création d'une en-tête de colonne pour la colonne 6
            DataGridViewTextBoxColumn TelParentColumn = new DataGridViewTextBoxColumn();
            TelParentColumn.DataPropertyName = "tel_parent";
            TelParentColumn.HeaderText = "Téléphone du parent";

            // Création d'une en-tête de colonne pour la colonne 7
            DataGridViewTextBoxColumn TierTempsColumn = new DataGridViewTextBoxColumn();
            TierTempsColumn.DataPropertyName = "tier_temps";
            TierTempsColumn.HeaderText = "Tier temps";

            // Création d'une en-tête de colonne pour la colonne 8
            DataGridViewTextBoxColumn CommentSanteColumn = new DataGridViewTextBoxColumn();
            CommentSanteColumn.DataPropertyName = "commentaire_sante";
            CommentSanteColumn.HeaderText = "Commentaire santé";

            // Création d'une en-tête de colonne pour la colonne 9
            DataGridViewTextBoxColumn idClasseColumn = new DataGridViewTextBoxColumn();
            idClasseColumn.DataPropertyName = "id_classe";
            idClasseColumn.HeaderText = "Identifiant de la classe";

            // Ajout des 2 en-têtes de colonne au datagridview
            StudentsView.Columns.Add(IdColumn);
            StudentsView.Columns.Add(NomColumn);
            StudentsView.Columns.Add(PrenomColumn);
            StudentsView.Columns.Add(dateNaissanceColumn);
            StudentsView.Columns.Add(TelEleveColumn);
            StudentsView.Columns.Add(TelParentColumn);
            StudentsView.Columns.Add(TierTempsColumn);
            StudentsView.Columns.Add(CommentSanteColumn);
            StudentsView.Columns.Add(idClasseColumn);

            // Définition du style apporté au datagridview
            StudentsView.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            StudentsView.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleve.GetEleves();

            // Rattachement de la List à la source de données du datagridview
            StudentsView.DataSource = liste;
        }

        private void fmrButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
