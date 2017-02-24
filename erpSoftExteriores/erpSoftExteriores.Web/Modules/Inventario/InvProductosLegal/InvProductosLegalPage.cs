


namespace erpSoftExteriores.Inventario.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Inventario/ProductosLegal"), Route("{action=index}")]
    public class InvProductosLegalController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/Inventario/InvProductosLegal/InvProductosLegalIndex.cshtml");
        }
    }
}