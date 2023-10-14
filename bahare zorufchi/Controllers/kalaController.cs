using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bahare_zorufchi.Models;
using System.IO;
using System.Data.Entity;


namespace bahare_zorufchi.Controllers
{
    public class kalaController : Controller
    {
        okalaDBEntities db = new okalaDBEntities();
        // GET: kala
        public ActionResult Index(int id = 1)
        {
            okalaDBEntities db = new okalaDBEntities();
            int take = 4;
            int skip = (id - 1) * take;
            int count = db.kalas.Count();
            ViewBag.PageID = id;
            ViewBag.pagecount = Convert.ToInt32(Math.Ceiling(count /(double) take));
           var list= db.kalas.OrderByDescending(p => p.ID).Skip(skip).Take(take).ToList();
            return View(list);
        }

        // GET: kala/Details/5
        public ActionResult Details(int id)
        {  
          kala kala = db.kalas.Find(id);
            if (kala == null) 
            {
                return HttpNotFound();
            }
           
            return View(kala);
        }
        //kala.= kala.visitors + 1;
        //    db.Entry(kala).State = EntityState.Modified;
        //    db.SaveChanges();

        // GET: kala/Create
        public ActionResult Create()
        {
            return View();
        }
     
        //public ActionResult Details(int id, comment cmt)
        //{
        //    cmt.kalaID = id;

        //    db.comments.Add(cmt);
        //    db.SaveChanges();

        //    return View(db.kalas.Find(id));
        //}

        [HttpPost]
        public ActionResult Details(int id, comment cmt)
        {
            cmt.kalaID = id;

            db.comments.Add(cmt);
            db.SaveChanges();

            return View("partialcomments",cmt);
        }

        // POST: kala/Create
        [HttpPost]
        public ActionResult Create(kala kalaitem,HttpPostedFileBase picture)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid == true) {

                    if (picture != null && picture.ContentLength > 0)
                    {
                        var filename = picture.FileName;
                        var masireFile = Path.Combine(Server.MapPath("~/Content/Image/"), filename);
                        picture.SaveAs(masireFile);

                        kalaitem.ImageURL = "~/Content/Image/" + filename;
                    }
                    db.kalas.Add(kalaitem);
                db.SaveChanges();
                return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: kala/Edit/5
        public ActionResult Edit(int id)
        {
            kala kala = db.kalas.Find(id);
            if (kala == null) 
            {
                return HttpNotFound();
            }

            return View(kala);
        }

        // POST: kala/Edit/5

        [HttpPost]
        public ActionResult Edit(int id,kala editeditem ,HttpPostedFileBase picture)
        {
            if(ModelState.IsValid)
            {
                if (picture != null && picture.ContentLength > 0)
                {
                    var filename = picture.FileName;
                    var masireFile = Path.Combine(Server.MapPath("~/Content/Image/"), filename);
                    picture.SaveAs(masireFile);

                    editeditem.ImageURL = "~/Content/Image/" + filename;
                }

                db.Entry(editeditem).State = EntityState.Modified;
                db.SaveChanges();
                return  RedirectToAction("Index");
            }
            return View(editeditem);

      
        }

        // GET: kala/Delete/5
        public ActionResult Delete(int id)
        {
            kala kala = db.kalas.Find(id);
            if(kala==null)
            {
                return HttpNotFound();
            }
            return View(kala);
        }

        // POST: kala/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection kalaitem)
        {
            kala kala = db.kalas.Find(id);
            db.kalas.Remove(kala);
            db.SaveChanges();
            return RedirectToAction("index");
       
        }
        public ActionResult search()
        { 
            return View();
        }

        [HttpPost]
        public ActionResult search(string TxtsearchedTitle, string TxtsearchedText)
        {
            var res = db.kalas.Where(a => a.Name.Contains(TxtsearchedTitle) && a.Description.Contains(TxtsearchedText));
            List<kala> searchedkala = res.ToList();
            return View("result", searchedkala);
        }



        [HttpPost]
        public ActionResult search2(string TxtsearchedTitle, string TxtsearchedText)
        {
            var res = db.kalas.Where(a => a.Name.Contains(TxtsearchedTitle) && a.Description.Contains(TxtsearchedText));
            List<kala> searchedkala = res.ToList();
            return View("Partialresult", searchedkala);
        }













        public ActionResult Addlike(int id)
        {
            kala kala = db.kalas.Find(id);
            if (kala == null)
            {
                return HttpNotFound();
            }
            kala.like = kala.like + 1;
            db.Entry(kala).State = EntityState.Modified;
            db.SaveChanges();

            return View("Details", kala);
        }
























        //[HttpPost]
        //public ActionResult search2(string TxtsearchedTitle, string TxtsearchedText)
        //{
        //    var res = db.kalas.Where(a => a.Name.Contains(TxtsearchedTitle) && a.Text.contains(TxtsearchedTitle));
        //    List<kala>searchedkala =res.ToList();
        //    return View("Partialresult" , searchkalas);
        //}
    }
}
