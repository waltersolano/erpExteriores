


namespace erpSoftExteriores.General.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("General/GenDivisionesAdministrativasN3"), Route("{action=index}")]
    public class GenDivisionesAdministrativasN3Controller : Controller
    {
        [PageAuthorize(Administration.PermissionKeys.PaginaDivisionAdministrativaN3)]
        public ActionResult Index()
        {
            return View("~/Modules/General/GenDivisionesAdministrativasN3/GenDivisionesAdministrativasN3Index.cshtml");
        }
    }
}