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

namespace UtilisateursGUI.GestionMdc
{
    public partial class FrmModifMdc : Form
    {
        #region Gestion du formulaire
        #region Initialisation du formulaire
        public FrmModifMdc()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            UtilisateursBLL.GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Eleve"]);

            // Création d'un objet List de médicaments à afficher dans la liste
            listeMedicaments = GestionMedicament.GetMedicaments();

            libelleMdcCmbx.DataSource = listeMedicaments;
            libelleMdcCmbx.DisplayMember = "LblMdc";
            libelleMdcCmbx.ValueMember = "IdMdc";

            int id = (int)libelleMdcCmbx.SelectedValue;
        }
        #endregion

        #region Attributs de l'application
        private List<Medicament> listeMedicaments;
        int id;
        #endregion

        #region Boutons du formulaire
        #region Bouton sauvegarder
        private void saveBtn_Click(object sender, EventArgs e)
        {
            #region Si les champs de la visite sont vides
            if (string.IsNullOrEmpty(libelleMdcCmbx.Text))
            {
                #region Affichage du MessageBox.
                MessageBox.Show(
                    this,
                    "Certains champs du formulaire sont vides ou incorrects ! Remplissez-les pour continuer.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                #endregion
            }
            #endregion
            #region Si tout va bien
            else
            {
                GestionMedicament.ModifierMedicament(new Medicament(id, libelleMdcCmbx.Text));

                #region Affichage du MessageBox.
                DialogResult result = MessageBox.Show(
                   this,
                   "Médicament modifié. Souhaitez-vous en modifier un autre ?",
                   "Modifier un médicament",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1);
                #endregion

                #region Actions en fonction du message de validation
                if (result == DialogResult.No)
                {
                    this.Close();
                }
                #endregion
            }
            #endregion
        }
        #endregion

        #region Bouton archiver
        private void archBtn_Click(object sender, EventArgs e)
        {
            // Appel de la méthode SupprimerMedicament() de la GestionMedicament
            GestionMedicament.ArchiveMedicament(new Medicament((int)libelleMdcCmbx.SelectedValue, libelleMdcCmbx.Text, false));

            // Afficher le MessageBox.
            MessageBox.Show(
                this,
                "Le médicament a bien été archivé.",
                "Valider",
                MessageBoxButtons.OK,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
        }
        #endregion

        #region Bouton supprimer
        private void suprBtn_Click(object sender, EventArgs e)
        {
            // Appel de la méthode SupprimerMedicament() de la GestionMedicament
            int nbEnr = GestionMedicament.SupprimerMedicament((int)libelleMdcCmbx.SelectedValue);

            #region Message s'il existe des médicaments prescrits
            if (nbEnr > 0)
            {
                MessageBox.Show("L'élément a été prescrit, il ne peut pas être suprimé mais archivé !",
                    "Message",
                    MessageBoxButtons.OK);
            }
            else
            {
                // Initializes the variables to pass to the MessageBox.Show method.
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(
                    this,
                    "Medicament supprimé. Souhaitez-vous en supprimer: un autre ?",
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

        #region Action en fonction du combobox
        private void libelleMdcCmbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id = (int)libelleMdcCmbx.SelectedValue;
        }
        #endregion

        #region Contrôles de saisies
        #region Contrôle de saisie sur le libellé du médicament
        private void libelleMdcCmbx_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(libelleMdcCmbx.Text))
            {
                // Set the error if the name is not valid.
                errProMdcTxt.SetError(this.libelleMdcCmbx, "Le libellé du médicament est requis et ne dois pas être vide !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProMdcTxt.SetError(this.libelleMdcCmbx, String.Empty);
            }
        }
        #endregion

        #region Contrôle de saisie sur l'enregistrement du médicament
        private void saveBtn_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(libelleMdcCmbx.Text))
            {
                // Set the error if the name is not valid.
                errProMdcTxt.SetError(this.libelleMdcCmbx, "Le libellé du médicament est requis et ne dois pas être vide !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProMdcTxt.SetError(this.libelleMdcCmbx, String.Empty);
            }
        }
        #endregion
        #endregion   
    }
}
