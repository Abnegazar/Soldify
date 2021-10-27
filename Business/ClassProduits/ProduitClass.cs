using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.GESTION_CREDIT_DataSetTableAdapters;

namespace Business.ClassProduits
{
    class ProduitClass
    {

        #region Champs
        #region Elementaires
            private int idProduit;

            private string nomProduit;

            private string description;

            private string typeAmortissement;

            private string typeProduit;

            private decimal montantMin;

            private decimal montantMax;

            private double tauxMin;

            private double tauxMax;

            private int dureeMin;

            private int dureeMax;

            private int differeMin;

            private int differeMax;

            private double tauxEpargneMin;

            private double tauxEpargneMax;

            private string typeClient;

            private double tauxRetardMin;

            private double tauxRetardMax;

            private double tauxPenaliteRetard;

            private string createdBy;

            private System.DateTime createdDate;

            private System.DateTime lastModifiedDate;

            private bool deleted;

            private bool updatable;
        #endregion

        #region Objets
        #endregion
        #endregion

        #region Propriétés
        #region Elémentaires
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
        public string NomProduit
        {
            get
            {
                return this.nomProduit;
            }
            set
            {
                this.nomProduit = value;
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
        public string TypeProduit
        {
            get
            {
                return this.typeProduit;
            }
            set
            {
                this.typeProduit = value;
            }
        }
        public decimal MontantMin
        {
            get
            {
                return this.montantMin;
            }
            set
            {
                this.montantMin = value;
            }
        }
        public decimal MontantMax
        {
            get
            {
                return this.montantMax;
            }
            set
            {
                this.montantMax = value;
            }
        }
        public double TauxMin
        {
            get
            {
                return this.tauxMin;
            }
            set
            {
                this.tauxMin = value;
            }
        }
        public double TauxMax
        {
            get
            {
                return this.tauxMax;
            }
            set
            {
                this.tauxMax = value;
            }
        }
        public int DureeMin
        {
            get
            {
                return this.dureeMin;
            }
            set
            {
                this.dureeMin = value;
            }
        }
        public int DureeMax
        {
            get
            {
                return this.dureeMax;
            }
            set
            {
                this.dureeMax = value;
            }
        }
        public int DiffereMin
        {
            get
            {
                return this.differeMin;
            }
            set
            {
                this.differeMin = value;
            }
        }
        public int DiffereMax
        {
            get
            {
                return this.differeMax;
            }
            set
            {
                this.differeMax = value;
            }
        }
        public double TauxEpargneMin
        {
            get
            {
                return this.tauxEpargneMin;
            }
            set
            {
                this.tauxEpargneMin = value;
            }
        }
        public double TauxEpargneMax
        {
            get
            {
                return this.tauxEpargneMax;
            }
            set
            {
                this.tauxEpargneMax = value;
            }
        }
        public string TypeClient
        {
            get
            {
                return this.typeClient;
            }
            set
            {
                this.typeClient = value;
            }
        }
        public double TauxRetardMin
        {
            get
            {
                return this.tauxRetardMin;
            }
            set
            {
                this.tauxRetardMin = value;
            }
        }
        public double TauxRetardMax
        {
            get
            {
                return this.tauxRetardMax;
            }
            set
            {
                this.tauxRetardMax = value;
            }
        }
        public double TauxPenaliteRetard
        {
            get
            {
                return this.tauxPenaliteRetard;
            }
            set
            {
                this.tauxPenaliteRetard = value;
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

        #region Objets
        #endregion
        #endregion

        #region Variables
            public static T_ProduitTableAdapter t_ProduitTableAdapter = new T_ProduitTableAdapter();
            public static GESTION_CREDIT_DataSet.T_ProduitDataTable t_ProduitDataTable = new GESTION_CREDIT_DataSet.T_ProduitDataTable();
        #endregion

        #region Méthodes
            public string Save()
            {
                string message = string.Empty;
                message = (String)t_ProduitTableAdapter.insert_Produit(ref message, nomProduit, description, typeAmortissement, typeProduit, montantMin, montantMax, tauxMin, tauxMax, dureeMin, dureeMax, differeMin, differeMax, TauxEpargneMin, tauxEpargneMax, typeClient, tauxRetardMin, tauxRetardMax, tauxPenaliteRetard, createdBy);
                return message;
            }

            public string Update(ProduitClass produit)
            {
                string message = string.Empty;
                message = (String)t_ProduitTableAdapter.update_Produit(produit.idProduit, ref message, produit.nomProduit, produit.description, produit.typeAmortissement, produit.typeProduit, produit.montantMin, produit.montantMax, produit.tauxMin, produit.tauxMax, produit.dureeMin, produit.dureeMax, produit.differeMin, produit.differeMax, produit.TauxEpargneMin, produit.tauxEpargneMax, produit.typeClient, produit.tauxRetardMin, produit.tauxRetardMax, produit.tauxPenaliteRetard, produit.deleted, produit.updatable);
                return message;
            }

            public string Delete()
            {
                string message = string.Empty;
                message = (String)t_ProduitTableAdapter.delete_Produit(idProduit, ref message, false);
                return message;
            }

            public static List<ProduitClass> Find()
            {
                List<ProduitClass> returnList = new List<ProduitClass>();
                ProduitClass temp = new ProduitClass();
                t_ProduitDataTable = t_ProduitTableAdapter.select_Produit(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, false, null);
                foreach(GESTION_CREDIT_DataSet.T_ProduitRow line in t_ProduitDataTable)
                {
                    temp.tauxMin = line.tauxMin;
                    temp.tauxMax = line.tauxMax;
                    temp.deleted = line.deleted;
                    temp.dureeMin = line.dureeMin;
                    temp.dureeMax = line.dureeMax;
                    temp.idProduit = line.idProduit;
                    temp.updatable = line.updatable;
                    temp.createdBy = line.createdBy;
                    temp.nomProduit = line.nomProduit;
                    temp.typeClient = line.typeClient;
                    temp.montantMin = line.montantMin;
                    temp.montantMax = line.montantMax;
                    temp.differeMin = line.differeMin;
                    temp.differeMax = line.differeMax;
                    temp.description = line.description;
                    temp.createdDate = line.createdDate;
                    temp.tauxRetardMin = line.tauxRetardMin;
                    temp.tauxRetardMax = line.tauxRetardMax;
                    temp.tauxEpargneMin = line.tauxEpargneMin;
                    temp.lastModifiedDate = line.lastModifiedDate;
                    temp.typeAmortissement = line.typeAmortissement;
                    temp.tauxPenaliteRetard = line.tauxPenaliteRetard;

                    returnList.Add(temp);
                }
                return returnList;
            }

            public static List<ProduitClass> FindByTypeProduit(String typeProduit)
            {
                List<ProduitClass> returnList = new List<ProduitClass>();
                ProduitClass temp = new ProduitClass();
                t_ProduitDataTable = t_ProduitTableAdapter.select_Produit(null, null, null, null, typeProduit, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, false, null);
                foreach (GESTION_CREDIT_DataSet.T_ProduitRow line in t_ProduitDataTable)
                {
                    temp.tauxMin = line.tauxMin;
                    temp.tauxMax = line.tauxMax;
                    temp.deleted = line.deleted;
                    temp.dureeMin = line.dureeMin;
                    temp.dureeMax = line.dureeMax;
                    temp.idProduit = line.idProduit;
                    temp.updatable = line.updatable;
                    temp.createdBy = line.createdBy;
                    temp.nomProduit = line.nomProduit;
                    temp.typeClient = line.typeClient;
                    temp.montantMin = line.montantMin;
                    temp.montantMax = line.montantMax;
                    temp.differeMin = line.differeMin;
                    temp.differeMax = line.differeMax;
                    temp.description = line.description;
                    temp.createdDate = line.createdDate;
                    temp.tauxRetardMin = line.tauxRetardMin;
                    temp.tauxRetardMax = line.tauxRetardMax;
                    temp.tauxEpargneMin = line.tauxEpargneMin;
                    temp.lastModifiedDate = line.lastModifiedDate;
                    temp.typeAmortissement = line.typeAmortissement;
                    temp.tauxPenaliteRetard = line.tauxPenaliteRetard;

                    returnList.Add(temp);
                }
                return returnList;
            }

            public static List<ProduitClass> FindByTypeProduitClientAmmort(String typeProduit, String typeClient, String typeAmmortissement)
            {
                List<ProduitClass> returnList = new List<ProduitClass>();
                ProduitClass temp = new ProduitClass();
                t_ProduitDataTable = t_ProduitTableAdapter.select_Produit(null, null, null, typeAmmortissement, typeProduit, null, null, null, null, null, null, null, null, null, null, typeClient, null, null, null, null, null, null, false, null);
                foreach (GESTION_CREDIT_DataSet.T_ProduitRow line in t_ProduitDataTable)
                {
                    temp.tauxMin = line.tauxMin;
                    temp.tauxMax = line.tauxMax;
                    temp.deleted = line.deleted;
                    temp.dureeMin = line.dureeMin;
                    temp.dureeMax = line.dureeMax;
                    temp.idProduit = line.idProduit;
                    temp.updatable = line.updatable;
                    temp.createdBy = line.createdBy;
                    temp.nomProduit = line.nomProduit;
                    temp.typeClient = line.typeClient;
                    temp.montantMin = line.montantMin;
                    temp.montantMax = line.montantMax;
                    temp.differeMin = line.differeMin;
                    temp.differeMax = line.differeMax;
                    temp.description = line.description;
                    temp.createdDate = line.createdDate;
                    temp.tauxRetardMin = line.tauxRetardMin;
                    temp.tauxRetardMax = line.tauxRetardMax;
                    temp.tauxEpargneMin = line.tauxEpargneMin;
                    temp.lastModifiedDate = line.lastModifiedDate;
                    temp.typeAmortissement = line.typeAmortissement;
                    temp.tauxPenaliteRetard = line.tauxPenaliteRetard;

                    returnList.Add(temp);
                }
                return returnList;
            }

            public static List<ProduitClass> FindByMontantTaux(decimal montantMin, decimal montantMax, double tauxMin, double tauxMax)
            {
                List<ProduitClass> returnList = new List<ProduitClass>();
                ProduitClass temp = new ProduitClass();
                t_ProduitDataTable = t_ProduitTableAdapter.select_Produit(null, null, null, null, null, montantMin, montantMax, tauxMin, tauxMax, null, null, null, null, null, null, null, null, null, null, null, null, null, false, null);
                foreach (GESTION_CREDIT_DataSet.T_ProduitRow line in t_ProduitDataTable)
                {
                    temp.tauxMin = line.tauxMin;
                    temp.tauxMax = line.tauxMax;
                    temp.deleted = line.deleted;
                    temp.dureeMin = line.dureeMin;
                    temp.dureeMax = line.dureeMax;
                    temp.idProduit = line.idProduit;
                    temp.updatable = line.updatable;
                    temp.createdBy = line.createdBy;
                    temp.nomProduit = line.nomProduit;
                    temp.typeClient = line.typeClient;
                    temp.montantMin = line.montantMin;
                    temp.montantMax = line.montantMax;
                    temp.differeMin = line.differeMin;
                    temp.differeMax = line.differeMax;
                    temp.description = line.description;
                    temp.createdDate = line.createdDate;
                    temp.tauxRetardMin = line.tauxRetardMin;
                    temp.tauxRetardMax = line.tauxRetardMax;
                    temp.tauxEpargneMin = line.tauxEpargneMin;
                    temp.lastModifiedDate = line.lastModifiedDate;
                    temp.typeAmortissement = line.typeAmortissement;
                    temp.tauxPenaliteRetard = line.tauxPenaliteRetard;

                    returnList.Add(temp);
                }
                return returnList;
            }
        #endregion

    }
}
