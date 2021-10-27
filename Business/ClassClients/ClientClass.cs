using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.GESTION_CREDIT_DataSetTableAdapters;

namespace Business.ClassClients
{
    class ClientClass
    {

        #region Champs
        #region Elementaires
            private int idClient;
            private int idPersonne;
            private string typeClient;
        #endregion

        #region Objets
        #endregion
        #endregion

        #region Propriétés
        #region Elementaires
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
            public String TypeClient
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
        #endregion

        #region Objets
        #endregion
        #endregion

        #region Variables
            public static T_ClientTableAdapter adClient = new T_ClientTableAdapter();
            public static GESTION_CREDIT_DataSet.T_ClientDataTable t_ClientDataTable = new GESTION_CREDIT_DataSet.T_ClientDataTable();
        #endregion

        #region Méthodes
            public String Update()
            {
                throw new NotImplementedException();   
            }
        #endregion

    }
}
