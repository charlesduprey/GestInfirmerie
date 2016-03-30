using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using UtilisateursBO; // Référence la couche BO

namespace UtilisateursDAL
{
    public class EleveDAO
    {
        private static EleveDAO unEleveDAO; // Objet DAL

        #region Accesseur en lecture, renvoi une instance
        public static EleveDAO GetunUtilisateurDAO()
        {
            if (unEleveDAO == null)
            {
                unEleveDAO = new EleveDAO();
            }
            return unEleveDAO;
        }
        #endregion

        #region Méthode GetEleve retournant un élève
        public static Eleve GetLEleve(int id)
        {
            #region Liste des attributs nécessaires pour récupérer et retourner le résultat attendu
            int id_eleve;
            string nom;
            string prenom;
            DateTime date_naissance;
            int tel_eleve;
            int tel_parent;
            string tier_temps;
            string commentaire_sante;
            int id_classe;
            bool archive_elv;
            Eleve unEleve;
            #endregion

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            #region Création d'une commande SQL pour obtenir un élève à partir de son id
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM ELEVES WHERE ID = '" + id + "'";
            #endregion

            // Récupération du résultat dans une variable
            SqlDataReader monReader = cmd.ExecuteReader();

            #region Remplissage de la liste à partir du reader
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

                archive_elv = bool.Parse(monReader["archive_elv"].ToString());

                unEleve = new Eleve(id_eleve, nom, prenom, date_naissance, tel_eleve, tel_parent, bool.Parse(tier_temps), commentaire_sante, id_classe, archive_elv);
            } while (int.Parse(monReader["id_eleves"].ToString()) == id);
            #endregion

            // Fermeture de la connexion
            maConnexion.Close();

            // Résultat retourné
            return unEleve;
        }
        #endregion

        #region Méthode GetEleves retournant une List d'objets Eleves contenus dans la table ELEVES
        public static List<Eleve> GetEleves()
        {
            #region Liste des attributs nécessaires pour récupérer et retourner le résultat attendu
            int id_eleve;
            string nom;
            string prenom;
            DateTime date_naissance;
            int tel_eleve;
            int tel_parent;
            string tier_temps;
            string commentaire_sante;
            int id_classe;
            bool archive_elv;
            Eleve unEleve;
            #endregion

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Eleve
            List<Eleve> lesEleves = new List<Eleve>();

            #region Création d'une commande SQL pour selectionner les élèves
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM ELEVES";
            #endregion

            // Récupération du résultat dans une variable
            SqlDataReader monReader = cmd.ExecuteReader();

            #region Remplissage de la liste à partir du reader
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

                archive_elv = bool.Parse(monReader["archiver"].ToString());

                unEleve = new Eleve(id_eleve, nom, prenom, date_naissance, tel_eleve, tel_parent, bool.Parse(tier_temps), commentaire_sante, id_classe, archive_elv);
                lesEleves.Add(unEleve);
            }
            #endregion

            // Fermeture de la connexion
            maConnexion.Close();

            // Résultat retourné
            return lesEleves;
        }
        #endregion

        #region Méthode GetElevesAchives retournant une List d'objets Eleves contenus dans la table ELEVES
        public static List<Eleve> GetElevesArchives()
        {
            #region Liste des attributs nécessaires pour récupérer et retourner le résultat attendu
            int id_eleve;
            string nom;
            string prenom;
            DateTime date_naissance;
            int tel_eleve;
            int tel_parent;
            string tier_temps;
            string commentaire_sante;
            int id_classe;
            bool archive_elv;
            Eleve unEleve;
            #endregion

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Eleve
            List<Eleve> lesEleves = new List<Eleve>();

            #region Création d'une commande SQL pour obtenir les élèves archivés
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM ELEVES WHERE archive_elv = '1'";
            #endregion

            // Récupération du résultat dans une variable
            SqlDataReader monReader = cmd.ExecuteReader();

            #region Remplissage de la liste à partir du reader
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

                archive_elv = bool.Parse(monReader["archive_elv"].ToString());

                unEleve = new Eleve(id_eleve, nom, prenom, date_naissance, tel_eleve, tel_parent, bool.Parse(tier_temps), commentaire_sante, id_classe, archive_elv);
                lesEleves.Add(unEleve);
            }
            #endregion

            // Fermeture de la connexion
            maConnexion.Close();

            // Résultat retourné
            return lesEleves;
        }
        #endregion

        #region Méthode GetEleves retournant une List d'objets Eleves contenus dans la table ELEVES
        public static List<Eleve> GetElevesNonArchives()
        {
            #region Liste des attributs nécessaires pour récupérer et retourner le résultat attendu
            int id_eleve;
            string nom;
            string prenom;
            DateTime date_naissance;
            int tel_eleve;
            int tel_parent;
            string tier_temps;
            string commentaire_sante;
            int id_classe;
            bool archive_elv;
            Eleve unEleve;
            #endregion

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Eleve
            List<Eleve> lesEleves = new List<Eleve>();

            #region Création d'une commande SQL pour obtenir les élèves non archivés
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM ELEVES WHERE archiver = '0'";
            #endregion

            // Récupération du résultat dans une variable
            SqlDataReader monReader = cmd.ExecuteReader();

            #region Remplissage de la liste à partir du reader
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

                archive_elv = bool.Parse(monReader["archiver"].ToString());

                unEleve = new Eleve(id_eleve, nom, prenom, date_naissance, tel_eleve, tel_parent, bool.Parse(tier_temps), commentaire_sante, id_classe, archive_elv);
                lesEleves.Add(unEleve);
            }
            #endregion

            // Fermeture de la connexion
            maConnexion.Close();

            // Résultat retourné
            return lesEleves;
        }
        #endregion

        #region Méthode AjoutEleve insérant un nouvel utilisateur passé en paramètre dans la BD
        public static int AjoutEleve(Eleve unEleve)
        {
            // Attribut nécessaire pour récupérer et retourner le résultat attendu
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            #region Création d'une commande SQL pour ajouter un élève
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO ELEVES (nom, prenom, date_naissance, tel_eleve, tel_parent, tier_temps, commentaire_sante, archiver, id_classe) values('" + unEleve.Nom + "', '" + unEleve.Prenom + "', '" + unEleve.Date_naissance + "', " + unEleve.Tel_eleve + ", " + unEleve.Tel_parent + ", '" + unEleve.Tier_temps + "', '" + unEleve.Commentaire_sante + "', '" + unEleve.ArchiveEleve + "', " + unEleve.Id_classe + ")";
            #endregion

            // Récupération du résultat dans une variable
            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            // Résultat retourné
            return nbEnr;
        }
        #endregion

        #region Méthode UpdateEleve modifie un utilisateur passé en paramètre dans la BD
        public static int UpdateEleve(Eleve unEleve)
        {
            // Attribut nécessaire pour récupérer et retourner le résultat attendu
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            #region Création d'une commande SQL pour modie=fier un élève
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE ELEVES SET nom = '" + unEleve.Nom + "', prenom = '" + unEleve.Prenom + "', date_naissance = '" + unEleve.Date_naissance + "', tel_eleve = '" + unEleve.Tel_eleve + "', tel_parent = '" + unEleve.Tel_parent + "', tier_temps = '" + unEleve.Tier_temps + "', commentaire_sante = '" + unEleve.Commentaire_sante + "', id_classe = '" + unEleve.Id_classe + "', archiver = '" + unEleve.ArchiveEleve + "' WHERE id_eleves = " + unEleve.Id_eleves;
            #endregion

            // Récupération du résultat dans une variable
            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            // Résultat retourné
            return nbEnr;
        }
        #endregion

        #region Méthode DeleteEleve qui supprime de la BD un élève à partir de son id
        public static int DeleteEleve(int id)
        {
            // Attribut nécessaire pour récupérer et retourner le résultat attendu
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            #region Création d'une commande SQL pour supprimer un élève à partir de son id
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM ELEVES WHERE id_eleves = '" + id + "';";
            #endregion

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            // Résultat retourné
            return nbEnr;
        }
        #endregion

        #region Méthode ArchiverEleve permettant d'archiver les élèves à partir de leur id
        public static int ArchiverEleve(int id)
        {
            // Attribut nécessaire pour récupérer et retourner le résultat attendu
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            #region Création d'une commande SQL pour archiver un élève à partir de son id
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE ELEVES SET archivage = 'true' WHERE id_eleves = " + id;
            #endregion

            // Récupération du résultat dans une variable
            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            // Résultat retourné
            return nbEnr;
        }
        #endregion

        #region Méthode TrouverEleve permettant de savoir si un élève à été reçu au moins une fois en visite à partir de leur id
        public static bool TrouverEleve(int id)
        {
            // Attributs nécessaires pour récupérer et retourner le résultat attendu
            int nbEnr;
            bool trouve = false;
            int valRet;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            #region Création d'une commande SQL pour trouver un élève à partir de son id
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT count (*) "
                            + " FROM ELEVES "
                            + " WHERE id_eleves = '" + id + "' "
                            + " AND id_eleves in ( SELECT id_eleves  "
                            + "FROM VISITE);";
            #endregion

            // Récupération du résultat dans une variable
            valRet = (int)cmd.ExecuteScalar();

            nbEnr = valRet;

            // Fermeture de la connexion
            maConnexion.Close();
            if (nbEnr > 0)
            {
                trouve = true;
            }
            // Résultat retourné
            return trouve;
        }
        #endregion

        #region Méthode GetNomClasse permettant de récupérer le niveau et la section d'une classe selon l'idClasse
        public static string GetNomClasse(int idClasse)
        {
            #region Liste des attributs nécessaires pour récupérer et retourner le résultat attendu
            string niveauClasse;
            string sectionClasse;
            #endregion

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            #region Création d'une commande SQL pour récupérer le niveau de la classe selon son identifiant
            SqlCommand niveau = new SqlCommand();
            niveau.Connection = maConnexion;
            niveau.CommandText = "SELECT niveau_classe FROM CLASSE WHERE id_classe = '" + idClasse + "'";
            #endregion

            // Récupération du résultat dans une variable
            niveauClasse = Convert.ToString(niveau.ExecuteScalar().ToString());

            #region Création d'une commande SQL pour récupérer la section de la classe selon son identifiant
            SqlCommand section = new SqlCommand();
            section.Connection = maConnexion;
            section.CommandText = "SELECT libelle_classe FROM CLASSE WHERE id_classe = '" + idClasse + "'";
            #endregion

            // Récupération du résultat dans une variable
            sectionClasse = Convert.ToString(section.ExecuteScalar().ToString());

            // Fermeture de la connexion
            maConnexion.Close();

            // Résultat retourné
            return niveauClasse + " " + sectionClasse;
        }
        #endregion
    }
}
