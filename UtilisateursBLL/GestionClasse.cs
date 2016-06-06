using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using UtilisateursBO; // Référence la couche BO
using UtilisateursDAL; // Référence la couche DAL

namespace UtilisateursBLL
{
    public class GestionClasse
    {
        private static GestionClasse uneGestionClasse; // Objet BLL

        #region Accesseur en lecture
        public static GestionClasse GetGestionEleve()
        {
            if (uneGestionClasse == null)
            {
                uneGestionClasse = new GestionClasse();
            }
            return uneGestionClasse;
        }
        #endregion

        #region Méthode SetChaineConnexion définissant la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        #endregion

        #region Méthode GetUneClasse renvoyant un objet Classe en faisant appel à la méthode GetEleve de la DAL
        public static Classe GetUneClasse(int id)
        {
            return ClasseDAO.GetLaClasse(id);
        }
        #endregion

        #region Méthode GetClasses renvoyant une liste d'objets Classe à partir de la méthode GetClasses de la DAL
        public static List<Classe> GetClasses()
        {
            return ClasseDAO.GetClasses();
        }
        #endregion

        #region Méthode qui créer un nouvel objet Medicament à partir de son id et de son nom et qui le renvoi en l'ajoutant
        // à la BD avec la méthode AjoutEleve de la DAL
        public static int CreerClasse(Classe cls)
        {
            return ClasseDAO.AjoutClasse(cls);
        }
        #endregion

        #region Méthode qui modifie un Medicament avec la méthode UpdateMedicament de la DAL
        public static int ModifierClasse(Classe cls)
        {
            return ClasseDAO.UpdateClasse(cls);
        }
        #endregion

        #region Méthode qui supprime un Medicament avec la méthode SupprimerMedicament de la DAL
        public static int SupprimerClasse(int idClasse)
        {
            return ClasseDAO.DeleteClasse(idClasse);
        }
        #endregion

        #region Méthode TrouverClasse retrouve si un élève est affecté à au moins une visite TrouverEleve de la DAL
        public static bool TrouverClasse(int id)
        {
            return ClasseDAO.TrouverClasse(id);
        }
        #endregion

        #region Méthode GetNbClasses
        public static int GetNbClasses()
        {
            return ClasseDAO.GetNombreClasses();
        }
        #endregion
    }
}
