using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using UtilisateursBO; // Référence la couche BO
using UtilisateursDAL; // Référence la couche DAL

namespace UtilisateursBLL
{
    public class GestionMedicament
    {
        private static GestionMedicament uneGestionMedicament; // objet BLL

        #region Accesseur en lecture
        public static GestionMedicament GetGestionMedicament()
        {
            if (uneGestionMedicament == null)
            {
                uneGestionMedicament = new GestionMedicament();
            }
            return uneGestionMedicament;
        }
        #endregion

        #region Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        #endregion

        #region Méthode qui renvoit un objet Medicament en faisant appel à la méthode GetMedicament() de la DAL
        public static Medicament GetUnMedicament(int id)
        {
            return MedicamentDAO.GetUnMedicament(id);
        }
        #endregion

        #region Méthode qui renvoit une List d'objets Medicament en faisant appel à la méthode GetMedicaments() de la DAL
        public static List<Medicament> GetMedicaments()
        {
            return MedicamentDAO.GetMedicaments();
        }
        #endregion

        #region Méthode qui créer un nouvel objet Medicament à partir de son id et de son nom et qui le renvoi en l'ajoutant
        // à la BD avec la méthode AjoutEleve de la DAL
        public static int CreerMedicament(Medicament mdc)
        {
            return MedicamentDAO.AjoutMedicament(mdc);
        }
        #endregion

        #region Méthode qui modifie un Medicament avec la méthode UpdateMedicament de la DAL
        public static int ModifierMedicament(Medicament mdc)
        {
            return MedicamentDAO.UpdateMedicament(mdc);
        }
        #endregion

        #region Méthode qui supprime un Medicament avec la méthode SupprimerMedicament de la DAL
        public static int SupprimerMedicament(int idMdc)
        {
            return MedicamentDAO.DeleteMedicament(idMdc);
        }
        #endregion

        #region Méthode qui archive un Médicament avec la méthode ArchiverEleve de la DAL
        public static int ArchiveMedicament(Medicament unMedicament)
        {
            return MedicamentDAO.ArchiverMedicament(unMedicament);
        }
        #endregion
    }
}
