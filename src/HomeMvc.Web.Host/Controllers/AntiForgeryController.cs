using Microsoft.AspNetCore.Antiforgery;
using HomeMvc.Controllers;

namespace HomeMvc.Web.Host.Controllers
{
    public class AntiForgeryController : HomeMvcControllerBase
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
