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

namespace UtilisateursGUI.GestionElv
{
    public partial class FrmAjoutElv : Form
    {
        #region Gestion du projet
        #region Initialisation du formulaire
        public FrmAjoutElv()
        {
            InitializeComponent();
        }
        #endregion

        #region Bouton Fermer
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion

        #region Bouton Enregistrer
        private void saveBtn_Click(object sender, EventArgs e)
        {
            string dateNaissance = dateTimePicker1.Text;
            DateTime laDatedeNaissance = DateTime.Parse(dateNaissance);

            string telEleve = telEleve_txt.Text;
            int leTelEleve = int.Parse(telEleve);

            string telParent = telParent_txt.Text;
            int leTelParent = int.Parse(telParent);

            string idClasse = listeClasse.Text;
            int lIdClasse = int.Parse(idClasse);

            Eleve unEleve = new Eleve(nomEleve.Text, prenomEleve_txt.Text, laDatedeNaissance, leTelEleve, leTelParent, bool.Parse(tierTemps_txt.Text), commentSante_text.Text, lIdClasse, false);

            GestionEleve.AjoutEleve(unEleve);
        }
        #endregion
    }
}
