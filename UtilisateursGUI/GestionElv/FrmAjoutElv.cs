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
                    DateTime.Parse(dateNaissancePicker.Text),
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
                "Élève enregistré. Souhaitez-vous en saisir un autre ?" + DateTime.Now,
                "Valider",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (result == DialogResult.No)
            {
                nomEleve_txt.Text = String.Empty;
                prenomEleve_txt.Text = String.Empty;
                telEleve_txt.Text = String.Empty;
                telParent_txt.Text = String.Empty;
                commentSante_text.Text = String.Empty;
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

        #region Contrôles de saisies
        #region Contrôle de saisie sur le nom de l'élève
        private void nomEleve_txt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(nomEleve_txt.Text))
            {
                // Set the error if the name is not valid.
                errProNom.SetError(this.nomEleve_txt, "Le nom est requis et ne dois pas être vide !");
            }
            else if (isLetter(nomEleve.Text) == false)
            {
                // Set the error if the name is not valid.
                errProNom.SetError(this.nomEleve_txt, "Le nom est requis et ne dois pas être vide !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProNom.SetError(this.nomEleve_txt, String.Empty);
            }
        }
        #endregion

        #region Contrôle de saisie sur le nom de l'élève
        private void prenomEleve_txt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(prenomEleve_txt.Text))
            {
                // Set the error if the name is not valid.
                errProNom.SetError(this.prenomEleve_txt, "Le prénom est requis et ne dois pas être vide !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProNom.SetError(this.prenomEleve_txt, String.Empty);
            }
        }
        #endregion

        #region Contrôle de saisie sur la date de naissance
        private void dateNaissancePicker_Validating(object sender, CancelEventArgs e)
        {
            DateTime date;
            if (DateTime.Parse(dateNaissancePicker.Text) == DateTime.Now)
            {
                // Set the error if the name is not valid.
                errProDateNaissance.SetError(this.dateNaissancePicker, "L'élève ne peut être né aujourd'hui !");
            }
            else if (!DateTime.TryParse(dateNaissancePicker.Text, out date))
            {
                // Set the error if the name is not valid.
                errProDateNaissance.SetError(this.dateNaissancePicker, "La date est incorrecte !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProDateNaissance.SetError(this.dateNaissancePicker, String.Empty);
            }
        }
        #endregion

        #region Contrôle de saisie sur le téléphone de l'élève
        private void telEleve_txt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(telEleve_txt.Text))
            {
                // Set the error if the name is not valid.
                errProTelPar.SetError(this.telParent_txt, "Le numéro de téléphone de l'élève est requis et ne dois pas être vide !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProTelEleve.SetError(this.telEleve_txt, String.Empty);
            }
        }
        #endregion

        #region Contrôle de saisie sur le téléphone des parents
        private void telParent_txt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(telParent_txt.Text))
            {
                // Set the error if the name is not valid.
                errProTelPar.SetError(this.telParent_txt, "Le numéro de téléphone des parents est requis et ne dois pas être vide !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProTelPar.SetError(this.telParent_txt, String.Empty);
            }
        }
        #endregion

        #region Contrôle de saisie sur le libellé de la classe
        private void lblClasse_cmbx_Validating(object sender, CancelEventArgs e)
        {
            if ((int)lblClasse_cmbx.SelectedValue == 0)
            {
                // Set the error if the name is not valid.
                errProClasse.SetError(this.lblClasse_cmbx, "Veuillez sélectionner une classe !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProClasse.SetError(this.lblClasse_cmbx, String.Empty);
            }
        }
        #endregion

        #region Contrôle de saisie sur le commentaire
        private void commentSante_text_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(commentSante_text.Text))
            {
                // Set the error if the name is not valid.
                errProCommentaire.SetError(this.commentSante_text, "Le commentaire est requis et ne dois pas être vide !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProCommentaire.SetError(this.commentSante_text, String.Empty);
            }
        }
        #endregion

        #region Contrôle de saisie sur le bouton sauvegarder
        private void saveBtn_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(nomEleve_txt.Text) || string.IsNullOrEmpty(prenomEleve_txt.Text) || (int)lblClasse_cmbx.SelectedValue == 0 || string.IsNullOrEmpty(commentSante_text.Text))
            {
                // Set the error if the name is not valid.
                errProSave.SetError(this.saveBtn, "Tous les champs ou certains champs du formulaire ne sont pas corrects ou sont vides !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProSave.SetError(this.saveBtn, String.Empty);
            }
        }
        #endregion
        #endregion
        #endregion

        public bool isLetter(string sReceive)
        {
            bool bResult;
            bResult = true;
            foreach (char cWork in sReceive)
            {
                if (char.IsLetter(cWork) == false)
                {
                    bResult = false;
                }
            }

            return bResult;
        }
    }
}
