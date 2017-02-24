


namespace erpSoftExteriores.General.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("General/GenDivisionesAdministrativasN5"), Route("{action=index}")]
    public class GenDivisionesAdministrativasN5Controller : Controller
    {
        [PageAuthorize(Administration.PermissionKeys.PaginaDivisionAdministrativaN5)]
        public ActionResult Index()
        {
            return View("~/Modules/General/GenDivisionesAdministrativasN5/GenDivisionesAdministrativasN5Index.cshtml");
        }
    }
}