using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UtilisateursBO
{
    public class Visite
    {
        #region Attributs de la classe Visite
        private int idVst;
        private string motifVst;
        private string commentVst;
        private int pouls;
        private bool tellParents;
        private bool backHome;
        private bool goHospital;
        private DateTime dateVisite;
        private DateTime heureDebVst;
        private DateTime heureFinVst;
        private int idElv;
        #endregion

        #region Encapsulation des attributs
        public int IdVst
        {
            get { return idVst; }
            set { idVst = value; }
        }
        public string MotifVst
        {
            get { return motifVst; }
            set { motifVst = value; }
        }
        public string CommentVst
        {
            get { return commentVst; }
            set { commentVst = value; }
        }
        public int Pouls
        {
            get { return pouls; }
            set { pouls = value; }
        }
        public bool TellParents
        {
            get { return tellParents; }
            set { tellParents = value; }
        }
        public bool BackHome
        {
            get { return backHome; }
            set { backHome = value; }
        }
        public bool GoHospital
        {
            get { return goHospital; }
            set { goHospital = value; }
        }

        public DateTime DateVisite
        {
            get { return dateVisite; }
            set { dateVisite = value; }
        }
        public DateTime HeureDebVst
        {
            get { return heureDebVst; }
            set { heureDebVst = value; }
        }
        public DateTime HeureFinVst
        {
            get { return heureFinVst; }
            set { heureFinVst = value; }
        }
        public int IdElv
        {
            get { return idElv; }
            set { idElv = value; }
        }
        #endregion

        #region Constructeurs de la classe Visite
        #region Constructeur 1
        public Visite(
            int idVst,
            string motifVst,
            string commentVst,
            int pouls,
            bool tellParents,
            bool backHome,
            bool goHospital,
            DateTime dateVisite,
            DateTime heureDebVst,
            DateTime heureFinVst,
            int idElv)
        {
            this.idVst = idVst;
            this.motifVst = motifVst;
            this.commentVst = commentVst;
            this.pouls = pouls;
            this.tellParents = tellParents;
            this.backHome = backHome;
            this.goHospital = goHospital;
            this.dateVisite = dateVisite;
            this.heureDebVst = heureDebVst;
            this.heureFinVst = heureFinVst;
            this.idElv = idElv;
        }
        #endregion

        #region Constructeur 2
        public Visite(
            string motifVst,
            string commentVst,
            int pouls,
            bool tellParents,
            bool backHome,
            bool goHospital,
            DateTime dateVisite,
            DateTime heureDebVst,
            DateTime heureFinVst,
            int idElv)
        {
            this.motifVst = motifVst;
            this.commentVst = commentVst;
            this.pouls = pouls;
            this.tellParents = tellParents;
            this.backHome = backHome;
            this.goHospital = goHospital;
            this.dateVisite = dateVisite;
            this.heureDebVst = heureDebVst;
            this.heureFinVst = heureFinVst;
            this.idElv = idElv;
        }
        #endregion
        #endregion
    }
}