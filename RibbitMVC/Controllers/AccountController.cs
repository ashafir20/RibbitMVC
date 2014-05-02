using System;
using System.Web.Mvc;

namespace RibbitMVC.Controllers
{
    public class AccountController : RibbitControllerBase
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logout()
        {
            Security.Logout();

            throw new NotImplementedException();
        }

    }
}
