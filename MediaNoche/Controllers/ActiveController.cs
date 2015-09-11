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
    public class ActiveController : Controller
    {
        private MediaNocheContext db = new MediaNocheContext();

        // GET: /Active/
        public ActionResult Index()
        {
            return View(db.Actives.ToList());
        }

        // GET: /Active/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Active active = db.Actives.Find(id);
            if (active == null)
            {
                return HttpNotFound();
            }
            return View(active);
        }

        // GET: /Active/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Active/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,FirsName,LastName,Birthday,Availability,Picture,Summary")] Active active)
        {
            if (ModelState.IsValid)
            {
                db.Actives.Add(active);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(active);
        }

        // GET: /Active/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Active active = db.Actives.Find(id);
            if (active == null)
            {
                return HttpNotFound();
            }
            return View(active);
        }

        // POST: /Active/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,FirsName,LastName,Birthday,Availability,Picture,Summary")] Active active)
        {
            if (ModelState.IsValid)
            {
                db.Entry(active).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(active);
        }

        // GET: /Active/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Active active = db.Actives.Find(id);
            if (active == null)
            {
                return HttpNotFound();
            }
            return View(active);
        }

        // POST: /Active/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Active active = db.Actives.Find(id);
            db.Actives.Remove(active);
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
