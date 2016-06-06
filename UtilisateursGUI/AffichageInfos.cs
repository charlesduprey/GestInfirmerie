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
    public partial class AffichageInfos : Form
    {
        #region Gestion du formulaire
        #region Initialisation du formulaire
        public AffichageInfos()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            UtilisateursBLL.GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Eleve"]);

            // Initialisation du nombre d'élèves sur la période sélectionnée
            nbrEleves.Text = GestionEleve.GetNbrEleves().ToString() + " élèves";

            // Initialisation de la valeur du total des médicaments sur la période sélectionnée
            medicTotAnScoValue.Text = GestionMedicament.GetNbMedicamentsAnnees(dateDebut.Value, dateFin.Value).ToString() + " médicaments";

            // Initialisation de la valeur moyenne des médicaments sur la période sélectionnée
            nbrMoyMedic.Text = GestionMedicament.GetMoyMedicamentsAnnees().ToString() + " médicaments";
        }
        #endregion

        #region Actions en fonction du changement des dates
        private void dateDebut_ValueChanged(object sender, EventArgs e)
        {
            // Initialisation du nombre d'élèves sur la période sélectionnée
            nbrEleves.Text = GestionEleve.GetNbrEleves().ToString() + " élèves";

            // Initialisation de la valeur du total des médicaments sur l'années
            medicTotAnScoValue.Text = GestionMedicament.GetNbMedicamentsAnnees(dateDebut.Value, dateFin.Value).ToString() + " médicaments";

            // Initialisation de la valeur moyenne des médicaments sur la période sélectionnée
            nbrMoyMedic.Text = GestionMedicament.GetMoyMedicamentsAnnees().ToString() + " médicaments";
        }
        #endregion

        #region Boutons du formulaire
        #region Bouton aujourd'hui
        private void today_Click(object sender, EventArgs e)
        {
            dateDebut.Value = dateFin.Value = DateTime.Today;

            #region Affichage du MessageBox.
            MessageBox.Show(
                this,
                "Aujourd'hui : " + dateDebut.Value,
                "Erreur",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            #endregion
        }
        #endregion

        #region Bouton fermer
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion

        #region Contrôles de saisies
        #region Contrôle de saisie sur la date de début
        private void dateDebut_Validating(object sender, CancelEventArgs e)
        {
            if (dateDebut.Value > dateFin.Value)
            {
                // Set the error if the name is not valid.
                errProDateDeb.SetError(this.dateDebut, "La date de début ne peut être supérieure à la date de fin !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProDateDeb.SetError(this.dateDebut, String.Empty);
            }
        }
        #endregion

        #region Contrôle de saisie sur la date de Fin
        private void dateFin_Validating(object sender, CancelEventArgs e)
        {
            if (dateDebut.Value > dateFin.Value)
            {
                // Set the error if the name is not valid.
                errProDateDeb.SetError(this.dateDebut, "La date de Fin ne peut être inférieur à la date de début !");
            }
            else
            {
                // Clear the error, if any, in the error provider.
                errProDateDeb.SetError(this.dateDebut, String.Empty);
            }
        }
        #endregion
        #endregion
        #endregion
    }
}
