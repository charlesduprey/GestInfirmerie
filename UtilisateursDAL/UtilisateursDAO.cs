using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using UtilisateursBO; // Référence la couche BO

namespace UtilisateursDAL
{
    public class UtilisateurDAO
    {
        private static UtilisateurDAO unUtilisateurDAO;

        //
        public static Eleve GetLEleve(int id)
        {
            int id_eleve;
            string nom;
            string prenom;
            DateTime date_naissance;
            int tel_eleve;
            int tel_parent;
            string tier_temps;
            string commentaire_sante;
            int id_classe;
            Eleve unEleve;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM ELEVES WHERE ID = '" + id + "'";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            do
            {
                id_eleve = int.Parse(monReader["id_eleves"].ToString());

                if (monReader["nom"] == DBNull.Value)
                {
                    nom = default(string);
                }
                else
                {
                    nom = monReader["nom"].ToString();
                }

                if (monReader["prenom"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["prenom"].ToString();
                }

                date_naissance = DateTime.Parse(monReader["date_naissance"].ToString());
                tel_eleve = int.Parse(monReader["tel_eleve"].ToString());
                tel_parent = int.Parse(monReader["tel_eleve"].ToString());

                if (monReader["tier_temps"] == DBNull.Value)
                {
                    tier_temps = default(string);
                }
                else
                {
                    tier_temps = monReader["commentaire_sante"].ToString();
                }

                if (monReader["commentaire_sante"] == DBNull.Value)
                {
                    commentaire_sante = default(string);
                }
                else
                {
                    commentaire_sante = monReader["commentaire_sante"].ToString();
                }

                id_classe = int.Parse(monReader["id_classe"].ToString());

                unEleve = new Eleve(id_eleve, nom, prenom, date_naissance, tel_eleve, tel_parent, tier_temps, commentaire_sante, id_classe);
            } while (int.Parse(monReader["id_eleves"].ToString()) == id);
            // Fermeture de la connexion
            maConnexion.Close();

            return unEleve;
        }

        // Accesseur en lecture, renvoi une instance
        public static UtilisateurDAO GetunUtilisateurDAO()
        {
            if (unUtilisateurDAO == null)
            {
                unUtilisateurDAO = new UtilisateurDAO();
            }
            return unUtilisateurDAO;
        }

        // Cette méthode retourne une List contenant les objets Utilisateurs contenus dans la table Identification
        public static List<Eleve> GetEleves()
        {
            int id_eleve;
            string nom;
            string prenom;
            DateTime date_naissance;
            int tel_eleve;
            int tel_parent;
            string tier_temps;
            string commentaire_sante;
            int id_classe;
            Eleve unEleve;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Eleve
            List<Eleve> lesEleves = new List<Eleve>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM ELEVES";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                id_eleve = int.Parse(monReader["id_eleves"].ToString());

                if (monReader["nom"] == DBNull.Value)
                {
                    nom = default(string);
                }
                else
                {
                    nom = monReader["nom"].ToString();
                }

                if (monReader["prenom"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["prenom"].ToString();
                }

                date_naissance = DateTime.Parse(monReader["date_naissance"].ToString());
                tel_eleve = int.Parse(monReader["tel_eleve"].ToString());
                tel_parent = int.Parse(monReader["tel_eleve"].ToString());
                
                if (monReader["tier_temps"] == DBNull.Value)
                {
                    tier_temps = default(string);
                }
                else
                {
                    tier_temps = monReader["tier_temps"].ToString();
                }

                if (monReader["commentaire_sante"] == DBNull.Value)
                {
                    commentaire_sante = default(string);
                }
                else
                {
                    commentaire_sante = monReader["commentaire_sante"].ToString();
                }

                id_classe = int.Parse(monReader["id_classe"].ToString());

                unEleve = new Eleve(id_eleve, nom, prenom, date_naissance, tel_eleve, tel_parent, tier_temps, commentaire_sante, id_classe);
                lesEleves.Add(unEleve);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesEleves;
        }

        // Cette méthode insert un nouvel utilisateur passé en paramètre dans la BD
        public static int AjoutEleve(Eleve unEleve)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO ELEVES values('" + unEleve.Nom + ", " + unEleve.Prenom + ", " + unEleve.Date_naissance + ", " + unEleve.Tel_eleve + ", " + unEleve.Tel_parent + ", " + unEleve.Tier_temps + ", " + unEleve.Commentaire_sante + ", " + unEleve.Id_classe + "')";

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }

        // Cette méthode modifie un utilisateur passé en paramètre dans la BD
        public static int UpdateUtilisateur(Eleve unEleve)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE ELEVES SET nom = '" + unEleve.Nom + "', prenom = '" + unEleve.Prenom + "', date_naissance = '" + unEleve.Date_naissance + "', tel_Eleve = '" + unEleve.Tel_eleve + "', tel_Parent = '" + unEleve.Tel_parent + "', tier_temps = '" + unEleve.Tier_temps + "', commentaire_sante = '" + unEleve.Commentaire_sante + "', id_classe = '" + unEleve.Id_classe + "' WHERE id_eleves = " + unEleve.Id_classe;

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }

        // Cette méthode supprime de la BD un utilisateur dont l'id est passé en paramètre
        public static int DeleteUtilisateur(int id)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM ELEVES WHERE id_eleves = " + id;

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }
    }
}