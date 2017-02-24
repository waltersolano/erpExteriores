
namespace erpSoftExteriores.Logs.Endpoints
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System.Collections.Generic;
    using System.Data;
    using System.Web.Mvc;
    using MyRepository = Repositories.LogRegistroSimpleRepository;
    using MyRow = Entities.LogRegistroSimpleRow;


    public class LogRegistroSimple
    {        
        public static void CreateLogRegistroSimple(IUnitOfWork uow, long EntityId, string LocalTextPrefix)
        {
            try { 
            System.DateTime localDate = System.DateTime.Now;
            UserDefinition user = (UserDefinition)Authorization.UserDefinition;
            string entityType = LocalTextPrefix; 
            var Log = new MyRow();
            Log.FechaRegistro = localDate;
            Log.UsuarioRegistraId = user.UserId;
            Log.EntityType = entityType;
            Log.EntityId = EntityId;
            var LogsSaveRequest = new SaveRequest<MyRow> { Entity = Log };
            var response = new MyRepository().Create(uow, LogsSaveRequest);
            }
            catch { }
        }

        public static void UpdateLogRegistroSimple(IUnitOfWork uow,  object EntityId, string LocalTextPrefix)
        {
            try{ 
                System.DateTime localDate = System.DateTime.Now;
                UserDefinition user = (UserDefinition)Authorization.UserDefinition;
                string entityType = LocalTextPrefix;
                var fld = MyRow.Fields;
                var listRequest = new ListRequest
                {                
                    ColumnSelection = ColumnSelection.List,
                    EqualityFilter = new Dictionary<string, object>
                    {
                       { fld.EntityType.PropertyName, LocalTextPrefix },
                       { fld.EntityId.PropertyName, EntityId.ToString() }
                    }
                };
                var responseList = new MyRepository().List(uow.Connection, listRequest);
                var retrieveRequest = new RetrieveRequest();
                retrieveRequest.EntityId = responseList.Entities[0].Id;
                var responseRetrieve = new MyRepository().Retrieve(uow.Connection, retrieveRequest);
                responseRetrieve.Entity.FechaModifica = localDate;
                responseRetrieve.Entity.UsuarioModifica = user.UserId;
                //responseRetrieve.Entity.Texto1 = originalValues;
                var LogsUpdateRequest = new SaveRequest<MyRow> { Entity = responseRetrieve.Entity };
                var responseUpdate = new MyRepository().Update(uow, LogsUpdateRequest);
            }
            catch{ }
        }


        public static void DeleteLogRegistroSimple(IUnitOfWork uow, object EntityId, string LocalTextPrefix)
        {
            try
            {
                System.DateTime localDate = System.DateTime.Now;
                UserDefinition user = (UserDefinition)Authorization.UserDefinition;
                string entityType = LocalTextPrefix;
                var fld = MyRow.Fields;
                var listRequest = new ListRequest
                {
                    ColumnSelection = ColumnSelection.List,
                    EqualityFilter = new Dictionary<string, object>
                    {
                       { fld.EntityType.PropertyName, LocalTextPrefix },
                       { fld.EntityId.PropertyName, EntityId.ToString() }
                    }
                };
                var responseList = new MyRepository().List(uow.Connection, listRequest);
                var retrieveRequest = new RetrieveRequest();
                retrieveRequest.EntityId = responseList.Entities[0].Id;
                var responseRetrieve = new MyRepository().Retrieve(uow.Connection, retrieveRequest);
                //responseRetrieve.Entity.FechaModifica = localDate;
                //responseRetrieve.Entity.UsuarioModifica = user.UserId;
                responseRetrieve.Entity.Texto2 = "Deleted by " + user.Username + " on " + localDate;
                var LogsUpdateRequest = new SaveRequest<MyRow> { Entity = responseRetrieve.Entity };
                var responseUpdate = new MyRepository().Update(uow, LogsUpdateRequest);
            }
            catch { }
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyRepository().List(connection, request);
        }
    }
}
