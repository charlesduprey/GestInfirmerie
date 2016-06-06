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

		#region Méthode GetNbVstMoy récupère la moyenne des visites
        public static string GetNbVstMoy(string dateDeb, string dateFin)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            float nbEnr = 0;
            float nbEleves = 0;
            //création de la requête
            #region Création d'un objet cmd de type SqlCommand permettant d'utiliser la connexion à la BD et de transmettre une requête
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT COUNT(*) FROM VISITE WHERE date_visite BETWEEN '" + dateDeb + "' AND '" + dateFin + "';";
            #endregion
            // Fonction recupère le nombre de visite max selon la periode
            nbEnr = (int)cmd.ExecuteScalar();


            #region Création d'un objet cmd de type SqlCommand permettant d'utiliser la connexion à la BD et de transmettre une requête
            SqlCommand cmdElv = new SqlCommand();
            cmdElv.Connection = maConnexion;
            cmdElv.CommandText = "SELECT COUNT(*) FROM ELEVES WHERE archiver ='0';";
            #endregion
            // Fonction recupère le nombre de visite max selon la periode
            nbEleves = (int)cmdElv.ExecuteScalar();
            // Fermeture de la connexion
            maConnexion.Close();
            //retour du résultat
            return (nbEnr / nbEleves + " visites par élève");
        }
        #endregion

        #region Méthode GetNbVstMaxP recupère le nombre de visite total selon la periode
        public static float GetTpsMoyVst(DateTime dateDeb, DateTime dateFin)
        {
            //On initialise la valeur tMoyVisite

            float tMoyVisite = 0.00F;

            float tTotalVisite = 0;

            List<Visite> lesVisites = new List<Visite>();
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "Select DATEDIFF(mi, heure_deb, heure_fin) AS tTotalVisite FROM Visite Where date_visite BETWEEN'" + dateDeb + "'AND '" + dateFin + "';";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                if (monReader.HasRows)
                {
                    tTotalVisite = tTotalVisite + Int32.Parse(monReader["tTotalVisite"].ToString());
                }
            }
            // Fermeture de la connexion
            maConnexion.Close();
            if (GetNbTotVisite(dateDeb, dateFin) == 0)
            {
                tMoyVisite = 0;
            }
            else
            {

                tMoyVisite = tTotalVisite / GetNbTotVisite(dateDeb, dateFin);
            }
            return tMoyVisite;
        }
        #endregion
    }
}
