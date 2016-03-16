using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilisateursBO; // Référence la couche BO
using UtilisateursBLL;
using System.Configuration; // Référence la couche BLL

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
            listeEleves = GestionEleve.GetEleves();

            lblClasse_cmbx.DataSource = GestionClasse.GetClasses();
            lblClasse_cmbx.DisplayMember = "LibelleClasse";
            lblClasse_cmbx.SelectedIndex = listeEleves[numSelectionne].Id_classe - 1;
        }
        #endregion

        #region Attributs de l'application

        //  private int nbClasse;
        //  private int ind = 0;
        private List<Eleve> listeEleves; // initialisation de la liste
        // private List<string> listeNomClasses;
        #endregion

        #region Boutons du formulaire
        #region Bouton Enregistrer
        private void saveBtnEleve_Click(object sender, EventArgs e)
        {

            //GestionEleve.AjoutEleve(unEleve);
            bool archiveEleve = false;
            #region Création d'un eleve
            Eleve unEleve = new Eleve(
                nomEleve_txt.Text,
                prenomEleve_txt.Text,
                DateTime.Parse(dateTimePicker1.Text),
                int.Parse(telEleve_txt.Text),
                int.Parse(telParent_txt.Text),
                tiertemp.Checked,               
                commentSante_text.Text,
                archiveEleve,
                lblClasse_cmbx.SelectedIndex + 1
                
            );

            GestionEleve.AjoutEleve(unEleve);
            #endregion
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

        private void lblClasse_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tiertemp_CheckedChanged(object sender, EventArgs e)
        {

        }

        public int numSelectionne { get; set; }
    }
}
