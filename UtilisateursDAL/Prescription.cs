using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UtilisateursDAL
{
    public class Prescription
    {
        #region Attributs de la classe Visite
        private int idVst;
        private int idMedic;
        private int nbPrescri;
        #endregion

        #region Encapsulation des attributs
        public int IdVst
        {
            get { return idVst; }
            set { idVst = value; }
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

        #region Constructeur de la classe Prescription
        public Prescription(
            int idVst,
            int idMedic,
            int nbPrescri)
        {
            this.idVst = idVst;
            this.idMedic = idMedic;
            this.nbPrescri = nbPrescri;
        }
        #endregion
    }
}
