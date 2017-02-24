

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Logs/LogRegistroSimple", typeof(erpSoftExteriores.Logs.Pages.LogRegistroSimpleController))]

namespace erpSoftExteriores.Logs.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Logs/LogRegistroSimple"), Route("{action=index}")]
    public class LogRegistroSimpleController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/Logs/LogRegistroSimple/LogRegistroSimpleIndex.cshtml");
        }
    }
}