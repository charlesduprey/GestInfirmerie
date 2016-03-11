using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using UtilisateursBO; // Référence la couche BO

namespace UtilisateursDAL
{
    public class PrescriptionDAO
    {
        private static PrescriptionDAO unePrescriptionDAO;

        #region Accesseur en lecture, renvoi une instance
        public static PrescriptionDAO GetUnePrescriptionDAO()
        {
            if (unePrescriptionDAO == null)
            {
                unePrescriptionDAO = new PrescriptionDAO();
            }
            return unePrescriptionDAO;
        }
        #endregion

        #region Méthode AjoutPrescription insert une nouvelle precription passé en paramètre dans la BD
        public static int AjoutPrescription(Prescription unePrescription)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            #region Création d'un objet cmd de type SqlCommand permettant d'utiliser la connexion à la BD et de transmettre une requête
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO PRESCRIPTION values('" + unePrescription.IdVisite + "', '" + unePrescription.IdMedic + "', '" + unePrescription.NbPrescri + "')";
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
