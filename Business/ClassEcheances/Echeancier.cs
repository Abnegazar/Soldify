using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.GESTION_CREDIT_DataSetTableAdapters;

namespace Business.ClassEcheances
{
    class Echeance
    {
        #region Champs
        #region Elémentaires
            private int idCredit;
            private int idEcheance;
            private System.DateTime dateEcheance;
            private decimal capitalDebutPeriode;
            private decimal nominal;
            private decimal interet;
            private decimal epargne;
            private decimal annuite;
            private bool solder;
            private string createdBy;
            private System.DateTime createdDate;
            private System.DateTime lastModifiedDate;
            private bool deleted;
            private bool updatable;
        #endregion
        #endregion

        #region Propriétés
        #region Elémentaires
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
            public System.DateTime DateEcheance
            {
                get
                {
                    return this.dateEcheance;
                }
                set
                {
                    this.dateEcheance = value;
                }
            }
            public decimal CapitalDebutPeriode
            {
                get
                {
                    return this.capitalDebutPeriode;
                }
                set
                {
                    this.capitalDebutPeriode = value;
                }
            }
            public decimal Nominal
            {
                get
                {
                    return this.nominal;
                }
                set
                {
                    this.nominal = value;
                }
            }
            public decimal Interet
            {
                get
                {
                    return this.interet;
                }
                set
                {
                    this.interet = value;
                }
            }
            public decimal Epargne
            {
                get
                {
                    return this.epargne;
                }
                set
                {
                    this.epargne = value;
                }
            }
            public decimal Annuite
            {
                get
                {
                    return this.annuite;
                }
                set
                {
                    this.annuite = value;
                }
            }
            public bool Solder
            {
                get
                {
                    return this.solder;
                }
                set
                {
                    this.solder = value;
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
            public bool Updatable
        {
            get
            {
                return this.updatable;
            }
            set
            {
                this.updatable = value;
            }
        }
        #endregion
        #endregion

        #region Variables
            public static GESTION_CREDIT_DataSet.T_EcheanceDataTable t_EcheanceDataTable = new GESTION_CREDIT_DataSet.T_EcheanceDataTable();
            public static T_EcheanceTableAdapter t_EcheanceTableAdapter = new T_EcheanceTableAdapter();
        #endregion

        #region Méthodes
            public String Save(int idCredit)
            {
                string message = string.Empty;
                message = (String)t_EcheanceTableAdapter.insert_Echeance(ref message, idCredit);
                return message;
            }
            public List<Echeance> FindByCredit(int idCredit)
            {
                List<Echeance> returnList = new List<Echeance>();
                Echeance temp = new Echeance();
                t_EcheanceDataTable = t_EcheanceTableAdapter.select_Echeance(idCredit);

                foreach (GESTION_CREDIT_DataSet.T_EcheanceRow line in t_EcheanceDataTable)
                {
                    temp.idCredit = line.idCredit;
                    temp.IdEcheance = line.idEcheance;
                    temp.dateEcheance = line.dateEcheance;
                    temp.capitalDebutPeriode = line.capitalDebutPeriode;
                    temp.nominal = line.nominal;
                    temp.interet = line.interet;
                    temp.epargne = line.epargne;
                    temp.annuite = line.annuite;
                    temp.solder = line.solder;
                    temp.createdBy = line.createdBy;
                    temp.createdDate = line.createdDate;
                    temp.lastModifiedDate = line.lastModifiedDate;
                    temp.deleted = line.deleted;
                    temp.updatable = line.updatable;

                    returnList.Add(temp);
                }
                return returnList;
            }
        #endregion
    }
}
