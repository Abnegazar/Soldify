using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.GESTION_CREDIT_DataSetTableAdapters;

namespace Business.ClassRemboursements
{
    class RemboursementClass
    {
        #region Champs
        #region Elementaires
            private int idRemboursement;
            private int idCredit;
            private int idEcheance;
            private System.DateTime dateRemboursement;
            private decimal nominalRembourser;
            private decimal interetRembourser;
            private decimal epargneRembourser;
            private decimal interetRetardRembourser;
            private decimal penaliteRetardRembourser;
            private string createdBy;
            private System.DateTime createdDate;
            private System.DateTime lastModifiedDate;
            private bool deleted;
        #endregion
        #endregion

        #region Propriétés
        #region Elémentaires
        public int IdRemboursement
            {
                get
                {
                    return this.idRemboursement;
                }
                set
                {
                    this.idRemboursement = value;
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
            public int IdEcheance
            {
                get
                {
                    return this.idEcheance;
                }
                set
                {
                    this.idEcheance = value;
                }
            }
            public System.DateTime DateRemboursement
            {
                get
                {
                    return this.dateRemboursement;
                }
                set
                {
                    this.dateRemboursement = value;
                }
            }
            public decimal NominalRembourser
            {
                get
                {
                    return this.nominalRembourser;
                }
                set
                {
                    this.nominalRembourser = value;
                }
            }
            public decimal InteretRembourser
            {
                get
                {
                    return this.interetRembourser;
                }
                set
                {
                    this.interetRembourser = value;
                }
            }
            public decimal EpargneRembourser
            {
                get
                {
                    return this.epargneRembourser;
                }
                set
                {
                    this.epargneRembourser = value;
                }
            }
            public decimal InteretRetardRembourser
            {
                get
                {
                    return this.interetRetardRembourser;
                }
                set
                {
                    this.interetRetardRembourser = value;
                }
            }
            public decimal PenaliteRetardRembourser
            {
                get
                {
                    return this.penaliteRetardRembourser;
                }
                set
                {
                    this.penaliteRetardRembourser = value;
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

        #region Variables
            public static T_RemboursementTableAdapter t_RemboursementTableAdapter = new T_RemboursementTableAdapter();
        #endregion

        #region Méthodes
            public string Save(int credit, decimal depot, DateTime dateRemboursement, string createdBy)
            {
                string message = string.Empty;
                message = (String)t_RemboursementTableAdapter.insert_Remboursement(ref message, depot, dateRemboursement, createdBy, credit);
                return message;
            }
        #endregion

    }
}
