using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilisateursBO; // Référence la couche BO
using UtilisateursBLL; // Référence la couche BLL
using System.Configuration;

namespace UtilisateursGUI.GestionElv
{
    public partial class FrmAjoutElv : Form
    {
        #region Gestion du projet
        #region Initialisation du formulaire
        public FrmAjoutElv()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            UtilisateursBLL.GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Eleve"]);

            //uneGestionEleve = new List<GestionEleve>();

            //GestionEleve unEleve = new GestionEleve();
            //uneGestionEleve = unEleve.GetEleve();

            // Création d'un objet List d'Eleves à afficher dans la liste
            listeClasses = GestionClasse.GetClasses();

            /*// Création d'un objet List de classes à afficher dans la liste
            int nbClasse = GestionClasse.GetNbClasses();
            List<string> listeLibelleClasses = new List<string>();

            for (int id = 0; id < nbClasse; id++)
            {
                listeLibelleClasses.Add(GestionEleve.GetLeNomDeClasse(id));
            }*/


            for (int id = 0; id < listeClasses.Count; id++)
            {
                idDeClasse = listeClasses[id].IdClasse;
                libelle = listeClasses[id].NiveauClasse + " " + listeClasses[id].LibelleClasse;

                libelleClasse = new Classe(idDeClasse, libelle);

                listeLibelleClasse.Add(libelleClasse);
            }

            lblClasse_cmbx.DataSource = listeLibelleClasse;
            lblClasse_cmbx.DisplayMember = "LibelleClasse";
            lblClasse_cmbx.ValueMember = "IdClasse";
        }
        #endregion

        #region Attributs de l'application
        //  private int nbClasse;
        //  private int ind = 0;
        private int idDeClasse;
        private string libelle;
        private List<Classe> listeLibelleClasse = new List<Classe>();
        private List<Classe> listeClasses;
        private Classe libelleClasse;
        public int numSelectionne { get; set; }
        #endregion

        #region Boutons du formulaire
        #region Bouton Enregistrer
        private void saveBtn_Click(object sender, EventArgs e)
        {
            /*Eleve unEleve = new Eleve(
                nomEleve_txt.Text,
                prenomEleve_txt.Text,
                DateTime.Parse(dateTimePicker1.Text),
                int.Parse(telEleve_txt.Text),
                int.Parse(telParent_txt.Text),
                TierTempsTrue.Checked,
                commentSante_text.Text,
                false,
                id_classe);*/

            GestionEleve.AjoutEleve(
                new Eleve(
                    nomEleve_txt.Text,
                    prenomEleve_txt.Text,
                    DateTime.Parse(dateTimePicker1.Text),
                    int.Parse(telEleve_txt.Text),
                    int.Parse(telParent_txt.Text),
                    TierTempsTrue.Checked,
                    commentSante_text.Text,
                    false,
                    (int)lblClasse_cmbx.SelectedValue));

            // Initializes the variables to pass to the MessageBox.Show method.
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(
                this,
                "Élève enregistré. Souhaitez-vous en saisir un autre ?",
                "Valider",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (result == DialogResult.No)
            {
                this.Close();
            }
        }
        #endregion

        #region Bouton Fermer
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion
        #endregion
    }
}
