using bahare_zorufchi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bahare_zorufchi.Controllers
{
    public class layoutController : Controller
    {
        // GET: layout
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Rsvpform()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Rsvpform(pasokh gst)
        {
            if (ModelState.IsValid == true)
            {
                return View("thanks", gst);
            }
            else
            {
                return View();
            }
        }
    }
}