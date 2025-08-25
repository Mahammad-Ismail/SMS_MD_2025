using Microsoft.AspNetCore.Mvc;

namespace SMS_MD.UI.Controllers
{
    public class BaseController : Controller
    {
        public DateTime GetDateTime()
        {
            return DateTime.UtcNow;
        }
        public IActionResult NotFound()
        {
            return View();
        }
        public IActionResult Exception()
        {
            return View();
        }
    }
}
