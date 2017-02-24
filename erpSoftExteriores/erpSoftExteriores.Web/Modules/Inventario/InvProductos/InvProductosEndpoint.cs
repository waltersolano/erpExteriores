
namespace erpSoftExteriores.Inventario.Endpoints
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System.Data;
    using System.Web.Mvc;
    using MyRepository = Repositories.InvProductosRepository;
    using MyRow = Entities.InvProductosRow;

    [RoutePrefix("Services/Inventario/InvProductos"), Route("{action}")]
    [ConnectionKey("Default"), ServiceAuthorize("AdministracionDeInventario")]
    public class InvProductosController : ServiceEndpoint
    {
        /******/
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request)
        {
            var columns = typeof(Columns.InvProductosColumns);
            var name = "Productos_";

            var data = List(connection, request).Entities;
            var report = new Serenity.Reporting.DynamicDataReport(data, request.IncludeColumns, columns);
            var bytes = new ReportRepository().Render(report);
            return Serenity.Web.ExcelContentResult.Create(bytes, name + System.DateTime.Now.ToString("ddMMyyyy_HHmmss") + ".xlsx");
        }

        [HttpPost]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {

            SaveResponse saveResponse = new MyRepository().Create(uow, ValidateIluminacion(request));
            Logs.Endpoints.LogRegistroSimple.CreateLogRegistroSimple(uow, (long)saveResponse.EntityId, MyRow.Fields.TableName);

            return UpdateCodigo(request, uow, saveResponse);
        }

        [HttpPost]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            SaveResponse saveResponse = new MyRepository().Update(uow, ValidateIluminacion(request));
            Logs.Endpoints.LogRegistroSimple.UpdateLogRegistroSimple(uow, saveResponse.EntityId, MyRow.Fields.TableName);
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


        public SaveRequest<MyRow> ValidateIluminacion(SaveRequest<MyRow> request) {

            if (request.Entity.TieneIluminacion == true)
            {
                if (request.Entity.PrecioIncluyeIluminacion == true)
                {
                    request.Entity.PrecioIluminacion = null;
                    request.Entity.MonedaIluminacionId = null;

                }
                else if (request.Entity.PrecioIluminacion > 0 && request.Entity.MonedaIluminacionId > 0)
                {
                    request.Entity.PrecioIncluyeIluminacion = null;
                }
                else
                {
                    request.Entity.TieneIluminacion = false;
                }
            }
            return request;
        }

        public SaveResponse UpdateCodigo(SaveRequest<MyRow> request, IUnitOfWork uow, SaveResponse saveResponse)
        {
            var codigoSitioConfig = Newtonsoft.Json.JsonConvert.DeserializeObject<erpSoftExteriores.AppSettingsHelper.codeItems>(
                    System.Configuration.ConfigurationManager.AppSettings["erpSoft:ProductoCodigo"].TrimToNull() ?? "{}", JsonSettings.Tolerant);

            if (codigoSitioConfig.AutoGenerar == true)
            {
                var prefix = !System.String.IsNullOrEmpty(codigoSitioConfig.PrefijoCodigo) ? codigoSitioConfig.PrefijoCodigo : "";
                var year = codigoSitioConfig.IncludeYear == true ? "-" + System.DateTime.Now.Year.ToString() + "-" : "";
                prefix = prefix + year;
                var digitos = codigoSitioConfig.digits > 0 ? (int)codigoSitioConfig.digits : 7;

                request.Entity.CodigoProducto = prefix + saveResponse.EntityId.ToString().PadLeft(digitos - prefix.Length, '0');
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
