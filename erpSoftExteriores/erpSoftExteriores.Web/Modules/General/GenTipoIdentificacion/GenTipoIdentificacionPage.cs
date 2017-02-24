

namespace erpSoftExteriores.General.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("General/TipoIdentificacion"), Route("{action=index}")]
    public class GenTipoIdentificacionController : Controller
    {
        [PageAuthorize("MantenimientoGeneral")]
        public ActionResult Index()
        {
            return View("~/Modules/General/GenTipoIdentificacion/GenTipoIdentificacionIndex.cshtml");
        }
    }
}