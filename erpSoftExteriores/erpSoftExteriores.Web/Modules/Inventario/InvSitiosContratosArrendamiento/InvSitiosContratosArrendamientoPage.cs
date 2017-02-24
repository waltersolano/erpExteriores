


namespace erpSoftExteriores.Inventario.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Inventario/ContratosArrendamiento"), Route("{action=index}")]
    public class InvSitiosContratosArrendamientoController : Controller
    {
        [PageAuthorize("AdministracionDeInventario")]
        public ActionResult Index()
        {
            return View("~/Modules/Inventario/InvSitiosContratosArrendamiento/InvSitiosContratosArrendamientoIndex.cshtml");
        }
    }
}