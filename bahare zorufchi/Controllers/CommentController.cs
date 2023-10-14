using bahare_zorufchi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bahare_zorufchi.Controllers
{
    public class CommentController : Controller
    {

        okalaDBEntities db = new okalaDBEntities();

        

        public ActionResult Accept(int id)
        {
            comment commentToChange = db.comments.Find(id);
            commentToChange.IsAccepted = true;

            db.Entry(commentToChange).State = EntityState.Modified;

            db.SaveChanges();

            return RedirectToAction("Details", "kala", new { id = commentToChange.kalaID });
        }

       

        public ActionResult Reject(int id)
        {
            comment commentToChange = db.comments.Find(id);
            commentToChange.IsAccepted = false;

            db.Entry(commentToChange).State = EntityState.Modified;

            db.SaveChanges();

            return RedirectToAction("Details", "News", new { id = commentToChange.kalaID });

        }

        

        public ActionResult Accept1(int id)
        {
            comment commentToChange = db.comments.Find(id);
            commentToChange.IsAccepted = true;

            db.Entry(commentToChange).State = EntityState.Modified;

            db.SaveChanges();

            return RedirectToAction("CommentManagement");
        }

      

        public ActionResult Reject1(int id)
        {
            comment commentToChange = db.comments.Find(id);
            commentToChange.IsAccepted = false;

            db.Entry(commentToChange).State = EntityState.Modified;

            db.SaveChanges();

            return RedirectToAction("CommentManagement");

        }


        
        public ActionResult CommentManagement()
        {
            var commentList = db.comments.OrderByDescending(p => p.ID);
            return View(commentList);
        }



        // GET: Comment
        public ActionResult Index()
        {
            return View();
        }

        // GET: Comment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Comment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Comment/Create
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

        // GET: Comment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Comment/Edit/5
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

       

        // GET: Comment/Delete/5
        public ActionResult Delete(int id)
        {
            comment cmt = db.comments.Find(id);
            if (cmt == null)
            {
                return HttpNotFound();
            }
            return View(cmt);
        }





        
        // POST: Comment/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
           comment cmt = db.comments.Find(id);
            db.comments.Remove(cmt);
            db.SaveChanges();
            return RedirectToAction("CommentManagement");
        }













    }
}
