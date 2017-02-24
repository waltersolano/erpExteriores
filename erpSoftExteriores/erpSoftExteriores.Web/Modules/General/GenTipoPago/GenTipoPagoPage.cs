namespace erpSoftExteriores.General.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("General/TipoPago"), Route("{action=index}")]
    public class GenTipoPagoController : Controller
    {
        [PageAuthorize("MantenimientoGeneral")]
        public ActionResult Index()
        {
            return View("~/Modules/General/GenTipoPago/GenTipoPagoIndex.cshtml");
        }
    }
}