using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using UtilisateursBO; // Référence la couche BO

namespace UtilisateursDAL
{
    public class VisiteDAO
    {
        private static VisiteDAO uneVisiteDAO;

        #region Accesseur en lecture, renvoi une instance
        public static VisiteDAO GetUneVisiteDAO()
        {
            if (uneVisiteDAO == null)
            {
                uneVisiteDAO = new VisiteDAO();
            }
            return uneVisiteDAO;
        }
        #endregion

        #region Méthode AjoutVisite insert une nouvelle visite passé en paramètre dans la BD
        public static int AjoutVisite(Visite uneVisite)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            #region Création d'un objet cmd de type SqlCommand permettant d'utiliser la connexion à la BD et de transmettre une requête
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO VISITE (motif_visite,commentaire_visite,pouls_eleve,parents_prevenus,retour_domicile,hopital,date_visite,heure_deb,heure_fin,id_eleves)values('" + uneVisite.MotifVst + "', '" + uneVisite.CommentVst + "', '" + uneVisite.Pouls + "', '" + uneVisite.TellParents + "', '" + uneVisite.BackHome + "', '" + uneVisite.GoHospital + "', '" + uneVisite.DateVisite + "', '" + uneVisite.HeureDebVst + "', '" + uneVisite.HeureFinVst + "', '" + uneVisite.IdElv + "')";
            #endregion

            // Création de monReader afin de récupérer les données reçues de la BD
            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            // Fonction retournant le nombre d'enregistrement
            return nbEnr;
        }
        #endregion
        public static int UpdateVisite(Visite uneVisite)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE VISITE SET id_visite = '" + uneVisite.IdVst + "', Date_Visite = '";

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }
    
    }
}
