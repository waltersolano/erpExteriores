


namespace erpSoftExteriores.General.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("General/DivisionesAdministrativas/Nivel2"), Route("{action=index}")]
    public class GenDivisionesAdministrativasN2Controller : Controller
    {
        [PageAuthorize(Administration.PermissionKeys.PaginaDivisionAdministrativaN2)]
        public ActionResult Index()
        {
            return View("~/Modules/General/GenDivisionesAdministrativasN2/GenDivisionesAdministrativasN2Index.cshtml");
        }
    }
}