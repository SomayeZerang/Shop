using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Shop.Service.Dtos.User;
using Shop.Service.Identity;

namespace Shop.Site.Controllers
{
    public class AccountController : Controller
    {
        private readonly IApplicationUserManager _userManager;

        public AccountController(IApplicationUserManager userManager)
        {
            _userManager = userManager;
        }

        [Route("register", Name = "GetRegisterUser")]
        public ActionResult Register()
        {
            return View();
        }

        [Route("register")]
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterUserDto user)
        {
            await _userManager.RegisterAsync(user);

            return RedirectToRoute("GetRegisterUser");
        }
    }
}