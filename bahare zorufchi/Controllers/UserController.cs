using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using bahare_zorufchi.Models;


namespace bahare_zorufchi.Controllers
{
    public class UserController : Controller
    {
        okalaDBEntities db = new okalaDBEntities();

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(User registerUser)
        {

            if (ModelState.IsValid)
            {
                if (db.Users.Any(a => a.UserName == registerUser.UserName) == true)
                {
                    ModelState.AddModelError("", "این نام کاربری قبلا ثبت شده است");
                    return View();
                }

                else
                {
                    registerUser.RoleID = 2;
                    db.Users.Add(registerUser);
                    db.SaveChanges();
                    return RedirectToAction("Login");
                }


            }

            return View();
        }


        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(string txtUsername, string txtPassword)
        {

            if (ModelState.IsValid)
            {
                if (db.Users.Any(a => a.UserName == txtUsername && a.Password == txtPassword)==true)
                {
                    FormsAuthentication.SetAuthCookie(txtUsername, false);
                    return Redirect(FormsAuthentication.DefaultUrl);
                }
                else
                {
                    ModelState.AddModelError("", "نام کاربری یا رمز عبور اشتباه است");
                    return View();
                }

            }
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }




    }
}
