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
    public class Дополнительное_оборудованиеController : Controller
    {
        private АвтосалонEntities db = new АвтосалонEntities();

        // GET: Дополнительное_оборудование
        public ActionResult Index()
        {
            return View(db.Дополнительное_оборудование.ToList());
        }

        // GET: Дополнительное_оборудование/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Дополнительное_оборудование дополнительное_оборудование = db.Дополнительное_оборудование.Find(id);
            if (дополнительное_оборудование == null)
            {
                return HttpNotFound();
            }
            return View(дополнительное_оборудование);
        }

        // GET: Дополнительное_оборудование/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Дополнительное_оборудование/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Код_оборудования,Наименование,Характеристики,Цена")] Дополнительное_оборудование дополнительное_оборудование)
        {
            if (ModelState.IsValid)
            {
                db.Дополнительное_оборудование.Add(дополнительное_оборудование);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(дополнительное_оборудование);
        }

        // GET: Дополнительное_оборудование/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Дополнительное_оборудование дополнительное_оборудование = db.Дополнительное_оборудование.Find(id);
            if (дополнительное_оборудование == null)
            {
                return HttpNotFound();
            }
            return View(дополнительное_оборудование);
        }

        // POST: Дополнительное_оборудование/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Код_оборудования,Наименование,Характеристики,Цена")] Дополнительное_оборудование дополнительное_оборудование)
        {
            if (ModelState.IsValid)
            {
                db.Entry(дополнительное_оборудование).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(дополнительное_оборудование);
        }

        // GET: Дополнительное_оборудование/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Дополнительное_оборудование дополнительное_оборудование = db.Дополнительное_оборудование.Find(id);
            if (дополнительное_оборудование == null)
            {
                return HttpNotFound();
            }
            return View(дополнительное_оборудование);
        }

        // POST: Дополнительное_оборудование/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Дополнительное_оборудование дополнительное_оборудование = db.Дополнительное_оборудование.Find(id);
            db.Дополнительное_оборудование.Remove(дополнительное_оборудование);
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
