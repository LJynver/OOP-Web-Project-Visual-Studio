using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OOP_Web_Project_Jover.Controllers
{
    public class UserAuthController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult RegisterForm(FormCollection fc)
        {
            String fname    = Convert.ToString(fc["FirstName"]);
            String lname    = Convert.ToString(fc["LastName"]);
            String email    = Convert.ToString(fc["EmailAdd"]);
            String password = Convert.ToString(fc["Password"]);

            UscAccountsEntities1 usca   = new UscAccountsEntities1();
            User                 users  = new User();

            users.FirstName     = fname;
            users.LastName      = lname;
            users.Email         = email;
            users.Password      = password;

            usca.Users.Add(users);
            usca.SaveChanges();

            return View();
        }
    }
}