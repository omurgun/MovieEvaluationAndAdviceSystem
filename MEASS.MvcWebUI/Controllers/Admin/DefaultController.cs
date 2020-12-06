using System.Web.Mvc;

namespace MEASS.MvcWebUI.Controllers.Admin
{
    public class DefaultController : Controller
    {
        public ActionResult Error()
        {
            return View();
        }
    }
}