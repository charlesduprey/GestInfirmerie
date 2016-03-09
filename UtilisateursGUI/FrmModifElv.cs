using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using UtilisateursBO; // Référence la couche BO
using UtilisateursBLL; // Référence la couche BLL

namespace UtilisateursGUI
{
    public partial class FrmModifElv : Form
    {
        private int numSelectionne;
        
        #region Initialisation du Formulaire de modification
        public FrmModifElv()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            UtilisateursBLL.GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Eleve"]);

            //uneGestionEleve = new List<GestionEleve>();

            //GestionEleve unEleve = new GestionEleve();
            //uneGestionEleve = unEleve.GetEleve();

            // Création d'un objet List d'Eleve à afficher dans la liste
            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleve.GetEleves();

            nomElv_list.DataSource = liste;
            nomElv_list.DisplayMember = "Nom";
            nomElv_list.ValueMember = "Id_eleves";

            numSelectionne = (int)nomElv_list.SelectedValue - 1;

            #region Remplissage des cases
            prenomEleve_txt.Text = liste[numSelectionne].Prenom;
            dateTimePicker1.Text = liste[numSelectionne].Date_naissance.ToString();
            telEleve_txt.Text = liste[numSelectionne].Tel_eleve.ToString();
            telParent_txt.Text = liste[numSelectionne].Tel_parent.ToString();
            tierTemps_txt.Text = liste[numSelectionne].Tier_temps;
            commentSante_text.Text = liste[numSelectionne].Commentaire_sante;
            idClasse_txt.Text = liste[numSelectionne].Id_classe.ToString();
            #endregion
        }
        #endregion

        #region Actions concernant la liste déroulante des noms des élèves
        private void nomElv_list_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int numSelectionne = (int)nomElv_list.SelectedValue - 1;

            #region Création de la liste pour récupérer les élèves
            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleve.GetEleves();
            #endregion

            #region Remplissage des cases
            prenomEleve_txt.Text = liste[numSelectionne].Prenom;
            dateTimePicker1.Text = liste[numSelectionne].Date_naissance.ToString();
            telEleve_txt.Text = liste[numSelectionne].Tel_eleve.ToString();
            telParent_txt.Text = liste[numSelectionne].Tel_parent.ToString();
            tierTemps_txt.Text = liste[numSelectionne].Tier_temps;
            commentSante_text.Text = liste[numSelectionne].Commentaire_sante;
            idClasse_txt.Text = liste[numSelectionne].Id_classe.ToString();
            #endregion
        }
        #endregion
        
        #region Bouton Enregistrer
        private void save_btn_Click(object sender, EventArgs e)
        {
            #region Création de la liste pour récupérer les élèves
            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleve.GetEleves();
            #endregion

            string nom = liste[numSelectionne].Nom;
            
            string dateNaissance = dateTimePicker1.Text;
            DateTime laDateNaissance = DateTime.Parse(dateNaissance);

            string telEleve = telEleve_txt.Text;
            int leTelEleve = int.Parse(telEleve);

            string telParent = telParent_txt.Text;
            int leTelParent = int.Parse(telParent);

            string idClasse = idClasse_txt.Text;
            int lIdClasse = int.Parse(idClasse);

            GestionEleve.ModifierEleve(numSelectionne, nom, prenomEleve_txt.Text, laDateNaissance, leTelEleve, leTelParent, tierTemps_txt.Text, commentSante_text.Text, lIdClasse);
        }
        #endregion

        #region Bouton Fermer
        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
