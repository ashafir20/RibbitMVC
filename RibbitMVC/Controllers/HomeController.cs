using System;
using System.Web.Mvc;

namespace RibbitMVC.Controllers
{
    public class HomeController : RibbitControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Follow(string username)
        {
            throw new NotImplementedException(username + " followed");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Unfollow(string username)
        {
            throw new NotImplementedException(username + " unfollowed");
        }

        public ActionResult Profiles()
        {
            throw new NotImplementedException();
        }

        public ActionResult Followers()
        {
            throw new NotImplementedException();
        }

        public ActionResult Following()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create()
        {
            throw new NotImplementedException();
        }
    }
}
