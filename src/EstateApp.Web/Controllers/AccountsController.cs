using System;
using EstateApp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstateApp.Web.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            if (!ModelState.IsValid) return View();
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (!ModelState.IsValid) return View();
            throw new NotImplementedException();
        }
    }
}