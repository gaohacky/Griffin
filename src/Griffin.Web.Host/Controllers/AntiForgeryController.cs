using Griffin.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace Griffin.Web.Host.Controllers
{
    public class AntiForgeryController : GriffinControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}