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

            // Création d'un objet List d'Eleves à afficher dans la liste
            listeEleves = GestionEleve.GetElevesNonArchives();

            // Création d'un objet List de classes à afficher dans la liste
            listeClasses = GestionClasse.GetClasses();

            for (int id = 0; id < listeClasses.Count; id++)
            {
                idClasse = listeClasses[id].IdClasse;
                libelle = listeClasses[id].NiveauClasse + " " + listeClasses[id].LibelleClasse;

                libelleClasse = new Classe(idClasse, libelle);

                listeLibelleClasse.Add(libelleClasse);
            }

            nomElv_cmbx.DataSource = listeEleves;
            nomElv_cmbx.DisplayMember = "Nom";
            nomElv_cmbx.ValueMember = "Id_eleves";

            numSelectionne = (int)nomElv_cmbx.SelectedIndex;
            id_eleve = (int)nomElv_cmbx.SelectedValue;

            #region Remplissage des cases
            if (listeEleves[numSelectionne].ArchiveEleve == false)
            {
                prenomEleve_txt.Text = listeEleves[numSelectionne].Prenom;
                dateTimePicker1.Text = listeEleves[numSelectionne].Date_naissance.ToString();
                telEleve_txt.Text = listeEleves[numSelectionne].Tel_eleve.ToString();
                telParent_txt.Text = listeEleves[numSelectionne].Tel_parent.ToString();
                tierTemps_txt.Text = listeEleves[numSelectionne].Tier_temps.ToString();
                commentSante_text.Text = listeEleves[numSelectionne].Commentaire_sante;

                lblClasse_cmbx.DataSource = listeLibelleClasse;
                lblClasse_cmbx.DisplayMember = "LibelleClasse";
                lblClasse_cmbx.ValueMember = "IdClasse";
            }

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
        private int idClasse;
        //  private int nbClasse;
        //  private int ind = 0;
        private List<Eleve> listeEleves; // initialisation de la liste
        // private List<string> listeNomClasses;
        private int id_eleve;
        private string libelle;
        private List<Classe> listeLibelleClasse = new List<Classe>();
        private List<Classe> listeClasses;
        private Classe libelleClasse;
        #endregion

        #region Boutons du formulaire
        #region Bouton Enregistrer
        private void saveBtn_Click(object sender, EventArgs e)
        {
            #region Création de la liste pour récupérer les élèves
            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleve.GetEleves();
            #endregion

            string dateNaissance = dateTimePicker1.Text;
            DateTime laDateNaissance = DateTime.Parse(dateNaissance);

            string telEleve = telEleve_txt.Text;
            int leTelEleve = int.Parse(telEleve);

            string telParent = telParent_txt.Text;
            int leTelParent = int.Parse(telParent);

            int id_classe = lblClasse_cmbx.SelectedIndex + 1;

            //int id_eleve = (int)nomElv_cmbx.SelectedValue;
            Eleve unEleve = new Eleve(id_eleve, nomElv_cmbx.Text, prenomEleve_txt.Text, laDateNaissance, leTelEleve, leTelParent, bool.Parse(tierTemps_txt.Text), commentSante_text.Text, id_classe, false);

            GestionEleve.ModifierEleve(unEleve);

            MessageBox.Show("idElv = " + id_eleve + ", nom eleve = " + nomElv_cmbx.Text + ", prenom = " + prenomEleve_txt.Text + ", date naissance : " + laDateNaissance + ", tel eleve =" + leTelEleve + ", tel Parent " + leTelParent + ", Tiers temps = " + tierTemps_txt.Text + ", Commentaire santé = " + commentSante_text.Text + ", index Classe =  " + lblClasse_cmbx.SelectedIndex.ToString() + "");
        }
        #endregion

        #region Bouton Archiver
        private void archBtn_Click(object sender, EventArgs e)
        {
            // int num = listeEleves[numSelectionne].Id_eleves;
            int num = (int)nomElv_cmbx.SelectedValue;
            
            // Initializes the variables to pass to the MessageBox.Show method.
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(
                this,
                "Voulez-vous archiver l'élève num" + num + " ? ",
                "Archivage",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (result == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                GestionEleve.ArchiveEleve(num);
            }
        }
        #endregion

        #region Bouton Supprimer
        private void suprBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(nomElv_cmbx.SelectedValue.ToString());
            MessageBox.Show("Voulez-vous supprimer l'élève ? " + id, "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            // contrôle de la possibilité de suppression (afilié à aucune visite)
            bool trouve;

            trouve = GestionEleve.TrouverEleve(id);

            if (trouve == true)
            {
                trouve = true;
                MessageBox.Show("Impossible de supprimer l'élève " + id + " Vous pouvez cependant l'achiver.", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                GestionEleve.SupprimerEleve(id);
            }
            // supression si oui 
        }
        #endregion

        #region Bouton Fermer
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion
        #endregion

        #region Actions concernant la liste déroulante des noms des élèves
        private void nomElv_list_SelectionChangeCommitted(object sender, EventArgs e)
        {
            numSelectionne = (int)nomElv_cmbx.SelectedIndex;
            id_eleve = (int)nomElv_cmbx.SelectedValue;

            #region Remplissage des cases
            prenomEleve_txt.Text = listeEleves[numSelectionne].Prenom;
            dateTimePicker1.Text = listeEleves[numSelectionne].Date_naissance.ToString();
            telEleve_txt.Text = listeEleves[numSelectionne].Tel_eleve.ToString();
            telParent_txt.Text = listeEleves[numSelectionne].Tel_parent.ToString();
            tierTemps_txt.Text = listeEleves[numSelectionne].Tier_temps.ToString();
            commentSante_text.Text = listeEleves[numSelectionne].Commentaire_sante;

            lblClasse_cmbx.DataSource = GestionClasse.GetClasses();
            lblClasse_cmbx.DisplayMember = "NiveauClasse" + "LibelleClasse";
            lblClasse_cmbx.SelectedIndex = listeEleves[numSelectionne].Id_classe - 1;

            // lblClasse_cmbx.DataSource = GestionEleve.GetLeNomDeClasse(nbClasse); //GestionEleve.GetLeNomDeClasse(listeEleves[numSelectionne].Id_classe);
            // lblClasse_cmbx.DisplayMember = "LibelleClasse";
            #endregion
        }
        #endregion
    }
}