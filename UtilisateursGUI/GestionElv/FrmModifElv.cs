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

namespace UtilisateursGUI.GestionElv
{
    public partial class FrmModifElv : Form
    {
        #region Gestion du formulaire
        #region Initialisation du Formulaire de modification
        public FrmModifElv()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            UtilisateursBLL.GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Eleve"]);

            //uneGestionEleve = new List<GestionEleve>();

            //GestionEleve unEleve = new GestionEleve();
            //uneGestionEleve = unEleve.GetEleve();

            // Création d'un objet List d'Eleves à afficher dans la liste
            listeEleves = GestionEleve.GetEleves();
            
            nomElv_cmbx.DataSource = listeEleves;
            nomElv_cmbx.DisplayMember = "Nom";
            nomElv_cmbx.ValueMember = "Id_eleves";

            numSelectionne = (int)nomElv_cmbx.SelectedIndex;

            #region Remplissage des cases
            prenomEleve_txt.Text = listeEleves[numSelectionne].Prenom;
            dateTimePicker1.Text = listeEleves[numSelectionne].Date_naissance.ToString();
            telEleve_txt.Text = listeEleves[numSelectionne].Tel_eleve.ToString();
            telParent_txt.Text = listeEleves[numSelectionne].Tel_parent.ToString();
            tierTemps_txt.Text = listeEleves[numSelectionne].Tier_temps;
            commentSante_text.Text = listeEleves[numSelectionne].Commentaire_sante;

            lblClasse_cmbx.DataSource = GestionClasse.GetClasses();
            lblClasse_cmbx.DisplayMember = "LibelleClasse";
            lblClasse_cmbx.SelectedIndex = listeEleves[numSelectionne].Id_classe - 1;

            #region Brouillon
            /*
            nbClasse = listeEleves[numSelectionne].Id_classe;
            listeNomClasses = new List<string>();
            nbClasse = GestionClasse.GetClasses().Count;
            listeNomClasses.Add(GestionEleve.GetLeNomDeClasse(numSelectionne));
            
            while (ind <= nbClasse)
            {
                listeNomClasses.Add(GestionEleve.GetLeNomDeClasse(ind));
                ind++;
            }

            lblClasse_cmbx.DataSource = listeNomClasses; //GestionEleve.GetLeNomDeClasse(listeEleves[numSelectionne].Id_classe);
            lblClasse_cmbx.DisplayMember = "LibelleClasse";

            while (ind <= GestionClasse.GetClasses().Count)
            {
                lblClasse_cmbx.Value[ind] = GestionEleve.GetLeNomDeClasse(ind);
                ind++;
            }*/
            #endregion
            #endregion
        }
        #endregion

        #region Attributs de l'application
        private int numSelectionne;
        //  private int nbClasse;
        //  private int ind = 0;
        private List<Eleve> listeEleves; // initialisation de la liste
        // private List<string> listeNomClasses;
        #endregion

        #region Bouton Fermer
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion

        #region Actions concernant la liste déroulante des noms des élèves
        private void nomElv_list_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int numSelectionne = (int)nomElv_cmbx.SelectedIndex;

            #region Remplissage des cases
            prenomEleve_txt.Text = listeEleves[numSelectionne].Prenom;
            dateTimePicker1.Text = listeEleves[numSelectionne].Date_naissance.ToString();
            telEleve_txt.Text = listeEleves[numSelectionne].Tel_eleve.ToString();
            telParent_txt.Text = listeEleves[numSelectionne].Tel_parent.ToString();
            tierTemps_txt.Text = listeEleves[numSelectionne].Tier_temps;
            commentSante_text.Text = listeEleves[numSelectionne].Commentaire_sante;

            lblClasse_cmbx.DataSource = GestionClasse.GetClasses();
            lblClasse_cmbx.DisplayMember = "NiveauClasse" + "LibelleClasse";
            lblClasse_cmbx.SelectedIndex = listeEleves[numSelectionne].Id_classe - 1;

            // lblClasse_cmbx.DataSource = GestionEleve.GetLeNomDeClasse(nbClasse); //GestionEleve.GetLeNomDeClasse(listeEleves[numSelectionne].Id_classe);
            // lblClasse_cmbx.DisplayMember = "LibelleClasse";


            #endregion
        }
        #endregion

        #region Boutons du formulaire
        #region Bouton Enregistrer
        private void saveBtn_Click(object sender, EventArgs e)
        {
            #region Création de la liste pour récupérer les élèves
            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleve.GetEleves();
            #endregion

            int idElv = nomElv_cmbx.SelectedIndex + 1;

            string dateNaissance = dateTimePicker1.Text;
            DateTime laDateNaissance = DateTime.Parse(dateNaissance);

            string telEleve = telEleve_txt.Text;
            int leTelEleve = int.Parse(telEleve);

            string telParent = telParent_txt.Text;
            int leTelParent = int.Parse(telParent);

            int id_classe = lblClasse_cmbx.SelectedIndex + 1;

            Eleve unEleve = new Eleve(idElv, nomElv_cmbx.Text, prenomEleve_txt.Text, laDateNaissance, leTelEleve, leTelParent, tierTemps_txt.Text, commentSante_text.Text, id_classe);

            GestionEleve.ModifierEleve(unEleve);

            MessageBox.Show("idElv = " + idElv.ToString() + ", nom eleve = " + nomElv_cmbx.Text + ", prenom = " + prenomEleve_txt.Text + ", date naissance : " +laDateNaissance + ", tel eleve =" + leTelEleve +", tel Parent " + leTelParent +", Tiers temps = "+ tierTemps_txt.Text + ", Commentaire santé = " + commentSante_text.Text + ", index Classe =  " + lblClasse_cmbx.SelectedIndex.ToString() + "");
        }
        #endregion

        #region Bouton Archiver
        private void archBtn_Click(object sender, EventArgs e)
        {
            GestionEleve.ArchiveEleve(numSelectionne);
        }
        #endregion

        #region Bouton Supprimer
        private void suprBtn_Click(object sender, EventArgs e)
        {
            GestionEleve.SupprimerEleve(numSelectionne);
        }
        #endregion
        #endregion
    }
}
