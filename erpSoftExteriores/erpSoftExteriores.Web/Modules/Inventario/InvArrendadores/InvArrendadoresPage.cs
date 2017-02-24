
namespace erpSoftExteriores.Inventario.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Inventario/Arrendadores"), Route("{action=index}")]
    public class InvArrendadoresController : Controller
    {
        [PageAuthorize(Administration.PermissionKeys.Inventario.ArrendadoresPage)]
        public ActionResult Index()
        {
            return View("~/Modules/Inventario/InvArrendadores/InvArrendadoresIndex.cshtml");
        }
    }
}