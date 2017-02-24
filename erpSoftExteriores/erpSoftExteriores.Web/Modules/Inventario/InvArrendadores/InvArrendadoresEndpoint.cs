
namespace erpSoftExteriores.Inventario.Endpoints
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System.Data;
    using System.Web.Mvc;

    using MyRepository = Repositories.InvArrendadoresRepository;
    using MyRow = Entities.InvArrendadoresRow;

    [RoutePrefix("Services/Inventario/InvArrendadores"), Route("{action}")]
    [ConnectionKey("Default"), ServiceAuthorize("AdministracionDeInventario")]
    public class InvArrendadoresController : ServiceEndpoint
    {
        /******/
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request)
        {
            var columns = typeof(Columns.InvArrendadoresColumns);
            var name = "Arrendadores_";

            var data = List(connection, request).Entities;
            var report = new Serenity.Reporting.DynamicDataReport(data, request.IncludeColumns, columns);
            var bytes = new ReportRepository().Render(report);
            return Serenity.Web.ExcelContentResult.Create(bytes, name + System.DateTime.Now.ToString("ddMMyyyy_HHmmss") + ".xlsx");
        }

        [HttpPost]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            SaveResponse saveResponse = new MyRepository().Create(uow, request);
            Logs.Endpoints.LogRegistroSimple.CreateLogRegistroSimple(uow, (long)saveResponse.EntityId, MyRow.Fields.TableName);
            return saveResponse;
        }

        [HttpPost]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            SaveResponse saveResponse = new MyRepository().Update(uow, request);
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

    }
}
