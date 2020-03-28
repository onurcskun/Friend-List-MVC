using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_PROJECT.Models;

namespace MVC_PROJECT.Controllers {
    public class FriendController : Controller {
        // GET: Friend
        Friends db = new Friends();

        [HttpGet]
        public ActionResult Detail(int id) {
            var friend = db.FriendsDB.FirstOrDefault(p => p.id == id);

            return View(friend);
        }

        [HttpGet]
        public ActionResult Edit(int id) {
            var friend = db.FriendsDB.FirstOrDefault(p => p.id == id);
            return View(friend);
        }

        [HttpPost]
        public ActionResult Edit(Friend newFriend) {
            db.Entry(newFriend).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Detail/" + newFriend.id);
        }

        [HttpGet]
        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Friend newFriend) {
            db.FriendsDB.Add(newFriend);
            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public ActionResult Delete(Friend friend) {
            db.Entry(friend).State = EntityState.Modified;
            db.FriendsDB.Remove(friend);
            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
