
namespace erpSoftExteriores.Inventario.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Inventario/Sitios"), Route("{action=index}")]
    public class InvSitiosController : Controller
    {
        [PageAuthorize(Administration.PermissionKeys.Inventario.SitiosPage)]
        public ActionResult Index()
        {
            return View("~/Modules/Inventario/InvSitios/InvSitiosIndex.cshtml");
        }
    }
}