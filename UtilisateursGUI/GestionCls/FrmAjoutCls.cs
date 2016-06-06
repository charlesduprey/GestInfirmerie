using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilisateursBO;
using UtilisateursBLL;
using System.Configuration;

namespace UtilisateursGUI.GestionCls
{
    public partial class FrmAjoutCls : Form
    {
        public FrmAjoutCls()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            UtilisateursBLL.GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Eleve"]);
        }

        private void enrBtn_Click(object sender, EventArgs e)
        {

        }

        private void enrBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(libelle_classe.Text) || string.IsNullOrEmpty(niveau_classe.Text) || string.IsNullOrEmpty(emploi_du_temps.Text))
            {
                #region Affichage du MessageBox.
                MessageBox.Show(
                    this,
                    "Le libellé de la classe est vide ou est incorrect ! Remplissez-le pour continuer.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                #endregion
            }
            else
            {
                string libelleClasse = (libelle_classe.Text);
                string niveauClasse = (niveau_classe.Text);
                string emploiDuTemps = (emploi_du_temps.Text);

                Classe cls;
                cls = new Classe(libelleClasse, niveauClasse, emploiDuTemps);

                GestionClasse.CreerClasse(cls);

                #region Affichage du MessageBox.
                MessageBox.Show(
                    this,
                    "La classe a bien été enregistré !",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                #endregion
            }
        }
    }
}
