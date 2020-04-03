using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WescoWeb.DAL;
using WescoWeb.Models;

namespace WescoWeb.Controllers
{
    public class donutsController : Controller
    {
        private wescocontext db = new wescocontext();

        // GET: donuts
        public ActionResult Index()
        {
            return View(db.donuts.ToList());
        }

        // GET: donuts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            donut donut = db.donuts.Find(id);
            if (donut == null)
            {
                return HttpNotFound();
            }
            return View(donut);
        }

        // GET: donuts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: donuts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "donutID,date,ordered,sold,wasted,name,production,price")] donut donut)
        {
            if (ModelState.IsValid)
            {
                db.donuts.Add(donut);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(donut);
        }

        // GET: donuts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            donut donut = db.donuts.Find(id);
            if (donut == null)
            {
                return HttpNotFound();
            }
            return View(donut);
        }

        // POST: donuts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "donutID,date,ordered,sold,wasted,name,production,price")] donut donut)
        {
            if (ModelState.IsValid)
            {
                db.Entry(donut).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(donut);
        }

        // GET: donuts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            donut donut = db.donuts.Find(id);
            if (donut == null)
            {
                return HttpNotFound();
            }
            return View(donut);
        }

        // POST: donuts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            donut donut = db.donuts.Find(id);
            db.donuts.Remove(donut);
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
