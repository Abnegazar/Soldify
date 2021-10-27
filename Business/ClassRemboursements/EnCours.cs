using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ClassRemboursements
{
    class EnCours
    {
        #region Champs
        #region Elémentaires
            private int idEnCourDePaiement;
            private int idCredit;
            private int idEcheanceEnCours;
            private decimal nominalRestant;
            private decimal epargneRestant;
            private decimal interetRestant;
            private decimal interetRetardRestant;
            private decimal penaliteRetardRestant;
            private bool echeanceSolder;
            private string createdBy;
            private System.DateTime createdDate;
            private System.DateTime lastModifiedDate;
            private bool deleted;
        #endregion
        #endregion

        #region Propriétés
        #region Elémentaires
            public int IdEnCourDePaiement
            {
                get
                {
                    return this.idEnCourDePaiement;
                }
                set
                {
                    this.idEnCourDePaiement = value;
                }
            }
            public int IdCredit
            {
                get
                {
                    return this.idCredit;
                }
                set
                {
                    this.idCredit = value;
                }
            }
            public int IdEcheanceEnCours
            {
                get
                {
                    return this.idEcheanceEnCours;
                }
                set
                {
                    this.idEcheanceEnCours = value;
                }
            }
            public decimal NominalRestant
            {
                get
                {
                    return this.nominalRestant;
                }
                set
                {
                    this.nominalRestant = value;
                }
            }
            public decimal EpargneRestant
            {
                get
                {
                    return this.epargneRestant;
                }
                set
                {
                    this.epargneRestant = value;
                }
            }
            public decimal InteretRestant
            {
                get
                {
                    return this.interetRestant;
                }
                set
                {
                    this.interetRestant = value;
                }
            }
            public decimal InteretRetardRestant
            {
                get
                {
                    return this.interetRetardRestant;
                }
                set
                {
                    this.interetRetardRestant = value;
                }
            }
            public decimal PenaliteRetardRestant
            {
                get
                {
                    return this.penaliteRetardRestant;
                }
                set
                {
                    this.penaliteRetardRestant = value;
                }
            }
            public bool EcheanceSolder
            {
                get
                {
                    return this.echeanceSolder;
                }
                set
                {
                    this.echeanceSolder = value;
                }
            }
            public string CreatedBy
            {
                get
                {
                    return this.createdBy;
                }
                set
                {
                    this.createdBy = value;
                }
            }
            public System.DateTime CreatedDate
            {
                get
                {
                    return this.createdDate;
                }
                set
                {
                    this.createdDate = value;
                }
            }
            public System.DateTime LastModifiedDate
            {
                get
                {
                    return this.lastModifiedDate;
                }
                set
                {
                    this.lastModifiedDate = value;
                }
            }
            public bool Deleted
        {
            get
            {
                return this.deleted;
            }
            set
            {
                this.deleted = value;
            }
        }
        #endregion
        #endregion
    }
}
