using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UtilisateursBO
{
    public class Eleve
    {
        private int id_eleves;
        private string nom;
        private string prenom;
        private DateTime date_naissance;
        private int day;
        private int month;
        private int year;
        private int tel_eleve;
        private int tel_parent;
        private bool tier_temps;
        private string commentaire_sante;
        private int id_classe;

        public Eleve(string nom, string prenom, int day, int month, int year, int tel_eleve, int tel_parent,
            bool tier_temps, string commentaire_sante, int id_classe)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.day = day;
            this.month = month;
            this.year = year;
            date_naissance = new DateTime(day, month, year);
            this.tel_eleve = tel_eleve;
            this.tel_parent = tel_parent;
            this.tier_temps = tier_temps;
            this.commentaire_sante = commentaire_sante;
            this.id_classe = id_classe;
        }
        public Eleve(int id_eleves, string nom, string prenom, int day, int month, int year, int tel_eleve, int tel_parent,
            bool tier_temps, string commentaire_sante, int id_classe)
        {
            this.id_eleves = id_eleves;
            this.nom = nom;
            this.prenom = prenom;
            this.day = day;
            this.month = month;
            this.year = year;
            date_naissance = new DateTime(day, month, year);
            this.tel_eleve = tel_eleve;
            this.tel_parent = tel_parent;
            this.tier_temps = tier_temps;
            this.commentaire_sante = commentaire_sante;
            this.id_classe = id_classe;
        }
        public Eleve(int id_eleves, string nom, string prenom, DateTime date_naissance, int tel_eleve, int tel_parent,
            bool tier_temps, string commentaire_sante, int id_classe)
        {
            this.id_eleves = id_eleves;
            this.nom = nom;
            this.prenom = prenom;
            this.date_naissance = date_naissance;
            this.tel_eleve = tel_eleve;
            this.tel_parent = tel_parent;
            this.tier_temps = tier_temps;
            this.commentaire_sante = commentaire_sante;
            this.id_classe = id_classe;
        }
        public int id
        {
            get { return id_eleves; }
            set { id_eleves = value; }
        }
        public string nom_eleve
        {
            get { return nom; }
            set { nom = value; }
        }
        public string prenom_eleve
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public DateTime date
        {
            get { return date_naissance; }
            set { date_naissance = value; }
        }
        public int day_naissance
        {
            get { return day_naissance; }
            set { day_naissance = value; }
        }
        public int month_naissance
        {
            get { return month_naissance; }
            set { month_naissance = value; }
        }
        public int year_naissance
        {
            get { return year_naissance; }
            set { year_naissance = value; }
        }
        public int tel_e
        {
            get { return tel_eleve; }
            set { tel_eleve = value; }
        }
        public int tel_p
        {
            get { return tel_p; }
            set { tel_p = value; }
        }
        public bool tiersTemps
        {
            get { return tier_temps; }
            set { tier_temps = value; }
        }
        public string commentaireSante
        {
            get { return commentaire_sante; }
            set { commentaire_sante = value; }
        }
        public int idClasse
        {
            get { return id_classe; }
            set { id_classe = value; }
        }
    }
}
