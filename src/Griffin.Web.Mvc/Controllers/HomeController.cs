using Abp.AspNetCore.Mvc.Authorization;
using Griffin.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Griffin.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : GriffinControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}