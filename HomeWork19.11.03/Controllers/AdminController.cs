using DataAccess;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork19._11._03.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Users()
        {
            using(var context = new UserContext())
            {
                return View(context.Users.ToList());
            }
        }

        public ActionResult User(Guid id)
        {
            using (var context = new UserContext())
            {
                return View(context.Users.Where(u => u.Id == id).FirstOrDefault());
            }
        }
    }
}