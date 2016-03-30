using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using UtilisateursBO; // Référence la couche BO

namespace UtilisateursDAL
{
    public class MedicamentDAO
    {
        private static MedicamentDAO unMedicamentDAO;

        #region Accesseur en lecture, renvoi une instance
        public static MedicamentDAO GetunMedicamentDAO()
        {
            if (unMedicamentDAO == null)
            {
                unMedicamentDAO = new MedicamentDAO();
            }
            return unMedicamentDAO;
        }
        #endregion

        #region Méthode GetUnMedicament pour ne demander qu'un seul médicament
        public static Medicament GetUnMedicament(int id)
        {
            int idMdc;
            string lblMdc;
            bool archivageMdc;
            Medicament unMedic;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM MEDICAMENT WHERE ID = '" + id + "'";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            do
            {
                idMdc = int.Parse(monReader["id_medic"].ToString());

                if (monReader["libelle_medic"] == DBNull.Value)
                {
                    lblMdc = default(string);
                }
                else
                {
                    lblMdc = monReader["libelle_medic"].ToString();
                }

                archivageMdc = bool.Parse(monReader["archivage_medic"].ToString());

                unMedic = new Medicament(idMdc, lblMdc, archivageMdc);
            } while (int.Parse(monReader["id_medic"].ToString()) == id);
            // Fermeture de la connexion
            maConnexion.Close();

            return unMedic;
        }
        #endregion

        #region Méthode GetMedicaments retourne une List contenant les objets Medicament contenus dans la table Medicament
        public static List<Medicament> GetMedicaments()
        {
            #region Liste des attributs
            // Attributs permettant de créer un objet
            int idMdc;
            string lblMdc;
            bool archivageMdc;

            // Objet unMedic
            Medicament unMedic;

            // Création d'une liste vide d'objets Medicament
            List<Medicament> lesMedics = new List<Medicament>();
            #endregion

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            #region Création d'un objet cmd de type SqlCommand permettant d'utiliser la connexion à la BD et de transmettre une requête
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM MEDICAMENT";
            #endregion

            // Création de monReader afin de récupérer les données reçues de la BD
            SqlDataReader monReader = cmd.ExecuteReader();

            #region Remplissage de la liste
            while (monReader.Read())
            {
                idMdc = int.Parse(monReader["id_medic"].ToString());

                if (monReader["libelle_medic"] == DBNull.Value)
                {
                    lblMdc = default(string);
                }
                else
                {
                    lblMdc = monReader["libelle_medic"].ToString();
                }

                archivageMdc = bool.Parse(monReader["archivage_medic"].ToString());

                unMedic = new Medicament(idMdc, lblMdc, archivageMdc);
                lesMedics.Add(unMedic);
            }
            #endregion

            // Fermeture de la connexion
            maConnexion.Close();

            // Fonction retournant la liste créée contenant les médicaments
            return lesMedics;
        }
        #endregion

        #region Cette méthode insert un nouveau médicament passé en paramètre dans la BD
        public static int AjoutMedicament(Medicament unMedicament)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            #region Création d'un objet cmd de type SqlCommand permettant d'utiliser la connexion à la BD et de transmettre une requête
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO MEDICAMENT (libelle_medic, archivage_medic) values('" + unMedicament.LblMdc + "', '" + unMedicament.ArchivageMdc + "')";
            #endregion

            // Création de monReader afin de récupérer les données reçues de la BD
            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            // Fonction retournant le nombre d'enregistrement
            return nbEnr;
        }
        #endregion

        #region Cette méthode modifie un Médicament passé en paramètre dans la BD
        public static int UpdateMedicament(Medicament unMedicament)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE MEDICAMENT SET libelle_medic = '" + unMedicament.LblMdc + "' WHERE id_medic = " + unMedicament.IdMdc;

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }
        #endregion

        #region Cette méthode supprime de la BD un utilisateur dont l'id est passé en paramètre
        public static int DeleteMedicament(int idMdc)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT COUNT(*) FROM PRESCRIPTION WHERE id_medic = '" + idMdc + "'";

            nbEnr = (int)cmd.ExecuteScalar();

            if (nbEnr == 0)
            {
                cmd.CommandText = "DELETE FROM MEDICAMENT WHERE id_medic = '" + idMdc + "'";
                cmd.ExecuteNonQuery();
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }
        #endregion

        #region Méthode ArchiveMedicament
        public static int ArchiverMedicament(Medicament unMedicament)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE MEDICAMENT SET archivage_medic = 1 WHERE id_medic = " + unMedicament.IdMdc;

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }
        #endregion
    }
}
