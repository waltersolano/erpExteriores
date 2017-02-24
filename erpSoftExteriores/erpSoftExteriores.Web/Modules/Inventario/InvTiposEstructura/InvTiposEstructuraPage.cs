
namespace erpSoftExteriores.Inventario.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Inventario/TiposEstructura"), Route("{action=index}")]
    public class InvTiposEstructuraController : Controller
    {
        [PageAuthorize(Administration.PermissionKeys.Inventario.EstructurasPage)]
        public ActionResult Index()
        {
            return View("~/Modules/Inventario/InvTiposEstructura/InvTiposEstructuraIndex.cshtml");
        }
    }
}