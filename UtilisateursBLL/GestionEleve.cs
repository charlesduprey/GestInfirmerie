using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using UtilisateursBO; // Référence la couche BO
using UtilisateursDAL; // Référence la couche DAL

namespace UtilisateursBLL
{
    public class GestionEleve
    {
        private static GestionEleve uneGestionEleve; // Objet BLL

        #region Accesseur en lecture
        public static GestionEleve GetGestionEleve()
        {
            if (uneGestionEleve == null)
            {
                uneGestionEleve = new GestionEleve();
            }
            return uneGestionEleve;
        }
        #endregion

        #region Méthode SetChaineConnexion définissant la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        #endregion

        #region Méthode GetUnEleve renvoyant un objet Eleve en faisant appel à la méthode GetEleve de la DAL
        public static Eleve GetUnEleve(int id)
        {
            return UtilisateurDAO.GetLEleve(id);
        }
        #endregion

        #region Méthode GetEleves renvoyant une liste d'objets Eleve à partir de la méthode GetEleve de la DAL
        public static List<Eleve> GetEleves()
        {
            return UtilisateurDAO.GetEleves();
        }
        #endregion

        #region Méthode AjoutEleve créant un nouvel objet Eleve à partir de son id et de son nom et qui le renvoi en l'ajoutant
        // à la BD avec la méthode AjoutEleve de la DAL
        public static int AjoutEleve(Eleve elv)
        {
            return UtilisateurDAO.AjoutEleve(elv);
        }
        #endregion

        #region Méthode ModifierEleve modifiant un Eleve avec la méthode UpdateEleve de la DAL
        public static int ModifierEleve(Eleve elv)
        {
            return UtilisateurDAO.UpdateEleve(elv);
        }
        #endregion

        #region Méthode SupprimerEleve supprimant un Eleve avec la méthode DeleteEleve de la DAL
        public static int SupprimerEleve(int id)
        {
            return UtilisateurDAO.DeleteEleve(id);
        }
        #endregion

        #region Méthode ArchiveEleve archivant un Eleve avec la méthode ArchiverEleve de la DAL
        public static int ArchiveEleve(int id)
        {
            return UtilisateurDAO.ArchiverEleve(id);
        }
        #endregion

        #region Méthode GetLeNomDeClasse renvoyant le nom et la section de la classe avec la méthode GetNomClasse de la DAL
        public static string GetLeNomDeClasse(int idClasse)
        {
            return UtilisateurDAO.GetNomClasse(idClasse);
        }
        #endregion
    }
}