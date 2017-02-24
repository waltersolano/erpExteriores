


namespace erpSoftExteriores.General.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("General/DivisionesAdministrativas/Nivel1"), Route("{action=index}")]
    public class GenDivisionesAdministrativasN1Controller : Controller
    {
        [PageAuthorize(Administration.PermissionKeys.PaginaDivisionAdministrativaN1)]
        public ActionResult Index()
        {
            return View("~/Modules/General/GenDivisionesAdministrativasN1/GenDivisionesAdministrativasN1Index.cshtml");
        }
    }
}