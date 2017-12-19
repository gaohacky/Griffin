using Griffin.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Griffin.Web.Controllers
{
    public class AboutController : GriffinControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}