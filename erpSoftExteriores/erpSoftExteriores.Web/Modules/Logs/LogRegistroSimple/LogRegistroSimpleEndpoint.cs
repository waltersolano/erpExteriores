
namespace erpSoftExteriores.Logs.Endpoints
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Web.Mvc;
    using MyRepository = Repositories.LogRegistroSimpleRepository;
    using MyRow = Entities.LogRegistroSimpleRow;

    [RoutePrefix("Services/Logs/LogRegistroSimple"), Route("{action}")]
    [ConnectionKey("Default"), ServiceAuthorize("Administration")]
    public class LogRegistroSimpleController : ServiceEndpoint
    {
        [HttpPost]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Create(uow, request);
        }

        [HttpPost]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Update(uow, request);
        }
 
        [HttpPost]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyRepository().Delete(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyRepository().List(connection, request);
        }

        public ListResponse<MyRow> SList(IDbConnection connection, ListRequest request)
        {
            string slocalTextPrefix = (((ValueCriteria)((BinaryCriteria)((BinaryCriteria)request.Criteria).LeftOperand).RightOperand).Value).ToString();
            string rowString = "erpSoftExteriores." + slocalTextPrefix.Replace(".", ".Entities.") + "Row";
            var tableName = ((Row)(Activator.CreateInstance(Type.GetType(rowString)))).Table;

            var listRequest = new ListRequest
            {                
                EqualityFilter = new Dictionary<string, object>
                {
                    { MyRow.Fields.EntityType.PropertyName, tableName },
                    { MyRow.Fields.EntityId.PropertyName, ((ValueCriteria)((BinaryCriteria)((BinaryCriteria)request.Criteria).RightOperand).RightOperand).Value }
                }
            };
            //Query with new listrequest;

            var response = new MyRepository().List(connection, listRequest);
            //UsuarioRegistraUsername
            try
            {
                var retrieveRequest1 = new RetrieveRequest();
                retrieveRequest1.EntityId = response.Entities[0].UsuarioRegistraId;
                var responseRetrieve1 = new Administration.Repositories.UserRepository().Retrieve(connection, retrieveRequest1);
                response.Entities[0].UsuarioRegistraUsername = responseRetrieve1.Entity.Username;
            }
            catch{}

            //UsuarioModificaUsername
            try
            { 
                var retrieveRequest2 = new RetrieveRequest();
                retrieveRequest2.EntityId = response.Entities[0].UsuarioModifica;
                var responseRetrieve2 = new Administration.Repositories.UserRepository().Retrieve(connection, retrieveRequest2);
                response.Entities[0].UsuarioModificaUsername = responseRetrieve2.Entity.Username;
            }
            catch{}
            return response;
        }


    }
}
