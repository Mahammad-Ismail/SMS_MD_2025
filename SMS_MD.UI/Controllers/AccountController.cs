using Microsoft.AspNetCore.Mvc;
using SMS_MD.Models.Login;

namespace SMS_MD.UI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
      /*  public IActionResult Login(string EmailOrUsername , string Password)
        {
            return View();
        }*/

        [HttpPost]
        public IActionResult Login(UserDto userdto)
        {if (!ModelState.IsValid)
            {
                
            }
                  
            return RedirectToAction("Login");
        }

    }
}
