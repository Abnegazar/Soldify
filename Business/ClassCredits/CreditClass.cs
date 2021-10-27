using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.GESTION_CREDIT_DataSetTableAdapters;

namespace Business.ClassCredits
{
    class CreditClass
    {
        #region Champs
        #region Elementaires
            private int idCredit;
            private int idClient;
            private int idProduit;
            private string nomCredit;
            private string description;
            private string typeAmortissement;
            private decimal montant;
            private double taux;
            private int duree;
            private int frequenceRemboursement;
            private double tauxRetard;
            private decimal penaliteRetard;
            private decimal differe;
            private double tauxEpargne;
            private System.DateTime dateSouscription;
            private string etatCredit;
            private string createdBy;
            private System.DateTime createdDate;
            private System.DateTime lastModifiedDate;
            private bool deleted;
            private bool updatable;
        #endregion
        #endregion

        #region Propriétés
        #region Elementaires
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
            public int IdClient
            {
                get
                {
                    return this.idClient;
                }
                set
                {
                    this.idClient = value;
                }
            }
            public int IdProduit
            {
                get
                {
                    return this.idProduit;
                }
                set
                {
                    this.idProduit = value;
                }
            }
            public string NomCredit
            {
                get
                {
                    return this.nomCredit;
                }
                set
                {
                    this.nomCredit = value;
                }
            }
            public string Description
            {
                get
                {
                    return this.description;
                }
                set
                {
                    this.description = value;
                }
            }
            public string TypeAmortissement
            {
                get
                {
                    return this.typeAmortissement;
                }
                set
                {
                    this.typeAmortissement = value;
                }
            }
            public decimal Montant
            {
                get
                {
                    return this.montant;
                }
                set
                {
                    this.montant = value;
                }
            }
            public double Taux
            {
                get
                {
                    return this.taux;
                }
                set
                {
                    this.taux = value;
                }
            }
            public int Duree
            {
                get
                {
                    return this.duree;
                }
                set
                {
                    this.duree = value;
                }
            }
            public int FrequenceRemboursement
            {
                get
                {
                    return this.frequenceRemboursement;
                }
                set
                {
                    this.frequenceRemboursement = value;
                }
            }
            public double TauxRetard
            {
                get
                {
                    return this.tauxRetard;
                }
                set
                {
                    this.tauxRetard = value;
                }
            }
            public decimal PenaliteRetard
            {
                get
                {
                    return this.penaliteRetard;
                }
                set
                {
                    this.penaliteRetard = value;
                }
            }
            public decimal Differe
            {
                get
                {
                    return this.differe;
                }
                set
                {
                    this.differe = value;
                }
            }
            public double TauxEpargne
            {
                get
                {
                    return this.tauxEpargne;
                }
                set
                {
                    this.tauxEpargne = value;
                }
            }
            public System.DateTime DateSouscription
            {
                get
                {
                    return this.dateSouscription;
                }
                set
                {
                    this.dateSouscription = value;
                }
            }
            public string EtatCredit
            {
                get
                {
                    return this.etatCredit;
                }
                set
                {
                    this.etatCredit = value;
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
            public static GESTION_CREDIT_DataSet.T_CreditDataTable t_CreditDataTable = new GESTION_CREDIT_DataSet.T_CreditDataTable();
            public static T_CreditTableAdapter t_CreditTableAdapter = new T_CreditTableAdapter();
        #endregion

        #region methode
            public string Save()
            {
                string message = string.Empty;
                message = (String)t_CreditTableAdapter.insert_Credit(ref message, idClient, idProduit, nomCredit, description, typeAmortissement, montant, taux, duree, frequenceRemboursement, tauxRetard, penaliteRetard, differe, tauxEpargne, dateSouscription, etatCredit, createdBy);
                return message;
            }

            public List<CreditClass> Find()
            {
                List<CreditClass> returnList = new List<CreditClass>();
                CreditClass temp = new CreditClass();

                t_CreditDataTable = t_CreditTableAdapter.select_Credit(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, false, null);
                foreach (GESTION_CREDIT_DataSet.T_CreditRow line in t_CreditDataTable)
                {
                    temp.idCredit = line.idCredit;
                    temp.idClient = line.idClient;
                    temp.idProduit = line.idProduit;
                    temp.nomCredit = line.nomCredit;
                    temp.description = line.description;
                    temp.typeAmortissement = line.typeAmortissement;
                    temp.montant = line.montant;
                    temp.taux = line.taux;
                    temp.duree = line.duree;
                    temp.frequenceRemboursement = line.frequenceRemboursement;
                    temp.tauxRetard = line.tauxRetard;
                    temp.penaliteRetard = line.penaliteRetard;
                    temp.differe = line.differe;
                    temp.tauxEpargne = line.tauxEpargne;
                    temp.dateSouscription = line.dateSouscription;
                    temp.etatCredit = line.etatCredit;
                    temp.createdBy = line.createdBy;
                    temp.createdDate = line.createdDate;
                    temp.lastModifiedDate = line.lastModifiedDate;
                    temp.deleted = line.deleted;
                    temp.updatable = line.updatable;

                    returnList.Add(temp);
                }

                return returnList;
            }

            public List<CreditClass> FindByProduit(int idProd)
            {
                List<CreditClass> returnList = new List<CreditClass>();
                CreditClass temp = new CreditClass();

                t_CreditDataTable = t_CreditTableAdapter.select_Credit(null, null, idProd, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, false, null);
                foreach (GESTION_CREDIT_DataSet.T_CreditRow line in t_CreditDataTable)
                {
                    temp.idCredit = line.idCredit;
                    temp.idClient = line.idClient;
                    temp.idProduit = line.idProduit;
                    temp.nomCredit = line.nomCredit;
                    temp.description = line.description;
                    temp.typeAmortissement = line.typeAmortissement;
                    temp.montant = line.montant;
                    temp.taux = line.taux;
                    temp.duree = line.duree;
                    temp.frequenceRemboursement = line.frequenceRemboursement;
                    temp.tauxRetard = line.tauxRetard;
                    temp.penaliteRetard = line.penaliteRetard;
                    temp.differe = line.differe;
                    temp.tauxEpargne = line.tauxEpargne;
                    temp.dateSouscription = line.dateSouscription;
                    temp.etatCredit = line.etatCredit;
                    temp.createdBy = line.createdBy;
                    temp.createdDate = line.createdDate;
                    temp.lastModifiedDate = line.lastModifiedDate;
                    temp.deleted = line.deleted;
                    temp.updatable = line.updatable;

                    returnList.Add(temp);
                }

                return returnList;
            }

            public List<CreditClass> FindByClient(int idCli)
        {
            List<CreditClass> returnList = new List<CreditClass>();
            CreditClass temp = new CreditClass();

            t_CreditDataTable = t_CreditTableAdapter.select_Credit(null, idCli, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, false, null);
            foreach (GESTION_CREDIT_DataSet.T_CreditRow line in t_CreditDataTable)
            {
                temp.idCredit = line.idCredit;
                temp.idClient = line.idClient;
                temp.idProduit = line.idProduit;
                temp.nomCredit = line.nomCredit;
                temp.description = line.description;
                temp.typeAmortissement = line.typeAmortissement;
                temp.montant = line.montant;
                temp.taux = line.taux;
                temp.duree = line.duree;
                temp.frequenceRemboursement = line.frequenceRemboursement;
                temp.tauxRetard = line.tauxRetard;
                temp.penaliteRetard = line.penaliteRetard;
                temp.differe = line.differe;
                temp.tauxEpargne = line.tauxEpargne;
                temp.dateSouscription = line.dateSouscription;
                temp.etatCredit = line.etatCredit;
                temp.createdBy = line.createdBy;
                temp.createdDate = line.createdDate;
                temp.lastModifiedDate = line.lastModifiedDate;
                temp.deleted = line.deleted;
                temp.updatable = line.updatable;

                returnList.Add(temp);
            }

            return returnList;
        }

            public string Update(CreditClass credit)
            {
                string message = string.Empty;
                message = (String)t_CreditTableAdapter.update_Credit(credit.idCredit, ref message, credit.nomCredit, credit.description, credit.typeAmortissement, credit.montant, credit.taux, credit.duree, credit.frequenceRemboursement, credit.tauxRetard, credit.penaliteRetard, credit.differe, credit.tauxEpargne, credit.dateSouscription, credit.etatCredit, credit.createdBy);
                return message;
            }
        #endregion

    }
}
