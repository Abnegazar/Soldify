using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.GESTION_CREDIT_DataSetTableAdapters;

namespace Business.ClassClients
{
    class PersonneMorale
    {
        #region Champs
        #region Elémentaires
            private int idPersonne;
            private string raisonSociale;
            private string ville;
            private string pays;
            private string mail;
            private string tel1;
            private string tel2;
            private string createdBy;
            private System.DateTime createdDate;
            private System.DateTime lastModifiedDate;
            private bool deleted;
            private bool updatable;
        #endregion
        #endregion

        #region Propriétés
        #region Elémentaires
            public int IdPersonne
            {
                get
                {
                    return this.idPersonne;
                }
                set
                {
                    this.idPersonne = value;
                }
            }
            public string RaisonSociale
            {
                get
                {
                    return this.raisonSociale;
                }
                set
                {
                    this.raisonSociale = value;
                }
            }
            public string Ville
            {
                get
                {
                    return this.ville;
                }
                set
                {
                    this.ville = value;
                }
            }
            public string Pays
            {
                get
                {
                    return this.pays;
                }
                set
                {
                    this.pays = value;
                }
            }
            public string Mail
            {
                get
                {
                    return this.mail;
                }
                set
                {
                    this.mail = value;
                }
            }
            public string Tel1
            {
                get
                {
                    return this.tel1;
                }
                set
                {
                    this.tel1 = value;
                }
            }
            public string Tel2
            {
                get
                {
                    return this.tel2;
                }
                set
                {
                    this.tel2 = value;
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
            public static T_PersonneMoraleTableAdapter t_PersonneMoraleTableAdapter = new T_PersonneMoraleTableAdapter();
        #endregion

        #region Méthodes
            public string Save()
            {
                string message = string.Empty;
                message = (String)t_PersonneMoraleTableAdapter.insert_PersonneMorale(ref message, raisonSociale, ville, pays, mail, tel1, tel2, createdBy);
                return message;
            }
        #endregion
    }
}
