using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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

        [Route("register")]
        public ActionResult Register()
        {
            return View();
        }
    }
}