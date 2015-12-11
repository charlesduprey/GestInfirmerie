﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UtilisateursBO
{
    public class Eleve
    {
        #region Attributs de la classe Eleve
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
        private bool archive_elv;
        #endregion

        #region Encapsulation des attributs
        public int Id_eleves
        {
            get { return id_eleves; }
            set { id_eleves = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public DateTime Date_naissance
        {
            get { return date_naissance; }
            set { date_naissance = value; }
        }

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int Tel_eleve
        {
            get { return tel_eleve; }
            set { tel_eleve = value; }
        }

        public int Tel_parent
        {
            get { return tel_parent; }
            set { tel_parent = value; }
        }

        public bool Tier_temps
        {
            get { return tier_temps; }
            set { tier_temps = value; }
        }

        public string Commentaire_sante
        {
            get { return commentaire_sante; }
            set { commentaire_sante = value; }
        }

        public int Id_classe
        {
            get { return id_classe; }
            set { id_classe = value; }
        }

        public bool Archive_elv
        {
            get { return archive_elv; }
            set { archive_elv = value; }
        }
        #endregion

        #region Constructeurs de la classe Eleve
        public Eleve()
        { }

        public Eleve(string nom, string prenom, int day, int month, int year, int tel_eleve, int tel_parent,
            bool tier_temps, string commentaire_sante, int id_classe, bool archive_elv)
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
            this.archive_elv = archive_elv;
        }
        public Eleve(int id_eleves, string nom, string prenom, int day, int month, int year, int tel_eleve, int tel_parent,
            bool tier_temps, string commentaire_sante, int id_classe, bool archive_elv)
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
            this.archive_elv = archive_elv;
        }

        public Eleve(string nom, string prenom, DateTime date_naissance, int tel_eleve, int tel_parent,
            bool tier_temps, string commentaire_sante, int id_classe, bool archive_elv)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.date_naissance = date_naissance;
            this.tel_eleve = tel_eleve;
            this.tel_parent = tel_parent;
            this.tier_temps = tier_temps;
            this.commentaire_sante = commentaire_sante;
            this.id_classe = id_classe;
            this.archive_elv = archive_elv;
        }

        public Eleve(int id_eleves, string nom, string prenom, DateTime date_naissance, int tel_eleve, int tel_parent,
            bool tier_temps, string commentaire_sante, int id_classe, bool archive_elv)
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
            this.archive_elv = archive_elv;
        }
        #endregion
    }
}