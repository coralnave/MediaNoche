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
    [Authorize]
    public class EveningLessonController : Controller
    {
        private MediaNocheContext db = new MediaNocheContext();

        // GET: /EveningLesson/
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View(db.EveningLessons.ToList());
        }

        // GET: /EveningLesson/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EveningLesson eveninglesson = db.EveningLessons.Find(id);
            if (eveninglesson == null)
            {
                return HttpNotFound();
            }
            return View(eveninglesson);
        }

        // GET: /EveningLesson/Create
        [Authorize(Roles = "Admins")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: /EveningLesson/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admins")]
        public ActionResult Create([Bind(Include="ID,ActiveID,Level,LessonNum")] EveningLesson eveninglesson)
        {
            if (ModelState.IsValid)
            {
                db.EveningLessons.Add(eveninglesson);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eveninglesson);
        }

        // GET: /EveningLesson/Edit/5
        [Authorize(Roles = "Admins")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EveningLesson eveninglesson = db.EveningLessons.Find(id);
            if (eveninglesson == null)
            {
                return HttpNotFound();
            }
            return View(eveninglesson);
        }

        // POST: /EveningLesson/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admins")]
        public ActionResult Edit([Bind(Include="ID,ActiveID,Level,LessonNum")] EveningLesson eveninglesson)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eveninglesson).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eveninglesson);
        }

        // GET: /EveningLesson/Delete/5
        [Authorize(Roles = "Admins")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EveningLesson eveninglesson = db.EveningLessons.Find(id);
            if (eveninglesson == null)
            {
                return HttpNotFound();
            }
            return View(eveninglesson);
        }

        // POST: /EveningLesson/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admins")]
        public ActionResult DeleteConfirmed(int id)
        {
            EveningLesson eveninglesson = db.EveningLessons.Find(id);
            db.EveningLessons.Remove(eveninglesson);
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
