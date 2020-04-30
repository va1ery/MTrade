using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MTrade.Models;

namespace MTrade.Controllers
{
    public class Тип_кузоваController : Controller
    {
        private АвтосалонEntities db = new АвтосалонEntities();

        // GET: Тип_кузова
        public ActionResult Index()
        {
            return View(db.Тип_кузова.ToList());
        }

        // GET: Тип_кузова/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Тип_кузова тип_кузова = db.Тип_кузова.Find(id);
            if (тип_кузова == null)
            {
                return HttpNotFound();
            }
            return View(тип_кузова);
        }

        // GET: Тип_кузова/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Тип_кузова/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Код_типа_кузова,Название,Описание")] Тип_кузова тип_кузова)
        {
            if (ModelState.IsValid)
            {
                db.Тип_кузова.Add(тип_кузова);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(тип_кузова);
        }

        // GET: Тип_кузова/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Тип_кузова тип_кузова = db.Тип_кузова.Find(id);
            if (тип_кузова == null)
            {
                return HttpNotFound();
            }
            return View(тип_кузова);
        }

        // POST: Тип_кузова/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Код_типа_кузова,Название,Описание")] Тип_кузова тип_кузова)
        {
            if (ModelState.IsValid)
            {
                db.Entry(тип_кузова).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(тип_кузова);
        }

        // GET: Тип_кузова/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Тип_кузова тип_кузова = db.Тип_кузова.Find(id);
            if (тип_кузова == null)
            {
                return HttpNotFound();
            }
            return View(тип_кузова);
        }

        // POST: Тип_кузова/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Тип_кузова тип_кузова = db.Тип_кузова.Find(id);
            db.Тип_кузова.Remove(тип_кузова);
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
