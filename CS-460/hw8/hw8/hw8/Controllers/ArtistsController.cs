﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hw8.Models;

namespace hw8.Controllers
{
    public class ArtistsController : Controller
    {
        private ArtistContext db = new ArtistContext();

        // GET: Artists
        public ActionResult Index()
        {
            var artists = db.Artists.ToList();
            return View(artists);
        }

        // Get: Artworks
        public ActionResult Artworks()
        {
            var artworks = db.Artworks.ToList();
            return View(artworks);
        }

        // GET: Classifications
        public ActionResult Classifications()
        {
            var classifications = db.Classifications.ToList();
            return View(classifications);
        }

        // GET: Artists/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Artists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Artists/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var newArtist = db.Artists.Create();

                newArtist.Name = collection["Name"];
                newArtist.BirthCity = collection["BirthCity"];
                newArtist.BirthDate = collection["BirthDate"];

                db.Artists.Add(newArtist);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Artists/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Artists/Edit/5
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

        // GET: Artists/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Artists/Delete/5
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
    }
}