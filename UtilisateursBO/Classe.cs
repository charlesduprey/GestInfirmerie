using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UtilisateursBO
{
    public class Classe
    {
        #region Attributs de la classe Classe
        private int idClasse;
        private string libelleClasse;
        private string niveauClasse;
        private string emploiDuTemps;
        #endregion

        #region Encapsulation des attributs
        public int IdClasse
        {
            get { return idClasse; }
            set { idClasse = value; }
        }

        public string LibelleClasse
        {
            get { return libelleClasse; }
            set { libelleClasse = value; }
        }

        public string NiveauClasse
        {
            get { return niveauClasse; }
            set { niveauClasse = value; }
        }

        public string EmploiDuTemps
        {
            get { return emploiDuTemps; }
            set { emploiDuTemps = value; }
        }
        #endregion

        #region Constructeurs de la classe Classe
        public Classe()
        { }

        public Classe(string libelleClasse)
        {
            this.libelleClasse = (string)libelleClasse;
        }

        public Classe(int idClasse, string libelleClasse, string niveauClasse, string emploiDuTemps)
        {
            this.idClasse = idClasse;
            this.libelleClasse = libelleClasse;
            this.niveauClasse = niveauClasse;
            this.emploiDuTemps = emploiDuTemps;
        }

        public Classe(string libelleClasse, string niveauClasse, string emploiDuTemps)
        {
            this.libelleClasse = libelleClasse;
            this.niveauClasse = niveauClasse;
            this.emploiDuTemps = emploiDuTemps;
        }
        public Classe(int idClasse, string libelleClasse)
        {
            this.idClasse = idClasse;
            this.libelleClasse = libelleClasse;
        }
        #endregion
    }
}
