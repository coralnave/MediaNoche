using System;
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
    public class ExcersizeController : Controller
    {
        private MediaNocheContext db = new MediaNocheContext();

        // GET: /Excersize/
        public ActionResult Index()
        {
            return View(db.Excersizes.ToList());
        }

        // GET: /Excersize/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Excersize excersize = db.Excersizes.Find(id);
            if (excersize == null)
            {
                return HttpNotFound();
            }
            return View(excersize);
        }

        // GET: /Excersize/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Excersize/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,videoFileHandler")] Excersize excersize)
        {
            if (ModelState.IsValid)
            {
                if (excersize.videoFileHandler != null)
                {
                    string vid = System.IO.Path.GetFileName(excersize.videoFileHandler.FileName);
                    string pathVid = System.IO.Path.Combine(
                                           Server.MapPath("~/Upload"), vid);
                    excersize.videoFileHandler.SaveAs(pathVid);
                    excersize.Video = "../Upload/" + vid;
                }

                db.Excersizes.Add(excersize);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(excersize);
        }

        // GET: /Excersize/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Excersize excersize = db.Excersizes.Find(id);
            if (excersize == null)
            {
                return HttpNotFound();
            }
            return View(excersize);
        }

        // POST: /Excersize/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,videoFileHandler")] Excersize excersize)
        {
            if (ModelState.IsValid)
            {   
                db.Entry(excersize).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(excersize);
        }

        // GET: /Excersize/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Excersize excersize = db.Excersizes.Find(id);
            if (excersize == null)
            {
                return HttpNotFound();
            }
            return View(excersize);
        }

        // POST: /Excersize/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Excersize excersize = db.Excersizes.Find(id);
            db.Excersizes.Remove(excersize);
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
