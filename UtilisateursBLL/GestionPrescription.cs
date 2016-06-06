using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using UtilisateursBO; // Référence la couche BO
using UtilisateursDAL; // Référence la couche DAL

namespace UtilisateursBLL
{
    public class GestionPrescription
    {
        private static GestionPrescription uneGestionVisite; // objet BLL

        #region Accesseur en lecture
        public static GestionPrescription GetGestionVisite()
        {
            if (uneGestionVisite == null)
            {
                uneGestionVisite = new GestionPrescription();
            }
            return uneGestionVisite;
        }
        #endregion

        #region Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        #endregion

        #region Méthode CreerPrescription qui créer un nouvel objet Visite à partir de son id et de son nom et qui le renvoi en l'ajoutant
        // à la BD avec la méthode AjoutEleve de la DAL
        public static int CreerPrescription(Prescription prescription)
        {
            return PrescriptionDAO.AjoutPrescription(prescription);
        }
        #endregion
    }
}
