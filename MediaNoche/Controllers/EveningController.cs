﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MediaNoche.Models;
using MediaNoche.DAL;

namespace MediaNoche.Controllers
{
    public class EveningController : Controller
    {
        private MediaNocheContext db = new MediaNocheContext();

        // GET: /Evening/
        public ActionResult Index()
        {
            return View(db.Evenings.ToList());
        }

        // GET: /Evening/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evening evening = db.Evenings.Find(id);
            if (evening == null)
            {
                return HttpNotFound();
            }
            return View(evening);
        }

        // GET: /Evening/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Evening/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,EveningLessonID,Date,Concept")] Evening evening)
        {
            if (ModelState.IsValid)
            {
                db.Evenings.Add(evening);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(evening);
        }

        // GET: /Evening/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evening evening = db.Evenings.Find(id);
            if (evening == null)
            {
                return HttpNotFound();
            }
            return View(evening);
        }

        // POST: /Evening/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,EveningLessonID,Date,Concept")] Evening evening)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evening).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(evening);
        }

        // GET: /Evening/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evening evening = db.Evenings.Find(id);
            if (evening == null)
            {
                return HttpNotFound();
            }
            return View(evening);
        }

        // POST: /Evening/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Evening evening = db.Evenings.Find(id);
            db.Evenings.Remove(evening);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}