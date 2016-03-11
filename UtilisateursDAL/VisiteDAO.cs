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

        /*
        #region Méthode GetEleves retournant une List d'objets Eleves contenus dans la table ELEVES
        public static List<Visite> GetVisites()
        {
            #region Liste des attributs nécessaires pour récupérer et retourner le résultat attendu
            int idVisite;
            string motifVisite;
            string commentVisite;
            int pouls;
            bool parentPrevenus;
            bool retourDomicile;
            bool hopital;
            DateTime dateVisite;
            DateTime heureArr;
            DateTime heureDep;
            int idEleve;
            Visite uneVisite;
            #endregion

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Eleve
            List<Visite> lesVisites = new List<Visite>();

            #region Création d'une commande SQL pour supprimer un élève à partir de son id
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM VISITE";
            #endregion

            // Récupération du résultat dans une variable
            SqlDataReader monReader = cmd.ExecuteReader();

            #region Remplissage de la liste à partir du reader
            while (monReader.Read())
            {
                idVisite = int.Parse(monReader["id_visite"].ToString());

                if (monReader["motif_visite"] == DBNull.Value)
                {
                    motifVisite = default(string);
                }
                else
                {
                    motifVisite = monReader["motif_visite"].ToString();
                }

                if (monReader["commentaire_visite"] == DBNull.Value)
                {
                    commentVisite = default(string);
                }
                else
                {
                    commentVisite = monReader["commentaire_visite"].ToString();
                }

                pouls = int.Parse(monReader["pouls_eleve"].ToString());

                parentPrevenus = bool.Parse(monReader["parents_prevenus"].ToString());
                retourDomicile = bool.Parse(monReader["retour_domicile"].ToString());
                hopital = bool.Parse(monReader["hopital"].ToString());

                dateVisite = DateTime.Parse(monReader["date_visite"].ToString());
                heureArr = DateTime.Parse(monReader["heure_deb"].ToString());
                heureDep = DateTime.Parse(monReader["heure_fin"].ToString());

                idEleve = int.Parse(monReader["id_eleves"].ToString());

                uneVisite = new Eleve(idVisite, motifVisite, commentVisite, pouls,  id_eleve);
                lesEleves.Add(unEleve);
            }
            #endregion

            // Fermeture de la connexion
            maConnexion.Close();

            // Résultat retourné
            return lesVisites;
        }
        #endregion
        */

        #region Méthode AjoutPrescription insert une nouvelle precription passé en paramètre dans la BD
        public static int GetIdVstMax()
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            #region Création d'un objet cmd de type SqlCommand permettant d'utiliser la connexion à la BD et de transmettre une requête
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT IDENT_CURRENT ('VISITE') AS Current_Identity;";
            #endregion

            // Création de monReader afin de récupérer les données reçues de la BD
            //int? nbEnr = cmd.ExecuteScalar() as int?;
            int nbEnr = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            // Fermeture de la connexion
            maConnexion.Close();

            // Fonction retournant le nombre d'enregistrement
            return nbEnr;
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
            cmd.CommandText = "INSERT INTO VISITE values('" + uneVisite.MotifVst + "', '" + uneVisite.CommentVst + "', '" + uneVisite.Pouls + "', '" + uneVisite.TellParents + "', '" + uneVisite.BackHome + "', '" + uneVisite.GoHospital + "', '" + uneVisite.DateVisite + "', '" + uneVisite.HeureDebVst + "', '" + uneVisite.HeureFinVst + "', '" + uneVisite.IdElv + "')";
            #endregion

            // Création de monReader afin de récupérer les données reçues de la BD
            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            // Fonction retournant le nombre d'enregistrement
            return nbEnr;
        }
        #endregion


    }
}
