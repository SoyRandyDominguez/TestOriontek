using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace TestOriontec.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TestOriontecControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}