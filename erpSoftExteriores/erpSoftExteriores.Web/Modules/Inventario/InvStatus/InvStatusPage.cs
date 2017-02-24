


namespace erpSoftExteriores.Inventario.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Inventario/Status"), Route("{action=index}")]
    public class InvStatusController : Controller
    {
        [PageAuthorize("AdministracionDeInventario")]
        public ActionResult Index()
        {
            return View("~/Modules/Inventario/InvStatus/InvStatusIndex.cshtml");
        }
    }
}