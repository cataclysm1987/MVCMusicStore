using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStore.Models;

namespace MVCMusicStore.Controllers
{
    public class ArtistController : Controller
    {
        
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Artist
        public ActionResult Index()
        {
            return View(db.Artists.ToList());
        }

        [HttpPost]
        public ActionResult AddArtist([Bind(Include = "Name,Description,ArtistId")] Artist artist)
        {
            if (ModelState.IsValid)
            {
                db.Artists.Add(artist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult AddArtist()
        {
            return View();
        }
    }
}