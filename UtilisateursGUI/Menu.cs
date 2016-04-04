using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilisateursGUI;
using UtilisateursGUI.GestionMdc;
using UtilisateursGUI.GestionElv;
using UtilisateursGUI.GestionVst;
using CSV_import_export;

namespace UtilisateursGUI
{
    public partial class Menu : Form
    {
        #region Gestion de l'application
        #region Initialisation du menu
        public Menu()
        {
            InitializeComponent();
        }
        #endregion

        #region Bouton Fermer
        private void fmrButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion

        #region Module Gestion des élèves
        #region Bouton pour appeller l'ajout d'un élève
        private void ajoutElvBtn_Click(object sender, EventArgs e)
        {
            FrmAjoutElv FrmModLect;
            FrmModLect = new FrmAjoutElv();
            FrmModLect.ShowDialog(); // ouverture du formulaire
            //FrmModLect.Close(); // fermeture du formulaire
        }
        #endregion

        #region Bouton pour appeller la modification d'un élève
        private void modifElvBtn_Click(object sender, EventArgs e)
        {
            FrmModifElv FrmModLect;
            FrmModLect = new FrmModifElv();
            FrmModLect.ShowDialog(); // ouverture du formulaire
            FrmModLect.Close(); // fermeture du formulaire
        }
        #endregion

        #region Bouton pour appeller la suppression d'un élève
        private void suprElvBtn_Click(object sender, EventArgs e)
        {
            FrmModifElv FrmModLect;
            FrmModLect = new FrmModifElv();
            FrmModLect.ShowDialog(); // ouverture du formulaire
            FrmModLect.Close(); // fermeture du formulaire
        }
        #endregion

        #region Bouton pour appeler l'étudient d'Hagrid View
        private void appelMdlLectureGestElv_Click(object sender, EventArgs e)
        {
            FrmModuleLectureElv FrmModLect = new FrmModuleLectureElv();
            FrmModLect.ShowDialog(); // ouverture du formulaire
            FrmModLect.Close(); // fermeture du formulaire
        }
        #endregion
        #endregion

        #region Module Gestion des médicaments
        #region Bouton pour appeller l'ajout des médicaments
        private void ajoutMdcBtn_Click(object sender, EventArgs e)
        {
            FrmAjoutMdc frmAjout = new FrmAjoutMdc();
            frmAjout.ShowDialog(); // ouverture du formulaire
            frmAjout.Close(); // fermeture du formulaire
        }
        #endregion

        #region Bouton pour appeller la modification des médicaments
        private void modifMdcBtn_Click(object sender, EventArgs e)
        {
            FrmModifMdc frmModif = new FrmModifMdc();
            frmModif.ShowDialog(); // ouverture du formulaire
            frmModif.Close(); // fermeture du formulaire
        }
        #endregion

        #region Bouton pour appeler la vue sur les médicaments
        private void appelMdlLectureGestMdc_Click(object sender, EventArgs e)
        {
            FrmModuleLectureMdc FrmModLect = new FrmModuleLectureMdc();
            FrmModLect.ShowDialog(); // ouverture du formulaire
            FrmModLect.Close(); // fermeture du formulaire
        }
        #endregion
        #endregion

        #region Module Gestion des visites
        #region Bouton pour appeller l'ajout des visites
        private void ajoutVstBtn_Click(object sender, EventArgs e)
        {
            FrmAjoutVst frmAjout = new FrmAjoutVst();
            frmAjout.ShowDialog(); // ouverture du formulaire
            frmAjout.Close(); // fermeture du formulaire
        }
        #endregion

        #region Bouton pour appeller la modification des visites
        private void modifVstBtn_Click(object sender, EventArgs e)
        {
            FrmModifVst frmModif = new FrmModifVst();
            frmModif.ShowDialog(); // ouverture du formulaire
            frmModif.Close(); // fermeture du formulaire
        }
        #endregion

        #region Bouton pour appeller la suppression des visites
        private void suprVstBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Bouton pour appeler la vue sur les visites
        private void appelMdlLectureGestVst_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #endregion

        //accès à l'administration
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            {
                MenuAdmin menuAdm = new MenuAdmin();
                menuAdm.ShowDialog(); // ouverture du formulaire
                menuAdm.Close(); // fermeture du formulaire
            }
        }
    }
}