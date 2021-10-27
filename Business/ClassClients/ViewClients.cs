using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.GESTION_CREDIT_DataSetTableAdapters;

namespace Business.ClassClients
{
    class ViewClients
    {
        #region Champs
        #region Elementaire
            private int idClient;
            private string typeClient;
            private int idPersonne;
            private string denomination;
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
            public string Denomination
            {
                get
                {
                    return this.denomination;
                }
                set
                {
                    this.denomination = value;
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
            public static GESTION_CREDIT_DataSet.V_ClientsDataTable v_ClientsDataTable = new GESTION_CREDIT_DataSet.V_ClientsDataTable();
            public static V_ClientsTableAdapter v_ClientsTableAdapter = new V_ClientsTableAdapter();
        #endregion

        #region Methodes
            public List<ViewClients> Find()
            {
                List<ViewClients> returnList = new List<ViewClients>();
                ViewClients temp = new ViewClients();
                v_ClientsDataTable = v_ClientsTableAdapter.select_Client(null, null, null, null, null, null, null, null, null, null, null, false, null);

                foreach (GESTION_CREDIT_DataSet.V_ClientsRow line in v_ClientsDataTable)
                {
                    temp.idClient = line.idClient;
                    temp.typeClient = line.typeClient;
                    temp.IdPersonne = line.idPersonne;
                    temp.denomination = line.denomination;
                    temp.ville = line.ville;
                    temp.pays = line.pays;
                    temp.tel1 = line.tel1;
                    temp.tel2 = line.tel2;
                    temp.mail = line.mail;
                    temp.createdBy = line.createdBy;
                    temp.CreatedDate = line.createdDate;
                    temp.lastModifiedDate = line.lastModifiedDate;
                    temp.deleted = line.deleted;
                    temp.updatable = line.updatable;

                    returnList.Add(temp);
                }

                return returnList;

            }

            public List<ViewClients> FindByDenomination(string denomination)
            {
                List<ViewClients> returnList = new List<ViewClients>();
                ViewClients temp = new ViewClients();
                v_ClientsDataTable = v_ClientsTableAdapter.select_Client(null, denomination, null, null, null, null, null, null, null, null, null, false, null);

                foreach (GESTION_CREDIT_DataSet.V_ClientsRow line in v_ClientsDataTable)
                {
                    temp.idClient = line.idClient;
                    temp.typeClient = line.typeClient;
                    temp.IdPersonne = line.idPersonne;
                    temp.denomination = line.denomination;
                    temp.ville = line.ville;
                    temp.pays = line.pays;
                    temp.tel1 = line.tel1;
                    temp.tel2 = line.tel2;
                    temp.mail = line.mail;
                    temp.createdBy = line.createdBy;
                    temp.CreatedDate = line.createdDate;
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
