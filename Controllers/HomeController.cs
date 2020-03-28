using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_PROJECT.Models;

namespace MVC_PROJECT.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            Friends db = new Friends();

            var list = db.FriendsDB.ToList();

            return View(list);
        }
    }
}
