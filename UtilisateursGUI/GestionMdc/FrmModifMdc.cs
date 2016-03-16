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
        public FrmModifMdc()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            UtilisateursBLL.GestionMedicament.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Medicament"]);


            listeMedicaments = GestionMedicament.GetMedicaments();

            nommedic.DataSource = listeMedicaments;
            nommedic.DisplayMember = "Nom";
            nommedic.ValueMember = "Id_Medic";

            numSelectionne = (int)nommedic.SelectedIndex;

            if (listeMedicaments[numSelectionne].ArchivageMdc == false)
            {
                libellemedic.Text = listeMedicaments[numSelectionne].LblMdc;
            }
        }

        private int numSelectionne;
        private List<Medicament> listeMedicaments;

        private void savemodif_Click(object sender, EventArgs e)
        {
            #region Création de la liste pour récupérer les élèves
            List<Medicament> liste = new List<Medicament>();
            liste = GestionMedicament.GetMedicaments();
            #endregion



            //Medicament unMedicament = new Medicament(libellemedic.Text);

            //GestionMedicament.ModifierMedicament(unMedicament);

            //MessageBox.Show("idElv = " + idElv.ToString() + ", nom eleve = " + nomElv_cmbx.Text + ", prenom = " + prenomEleve_txt.Text + ", date naissance : " + laDateNaissance + ", tel eleve =" + leTelEleve + ", tel Parent " + leTelParent + ", Tiers temps = " + tierTemps_txt.Text + ", Commentaire santé = " + commentSante_text.Text + ", index Classe =  " + lblClasse_cmbx.SelectedIndex.ToString() + "");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        
    }
}
