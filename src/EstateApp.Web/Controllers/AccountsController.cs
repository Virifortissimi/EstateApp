using Microsoft.AspNetCore.Mvc;

namespace EstateApp.Web.Controllers {
    public class AccountsController : Controller {
        public IActionResult Register () {
            return View ();
        }

        public IActionResult Login () {
            return View ();
        }
    }
}