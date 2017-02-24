


namespace erpSoftExteriores.General.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("General/GenDivisionesAdministrativasN4"), Route("{action=index}")]
    public class GenDivisionesAdministrativasN4Controller : Controller
    {
        [PageAuthorize(Administration.PermissionKeys.PaginaDivisionAdministrativaN4)]
        public ActionResult Index()
        {
            return View("~/Modules/General/GenDivisionesAdministrativasN4/GenDivisionesAdministrativasN4Index.cshtml");
        }
    }
}