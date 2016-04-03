using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UtilisateursBO
{
    public class Medicament
    {
        #region Attributs de la classe Medicament
        private int idMdc;
        private string lblMdc;
        private bool archivageMdc;
        #endregion

        #region Encapsulation des attributs de la classe Medicament
        public int IdMdc
        {
            get { return idMdc; }
            set { idMdc = value; }
        }
        
        public string LblMdc
        {
            get { return lblMdc; }
            set { lblMdc = value; }
        }

        public bool ArchivageMdc
        {
            get { return archivageMdc; }
            set { archivageMdc = value; }
        }
        #endregion

        #region Constructeurs de la classe Medicament
        public Medicament(int idMdc, string lblMdc, bool archivageMdc)
        {
            this.idMdc = idMdc;
            this.lblMdc = lblMdc;
            this.archivageMdc = archivageMdc;
        }

        public Medicament(string lblMdc, bool archivageMdc)
        {
            this.lblMdc = lblMdc;
            this.archivageMdc = archivageMdc;
        }

        public Medicament(int idMdc, string lblMdc)
        {
            this.idMdc = idMdc;
            this.lblMdc = lblMdc;
        }
        #endregion
    }
}