using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using UtilisateursGUI.GestionElv;
using UtilisateursBLL; // Référence la couche Bll
using UtilisateursBO; // Référence la couche BO

namespace UtilisateursGUI.GestionElv
{
    public partial class FrmModuleLectureElv : Form
    {
        #region Initialisation du formulaire
        public FrmModuleLectureElv()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Eleve"]);

            // Blocage de la génération automatique des colonnes
            StudentsView.AutoGenerateColumns = false;

            #region Création des colonnes
            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();
            IdColumn.DataPropertyName = "id_eleves";
            IdColumn.HeaderText = "Identifiant de l'élève";

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
            CommentSanteColumn.DataPropertyName = "Commentaire_sante";
            CommentSanteColumn.HeaderText = "Commentaire santé";

            // Création d'une en-tête de colonne pour la colonne 9
            DataGridViewTextBoxColumn idClasseColumn = new DataGridViewTextBoxColumn();
            idClasseColumn.DataPropertyName = "Commentaire_sante";
            idClasseColumn.HeaderText = "Identifiant de la classe";
            #endregion

            #region Ajout des 9 en-têtes de colonne au datagridview
            StudentsView.Columns.Add(IdColumn);
            StudentsView.Columns.Add(NomColumn);
            StudentsView.Columns.Add(PrenomColumn);
            StudentsView.Columns.Add(dateNaissanceColumn);
            StudentsView.Columns.Add(TelEleveColumn);
            StudentsView.Columns.Add(TelParentColumn);
            StudentsView.Columns.Add(TierTempsColumn);
            StudentsView.Columns.Add(CommentSanteColumn);
            StudentsView.Columns.Add(idClasseColumn);
            #endregion

            #region Définition du style apporté au datagridview
            StudentsView.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            StudentsView.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            #endregion

            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleve.GetEleves();

            /*  // Rattachement de la List à la source de données du datagridview
             *  StudentsView.DataSource = liste;
             */

            #region Code alternatif de remplissage du datagridview utilisé plus pratique mais moins "propre" que celui du dessus
            // Effacement de toutes les lignes
            StudentsView.Rows.Clear();

            // On définit le nombre de lignes nécessaires en comptant le nombre d'éléments dans la liste
            StudentsView.Rows.Add(GestionEleve.GetEleves().Count);

            // Remplissage des lignes du datagridview
            for (int i = 0; i < GestionEleve.GetEleves().Count; i++)
            {
                StudentsView[0, i].Value = liste[i].Id_eleves;
                StudentsView[1, i].Value = liste[i].Nom;
                StudentsView[2, i].Value = liste[i].Prenom;
                StudentsView[3, i].Value = liste[i].Date_naissance;
                StudentsView[4, i].Value = liste[i].Tel_eleve;
                StudentsView[5, i].Value = liste[i].Tel_parent;

                StudentsView[6, i].Value = liste[i].Tier_temps;
                StudentsView[7, i].Value = liste[i].Commentaire_sante;
                StudentsView[8, i].Value = GestionEleve.GetLeNomDeClasse(liste[i].Id_classe);
            }
            #endregion
        }
        #endregion

        #region Boutons du module
        #region Bouton afficher les élèves archivés
        private void elvArchBtn_Click(object sender, EventArgs e)
        {
            elementsAffiches.Text = "Tableau des élèves archivés";

            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleve.GetElevesArchives();

            /*  // Rattachement de la List à la source de données du datagridview
             *  StudentsView.DataSource = liste;
             */

            #region Code alternatif de remplissage du datagridview utilisé plus pratique mais moins "propre" que celui du dessus
            // Effacement de toutes les lignes
            StudentsView.Rows.Clear();

            if (GestionEleve.GetElevesArchives().Count == 0)
            {
                // Ajout d'une ligne dans le DataGridView
                StudentsView.Rows.Add(1);
                
                // Remplissage d'une ligne vide vue qu'il y a rien
                StudentsView[0, 0].Value = "";
                StudentsView[1, 0].Value = "";
                StudentsView[2, 0].Value = "";
                StudentsView[3, 0].Value = "";
                StudentsView[4, 0].Value = "";
                StudentsView[5, 0].Value = "";
                StudentsView[6, 0].Value = "";
                StudentsView[7, 0].Value = "";
                StudentsView[8, 0].Value = "";
            }
            else
            {
                // On définit le nombre de lignes nécessaires en comptant le nombre d'éléments dans la liste
                StudentsView.Rows.Add(GestionEleve.GetElevesArchives().Count);

                // Remplissage des lignes du datagridview
                for (int i = 0; i < GestionEleve.GetElevesArchives().Count; i++)
                {
                    StudentsView[0, i].Value = liste[i].Id_eleves;
                    StudentsView[1, i].Value = liste[i].Nom;
                    StudentsView[2, i].Value = liste[i].Prenom;
                    StudentsView[3, i].Value = liste[i].Date_naissance;
                    StudentsView[4, i].Value = liste[i].Tel_eleve;
                    StudentsView[5, i].Value = liste[i].Tel_parent;
                    StudentsView[6, i].Value = liste[i].Tier_temps;
                    StudentsView[7, i].Value = liste[i].Commentaire_sante;
                    StudentsView[8, i].Value = GestionEleve.GetLeNomDeClasse(liste[i].Id_classe);
                }
            }
            #endregion
        }
        #endregion

        #region Bouton afficher les élèves non archivés
        private void elvNonArchBtn_Click(object sender, EventArgs e)
        {
            elementsAffiches.Text = "Tableau des élèves non archivés";

            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleve.GetElevesNonArchives();

            /*  // Rattachement de la List à la source de données du datagridview
             *  StudentsView.DataSource = liste;
             */

            #region Code alternatif de remplissage du datagridview utilisé plus pratique mais moins "propre" que celui du dessus
            // Effacement de toutes les lignes
            StudentsView.Rows.Clear();

            // On définit le nombre de lignes nécessaires en comptant le nombre d'éléments dans la liste
            StudentsView.Rows.Add(GestionEleve.GetElevesNonArchives().Count);

            // Remplissage des lignes du datagridview
            for (int i = 0; i < GestionEleve.GetElevesNonArchives().Count; i++)
            {
                StudentsView[0, i].Value = liste[i].Id_eleves;
                StudentsView[1, i].Value = liste[i].Nom;
                StudentsView[2, i].Value = liste[i].Prenom;
                StudentsView[3, i].Value = liste[i].Date_naissance;
                StudentsView[4, i].Value = liste[i].Tel_eleve;
                StudentsView[5, i].Value = liste[i].Tel_parent;

                StudentsView[6, i].Value = liste[i].Tier_temps;
                StudentsView[7, i].Value = liste[i].Commentaire_sante;
                StudentsView[8, i].Value = GestionEleve.GetLeNomDeClasse(liste[i].Id_classe);
            }
            #endregion
        }
        #endregion

        #region Bouton Voir tous les élèves
        private void actualiserBtn_Click(object sender, EventArgs e)
        {
            elementsAffiches.Text = "Tableau de tous les élèves";

            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleve.GetEleves();

            /*  // Rattachement de la List à la source de données du datagridview
             *  StudentsView.DataSource = liste;
             */

            #region CODE ALTERNATIF DE REMPLISSAGE DU DATAGRIDVIEW MAIS MOINS "PROPRE"
            // Effacement de toutes les lignes
            StudentsView.Rows.Clear();

            // On définit le nombre de lignes nécessaires en comptant le nombre d'éléments dans la liste
            StudentsView.Rows.Add(GestionEleve.GetEleves().Count);

            // remplissage des lignes du datagridview
            for (int i = 0; i < GestionEleve.GetEleves().Count; i++)
            {
                StudentsView[0, i].Value = GestionEleve.GetEleves()[i].Id_eleves;
                StudentsView[1, i].Value = GestionEleve.GetEleves()[i].Nom;
                StudentsView[2, i].Value = GestionEleve.GetEleves()[i].Prenom;
                StudentsView[3, i].Value = GestionEleve.GetEleves()[i].Date_naissance;
                StudentsView[4, i].Value = GestionEleve.GetEleves()[i].Tel_eleve;
                StudentsView[5, i].Value = GestionEleve.GetEleves()[i].Tel_parent;
                StudentsView[6, i].Value = GestionEleve.GetEleves()[i].Tier_temps;
                StudentsView[7, i].Value = GestionEleve.GetEleves()[i].Commentaire_sante;
                StudentsView[8, i].Value = GestionEleve.GetLeNomDeClasse(GestionEleve.GetEleves()[i].Id_classe);
            }
            #endregion
        }
        #endregion

        #region Bouton Ajout
        private void ajoutBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Bouton Modifier/Supprimer
        private void modifBtn_Click(object sender, EventArgs e)
        {
            FrmModifElv FrmModLect;
            FrmModLect = new FrmModifElv();
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
        #endregion
    }
}
