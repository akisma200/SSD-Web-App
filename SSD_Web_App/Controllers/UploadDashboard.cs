
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SSD_Web_App.Controllers
{
    [Authorize]
    public class UploadDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        // Andy - Make sure AFT is checked to prevent CSRF
        //[ValidateAntiForgeryToken]
        // From Form attribute: https://docs.microsoft.com/en-us/aspnet/web-api/overview/formats-and-model-binding/parameter-binding-in-aspnet-web-api
        public IActionResult Analyse([FromForm]string code)
        {
            ViewData["Response"] = code;

            return View();
        }
    }
}
