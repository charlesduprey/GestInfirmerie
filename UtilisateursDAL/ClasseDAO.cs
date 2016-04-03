using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using UtilisateursBO; // Référence la couche BO

namespace UtilisateursDAL
{
    public class ClasseDAO
    {
        private static ClasseDAO uneClasseDAO; // Objet DAL

        #region Accesseur en lecture, renvoi une instance
        public static ClasseDAO GetunUtilisateurDAO()
        {
            if (uneClasseDAO == null)
            {
                uneClasseDAO = new ClasseDAO();
            }
            return uneClasseDAO;
        }
        #endregion

        #region Méthode GetLaClasse retournant une classe
        public static Classe GetLaClasse(int id)
        {
            #region Liste des attributs nécessaires pour récupérer et retourner le résultat attendu
            int idClasse;
            string libelleClasse;
            string niveauClasse;
            string emploiDuTemps;
            #endregion

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            #region Création d'une commande SQL pour sélectionner une classe à partir de son id
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM CLASSE WHERE id_classe = '" + id + "'";
            #endregion

            // Récupération du résultat dans une variable
            SqlDataReader monReader = cmd.ExecuteReader();

            int ind = 0;

            #region Remplissage de la liste à partir du reader
            while (monReader.Read())
            {
                if (int.Parse(monReader["id_classe"].ToString()) == id)
                {
                    idClasse = int.Parse(monReader["id_classe"].ToString());

                    if (monReader["libelle_classe"] == DBNull.Value)
                    {
                        libelleClasse = default(string);
                    }
                    else
                    {
                        libelleClasse = monReader["libelle_classe"].ToString();
                    }

                    if (monReader["niveau_classe"] == DBNull.Value)
                    {
                        niveauClasse = default(string);
                    }
                    else
                    {
                        niveauClasse = monReader["niveau_classe"].ToString();
                    }

                    if (monReader["emploi_du_temps"] == DBNull.Value)
                    {
                        emploiDuTemps = default(string);
                    }
                    else
                    {
                        emploiDuTemps = monReader["emploi_du_temps"].ToString();
                    }

                    // Fermeture de la connexion
                    maConnexion.Close();

                    // Résultat retourné
                    return new Classe(idClasse, libelleClasse, niveauClasse, emploiDuTemps);
                }
                ind++;
            }
            #endregion

            // Fermeture de la connexion
            maConnexion.Close();

            // Résultat retourné
            return new Classe(null);
        }
        #endregion

        #region Méthode GetClasses retournant une List d'objets Eleves contenus dans la table CLASSE
        public static List<Classe> GetClasses()
        {
            #region Liste des attributs nécessaires pour récupérer et retourner le résultat attendu
            int idClasse;
            string libelleClasse;
            string niveauClasse;
            string emploiDuTemps;
            Classe uneClasse;
            #endregion

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Eleve
            List<Classe> lesClasses = new List<Classe>();

            uneClasse = new Classe(0, "!", "Choisissez une classe", null);
            lesClasses.Add(uneClasse);

            #region Création d'une commande SQL pour obtenir la liste des classes
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM CLASSE";
            #endregion

            // Récupération du résultat dans une variable
            SqlDataReader monReader = cmd.ExecuteReader();

            #region Remplissage de la liste à partir du reader
            while (monReader.Read())
            {
                idClasse = int.Parse(monReader["id_classe"].ToString());

                if (monReader["libelle_classe"] == DBNull.Value)
                {
                    libelleClasse = default(string);
                }
                else
                {
                    libelleClasse = monReader["libelle_classe"].ToString();
                }

                if (monReader["niveau_classe"] == DBNull.Value)
                {
                    niveauClasse = default(string);
                }
                else
                {
                    niveauClasse = monReader["niveau_classe"].ToString();
                }

                if (monReader["emploi_du_temps"] == DBNull.Value)
                {
                    emploiDuTemps = default(string);
                }
                else
                {
                    emploiDuTemps = monReader["emploi_du_temps"].ToString();
                }

                uneClasse = new Classe(idClasse, libelleClasse, niveauClasse, emploiDuTemps);

                lesClasses.Add(uneClasse);
            }
            #endregion

            // Fermeture de la connexion
            maConnexion.Close();

            // Résultat retourné
            return lesClasses;
        }
        #endregion

        #region Méthode GetNombreClasse le nombre de classe
        public static int GetNombreClasses()
        {
            #region Liste des attributs nécessaires pour récupérer et retourner le résultat attendu
            int nombreClasse;
            #endregion

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            #region Création d'une commande SQL pour récupérer le nombre de classes
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT COUNT(*) FROM CLASSE";
            #endregion

            nombreClasse = (int)cmd.ExecuteScalar();

            // Fermeture de la connexion
            maConnexion.Close();

            // Résultat retourné
            return nombreClasse;
        }
        #endregion
    }
}