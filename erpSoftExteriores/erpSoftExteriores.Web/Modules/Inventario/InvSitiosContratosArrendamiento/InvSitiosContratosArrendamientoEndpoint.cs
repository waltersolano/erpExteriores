
namespace erpSoftExteriores.Inventario.Endpoints
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Data;
    using System.Web.Mvc;
    using MyRepository = Repositories.InvSitiosContratosArrendamientoRepository;
    using MyRow = Entities.InvSitiosContratosArrendamientoRow;

    [RoutePrefix("Services/Inventario/InvSitiosContratosArrendamiento"), Route("{action}")]
    [ConnectionKey("Default"), ServiceAuthorize("AdministracionDeInventario")]
    public class InvSitiosContratosArrendamientoController : ServiceEndpoint
    {
        /******/
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request)
        {
            var columns = typeof(Columns.InvArrendadoresColumns);
            var name = "SitioContratos_";

            var data = List(connection, request).Entities;
            var report = new Serenity.Reporting.DynamicDataReport(data, request.IncludeColumns, columns);
            var bytes = new ReportRepository().Render(report);
            return Serenity.Web.ExcelContentResult.Create(bytes, name + System.DateTime.Now.ToString("ddMMyyyy_HHmmss") + ".xlsx");
        }

        [HttpPost]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            UserDefinition user = (UserDefinition)Authorization.UserDefinition;
            request.Entity.NumeroContrato = "...";
            request.Entity.UserRegistraId = user.UserId;
            request.Entity.EstaAprobado = false;
            request.Entity.TipoContratoId = 1;

            

            ValidateNoOverlappingDates(request, uow);



            SaveResponse saveResponse = new MyRepository().Create(uow, UpdateArrendadorId(request, uow.Connection));
            Logs.Endpoints.LogRegistroSimple.CreateLogRegistroSimple(uow, (long)saveResponse.EntityId, MyRow.Fields.TableName);

            return UpdateCodigo(request, uow, saveResponse);
        }




        public Boolean ValidateNoOverlappingDates(SaveRequest<MyRow> request, IUnitOfWork uow) {

            var siteRetrieveRequest = new RetrieveRequest();
            siteRetrieveRequest.EntityId = request.Entity.SitioId;
            var siteResponseRetrieve = new Inventario.Repositories.InvSitiosRepository().Retrieve(uow.Connection, siteRetrieveRequest);
            if (siteResponseRetrieve.Entity.ContratoId != null)
            {
                var contratoRetrieveRequest = new RetrieveRequest();
                contratoRetrieveRequest.EntityId = siteResponseRetrieve.Entity.ContratoId;
                var contratoResponseRetrieve = new Inventario.Repositories.InvSitiosRepository().Retrieve(uow.Connection, contratoRetrieveRequest);

                if (1>2) {



                }

            }

            return true;
        }



        [HttpPost]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            
            var retrieveRequest = new RetrieveRequest();
            retrieveRequest.EntityId = request.EntityId;
            var savedState = new MyRepository().Retrieve(uow.Connection, retrieveRequest);

            //Avoid set or modify value for "EstaAprobado field" on Update, this field should be updated from another method.. by bussiness rule
            if (!savedState.Entity.EstaAprobado == true) {
                request.Entity.EstaAprobado = false;
            }

            //Check

            SaveResponse saveResponse = new MyRepository().Update(uow, UpdateArrendadorId(request, uow.Connection));
            Logs.Endpoints.LogRegistroSimple.UpdateLogRegistroSimple(uow, saveResponse.EntityId, MyRow.Fields.TableName);

            /*

            var error = new ServiceError();
             error.Message = "Mensajes...";
             error.Arguments = "warning";
            var saveResponse2 = new SaveResponse();
           
            saveResponse2.Error = error;
                 
            saveResponse.Error = error;

            */
             return saveResponse;
        }



        [HttpPost]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            DeleteResponse deleteResponse = new MyRepository().Delete(uow, request);
            Logs.Endpoints.LogRegistroSimple.DeleteLogRegistroSimple(uow, request.EntityId, MyRow.Fields.TableName);
            return deleteResponse;
        }


        /********/

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyRepository().List(connection, request);
        }


        /*************************************************************/


        public SaveRequest<MyRow> UpdateArrendadorId(SaveRequest<MyRow> request, IDbConnection connection)
        {
            var sitioId = request.Entity.SitioId;
            var retrieveRequest = new RetrieveRequest();
            retrieveRequest.EntityId = sitioId;
            var responseRetrieve = new Inventario.Repositories.InvSitiosRepository().Retrieve(connection, retrieveRequest);
            request.Entity.ArrendadorId = responseRetrieve.Entity.ArrendadorId;
            return request;
        }

        private SaveResponse UpdateCodigo(SaveRequest<MyRow> request, IUnitOfWork uow, SaveResponse saveResponse)
        {
            var codigoSitioConfig = Newtonsoft.Json.JsonConvert.DeserializeObject<erpSoftExteriores.AppSettingsHelper.codeItems>(
                    System.Configuration.ConfigurationManager.AppSettings["erpSoft:ArrendadorContratoCodigo"].TrimToNull() ?? "{}", JsonSettings.Tolerant);

            if (codigoSitioConfig.AutoGenerar == true)
            {
                var prefix = !System.String.IsNullOrEmpty(codigoSitioConfig.PrefijoCodigo) ? codigoSitioConfig.PrefijoCodigo : "";
                var year = codigoSitioConfig.IncludeYear == true ? "-" + System.DateTime.Now.Year.ToString() + "-" : "";
                prefix = prefix + year;
                var digitos = codigoSitioConfig.digits > 0 ? (int)codigoSitioConfig.digits : 7;

                request.Entity.NumeroContrato = prefix + saveResponse.EntityId.ToString().PadLeft(digitos - prefix.Length, '0');
                SaveResponse saveResponse2 = new MyRepository().Update(uow, request);
                return saveResponse2;
            }
            else
            {
                return saveResponse;
            }
        }


    }
}
