using System;
using System.Web.Mvc;

namespace RibbitMVC.Controllers
{
    public class ProfileController : RibbitControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit()
        {
            throw new NotImplementedException();
        }
    }
}
