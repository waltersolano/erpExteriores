

namespace erpSoftExteriores.General.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("General/Rutas"), Route("{action=index}")]
    public class GenRutasController : Controller
    {
        [PageAuthorize("MantenimientoGeneral")]
        public ActionResult Index()
        {
            return View("~/Modules/General/GenRutas/GenRutasIndex.cshtml");
        }
    }
}