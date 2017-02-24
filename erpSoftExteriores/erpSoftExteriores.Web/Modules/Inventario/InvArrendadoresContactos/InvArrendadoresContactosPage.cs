
namespace erpSoftExteriores.Inventario.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Inventario/ArrendadoresContactos"), Route("{action=index}")]
    public class InvArrendadoresContactosController : Controller
    {
        [PageAuthorize(Administration.PermissionKeys.Inventario.ArrendadoresPage)]
        public ActionResult Index()
        {
            return View("~/Modules/Inventario/InvArrendadoresContactos/InvArrendadoresContactosIndex.cshtml");
        }
    }
}