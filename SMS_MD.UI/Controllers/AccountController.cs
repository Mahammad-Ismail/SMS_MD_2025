using Microsoft.AspNetCore.Mvc;
using SMS_MD.Models.Login;
using SMS_MD.Services;
using SMS_MD.Services.Interfces;

namespace SMS_MD.UI.Controllers
{
    public class AccountController : Controller
    { 
        IAppUserService _userService;
        public AccountController(IAppUserService appUserService)
        {
            _userService = appUserService;
        }
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
        {if (ModelState.IsValid)
            {
                //AppUserService _userService = new AppUserService();
                bool isValidUser = _userService.ValidateUser(userdto);
                if (isValidUser)
                {
                    return RedirectToAction("Index","Home");

                }
              }
                  
            return View(User);
        }

    }
}
