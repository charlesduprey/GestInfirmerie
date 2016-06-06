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

namespace UtilisateursGUI.GestionCls
{
    public partial class FrmModifCls : Form
    {
        public FrmModifCls()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Eleve"]);

            #region Initialisation des listes
            // Création d'un objet List de classes à afficher dans la liste
            listeClasses = GestionClasse.GetClasses();
            #endregion

            id_classe.DataSource = listeClasses;
            id_classe.DisplayMember = "IdClasse";
            id_classe.ValueMember = "IdClasse";
            
            #region Remplissage des cases
            libelle_classe.Text = listeClasses[0].LibelleClasse;
            niveau_classe.Text = listeClasses[0].NiveauClasse;
            emploi_du_temps.Text = listeClasses[0].EmploiDuTemps;
            #endregion
        }
            
        #region Attributs de l'application
            private int numSelectionne;
            private List<Classe> listeLibelleClasse = new List<Classe>();
            private List<Classe> listeClasses;
            #endregion

        private void enrBtn_Click(object sender, EventArgs e)
        {
            if ((int)id_classe.SelectedValue == 0 || string.IsNullOrEmpty(libelle_classe.Text) || string.IsNullOrEmpty(niveau_classe.Text) || string.IsNullOrEmpty(emploi_du_temps.Text))
            {
                #region Affichage du MessageBox.
                MessageBox.Show(
                    this,
                    "Le formulaire est vide ! Remplissez-le si nécessaire",
                    "Valider",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                #endregion
            }
            else
            {               
                #region Rassemblement et modification des infos de l'élève
                // Rassemblement des infos de l'élève
                // int id_eleve = (int)nomElv_cmbx.SelectedValue;
                Classe uneClasse = new Classe(
                    listeClasses[id_classe.SelectedIndex].IdClasse,
                    libelle_classe.Text,
                    niveau_classe.Text,
                    emploi_du_temps.Text);

                // Modification de l'élève
                GestionClasse.ModifierClasse(uneClasse);
                #endregion

                #region Affichage du MessageBox.
                MessageBox.Show(
                    this,
                    "La classe numéro " + numSelectionne + " a bien été modifiée ",
                    "Archivage",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                #endregion
            }
        }

        private void suprBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(libelle_classe.Text) || string.IsNullOrEmpty(niveau_classe.Text) || string.IsNullOrEmpty(emploi_du_temps.Text))
            {
                #region Affichage du MessageBox.
                MessageBox.Show(
                    this,
                    "Certains champs du formulaire sont vides ! Remplissez-les pour continuer.",
                    "Valider",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                #endregion
            }
            else
            {
                int id = int.Parse(id_classe.SelectedValue.ToString());

                #region Affichage du MessageBox.
                DialogResult result = MessageBox.Show(
                    this,
                    "Voulez-vous supprimer la classe " + id + " ?",
                    "Suppression",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                #endregion

                // Contrôle de la possibilité de suppression (afilié à aucune visite)
                bool trouve = GestionClasse.TrouverClasse(id);

                if (trouve == true)
                {
                    trouve = true;
                    MessageBox.Show(
                        "Impossible de supprimer l'élève " + id + " Vous pouvez cependant l'achiver.",
                        "Suppression",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                else
                {
                    GestionClasse.SupprimerClasse(id);
                }
                // supression si oui
            }
        }

        private void id_classe_SelectedValueChanged(object sender, EventArgs e)
        {
            libelle_classe.Text = listeClasses[id_classe.SelectedIndex].LibelleClasse;
            niveau_classe.Text = listeClasses[id_classe.SelectedIndex].NiveauClasse;
            emploi_du_temps.Text = listeClasses[id_classe.SelectedIndex].EmploiDuTemps;
        }
    }
}
