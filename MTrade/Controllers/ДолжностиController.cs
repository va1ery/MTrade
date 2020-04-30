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
    public class ДолжностиController : Controller
    {
        private АвтосалонEntities db = new АвтосалонEntities();

        // GET: Должности
        public ActionResult Index()
        {
            return View(db.Должности.ToList());
        }

        // GET: Должности/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Должности должности = db.Должности.Find(id);
            if (должности == null)
            {
                return HttpNotFound();
            }
            return View(должности);
        }

        // GET: Должности/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Должности/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Код_должности,Наименование_должности,Оклад,Обязанности,Требования")] Должности должности)
        {
            if (ModelState.IsValid)
            {
                db.Должности.Add(должности);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(должности);
        }

        // GET: Должности/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Должности должности = db.Должности.Find(id);
            if (должности == null)
            {
                return HttpNotFound();
            }
            return View(должности);
        }

        // POST: Должности/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Код_должности,Наименование_должности,Оклад,Обязанности,Требования")] Должности должности)
        {
            if (ModelState.IsValid)
            {
                db.Entry(должности).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(должности);
        }

        // GET: Должности/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Должности должности = db.Должности.Find(id);
            if (должности == null)
            {
                return HttpNotFound();
            }
            return View(должности);
        }

        // POST: Должности/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Должности должности = db.Должности.Find(id);
            db.Должности.Remove(должности);
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
