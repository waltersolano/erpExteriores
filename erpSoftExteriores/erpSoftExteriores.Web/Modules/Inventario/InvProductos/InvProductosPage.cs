

namespace erpSoftExteriores.Inventario.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Inventario/Productos"), Route("{action=index}")]
    public class InvProductosController : Controller
    {
        [PageAuthorize(Administration.PermissionKeys.Inventario.ProductosPage)]
        public ActionResult Index()
        {
            return View("~/Modules/Inventario/InvProductos/InvProductosIndex.cshtml");
        }
    }
}