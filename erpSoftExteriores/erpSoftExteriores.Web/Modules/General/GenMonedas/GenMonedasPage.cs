



namespace erpSoftExteriores.General.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("General/Monedas"), Route("{action=index}")]
    public class GenMonedasController : Controller
    {
        [PageAuthorize("MantenimientoGeneral")]
        public ActionResult Index()
        {
            return View("~/Modules/General/GenMonedas/GenMonedasIndex.cshtml");
        }
    }
}