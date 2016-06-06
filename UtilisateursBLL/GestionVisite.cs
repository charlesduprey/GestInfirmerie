using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using UtilisateursBO; // Référence la couche BO
using UtilisateursDAL; // Référence la couche DAL

namespace UtilisateursBLL
{
    public class GestionVisite
    {
        private static GestionVisite uneGestionVisite; // objet BLL

        #region Accesseur en lecture
        public static GestionVisite GetGestionVisite()
        {
            if (uneGestionVisite == null)
            {
                uneGestionVisite = new GestionVisite();
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

        public static int GetIdVstMax()
        {
            return VisiteDAO.GetIdVstMax();
        }

        #region Méthode CreerVisite qui créer un nouvel objet Visite à partir de son id et de son nom et qui le renvoi en l'ajoutant
        // à la BD avec la méthode AjoutEleve de la DAL
        public static int CreerVisite(Visite vst)
        {
            return VisiteDAO.AjoutVisite(vst);
        }
        #endregion
    }
}