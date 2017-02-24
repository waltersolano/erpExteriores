
namespace erpSoftExteriores.Inventario.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Inventario/CategoriasSoporteEstructura"), Route("{action=index}")]
    public class InvCategoriasSoporteEstructuraController : Controller
    {
        [PageAuthorize(Administration.PermissionKeys.Inventario.EstructurasPage)]
        public ActionResult Index()
        {
            return View("~/Modules/Inventario/InvCategoriasSoporteEstructura/InvCategoriasSoporteEstructuraIndex.cshtml");
        }
    }
}