using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UtilisateursBO
{
    public class Prescription
    {
        #region Attributs de la classe Prescription
        private int idVisite;
        private int idMedic;
        private int nbPrescri;
        #endregion

        #region Encapsulation des attributs
        public int IdVisite
        {
            get { return idVisite; }
            set { idVisite = value; }
        }
        public int IdMedic
        {
            get { return idMedic; }
            set { idMedic = value; }
        }
        public int NbPrescri
        {
            get { return nbPrescri; }
            set { nbPrescri = value; }
        }
        #endregion

        #region Constructeurs de la classe Prescription
        #region Constructeur 1
        public Prescription(
            int idVisite,
            int idMedic,
            int nbPrescri)
        {
            this.idVisite = idVisite;
            this.idMedic = idMedic;
            this.nbPrescri = nbPrescri;
        }
        #endregion

        #region Constructeur 2
        public Prescription(
            int idMedic,
            int nbPrescri)
        {
            this.idMedic = idMedic;
            this.nbPrescri = nbPrescri;
        }
        #endregion
        #endregion
    }
}
