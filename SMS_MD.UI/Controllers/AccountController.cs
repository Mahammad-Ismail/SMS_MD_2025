using Microsoft.AspNetCore.Mvc;

namespace SMS_MD.UI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
