using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RibbitMVC.Data.RibbitDatabase.Concrete;
using RibbitMVC.Models;
using RibbitMVC.Services;

namespace RibbitMVC.Controllers
{
    public class RibbitControllerBase : Controller
    {
        public User CurrentUser { get; private set; }
        public IUserService Users { get; private set; }
        public ISecurityService Security { get; private set; }

        public RibbitControllerBase()
        {
            Users = new UserService(new Context());
            Security = new SecurityService(Users);
            CurrentUser = Security.GetCurrentUser();
        }
    }
}
