using Microsoft.AspNetCore.Antiforgery;
using AbpTestPlus.Controllers;

namespace AbpTestPlus.Web.Host.Controllers
{
    public class AntiForgeryController : AbpTestPlusControllerBase
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
