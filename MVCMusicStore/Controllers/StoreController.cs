using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStore.Models;

namespace MVCMusicStore.Controllers
{
    public class StoreController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Store
        public ActionResult Index()
        {
            return View(db.Albums.ToList());
        }

        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "AlbumId,Title,Genre,AlbumArtUrl,ArtistId")] Album album)
        {
            if (ModelState.IsValid)
            {
                db.Albums.Add(album);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Album album = db.Albums.SingleOrDefault(t => t.AlbumId == id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Album album = db.Albums.SingleOrDefault(t => t.AlbumId == id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "AlbumId,Title,Genre,AlbumArtUrl,ArtistId")] Album album)
        {
            if (ModelState.IsValid)
            {
                db.Entry(album).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }



        
    }
}