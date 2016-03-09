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
            bool tier_temps;
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
                tier_temps = false;

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
            cmd.CommandText = "UPDATE ELEVES SET nom = '" + unEleve.Nom + "' AND prenom = '" + unEleve.Prenom + "' AND date_naissance = '" + unEleve.Date_naissance + "' AND tel_Eleve = '" + unEleve.Tel_eleve + "' AND tel_Parent = '" + unEleve.Tel_parent + "' AND tier_temps = '" + unEleve.Tier_temps + "' AND commentaire_sante = '" + unEleve.Commentaire_sante + "' AND id_classe = '" + unEleve.Id_classe + "' WHERE Id_utilisateur = " + unEleve.Id_classe;

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
