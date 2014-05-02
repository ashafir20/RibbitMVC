using System;
using System.Web.Mvc;

namespace RibbitMVC.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index(string username)
        {
            throw new NotImplementedException("list for " + username);
        }

        public ActionResult Followers(string username)
        {
            throw new NotImplementedException("followers for " + username);
        }

        public ActionResult Following(string username)
        {
            throw new NotImplementedException("following for " + username);
        }

    }
}
