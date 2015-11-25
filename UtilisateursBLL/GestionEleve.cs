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
        private static GestionEleve uneGestionEleve; // objet BLL

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

        #region Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        #endregion

        #region Méthode qui renvoit un objet Eleve en faisant appel à la méthode GetEleve() de la DAL
        public static Eleve GetUnEleve(int id)
        {
            return UtilisateurDAO.GetLEleve(id);
        }
        #endregion

        #region Méthode qui renvoit une List d'objets Eleve en faisant appel à la méthode GetEleve() de la DAL
        public static List<Eleve> GetEleves()
        {
            return UtilisateurDAO.GetEleves();
        }
        #endregion

        #region Méthode qui créer un nouvel objet Eleve à partir de son id et de son nom et qui le renvoi en l'ajoutant
        // à la BD avec la méthode AjoutEleve de la DAL
        public static int CreerEleve(string nom, string prenom, int day, int month, int year, int tel_eleve, int tel_parent,
            string tier_temps, string commentaire_sante, int id_classe)
        {
            Eleve elv;
            elv = new Eleve(nom, prenom, day, month, year, tel_eleve, tel_parent, tier_temps, commentaire_sante, id_classe);
            return UtilisateurDAO.AjoutEleve(elv);
        }
        #endregion

        #region Méthode qui modifie un nouvel Eleve avec la méthode UpdateEleve de la DAL
        public static int ModifierEleve(int id_eleves, string nom, string prenom, DateTime date_naissance, int tel_eleve, int tel_parent,
            string tier_temps, string commentaire_sante, int id_classe)
        {
            Eleve elv;
            elv = new Eleve(id_eleves, nom, prenom, date_naissance, tel_eleve, tel_parent, tier_temps, commentaire_sante, id_classe);
            return UtilisateurDAO.UpdateUtilisateur(elv);
        }
        #endregion

        #region Méthode qui supprime un Eleve avec la méthode DeleteEleve de la DAL
        public static int SupprimerEleve(int id)
        {
            return UtilisateurDAO.DeleteUtilisateur(id);
        }
        #endregion
    }
}