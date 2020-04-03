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
    public class wescoesController : Controller
    {
        private wescocontext db = new wescocontext();

        // GET: wescoes
        public ActionResult Index()
        {
            return View(db.wescos.ToList());
        }

        // GET: wescoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            wesco wesco = db.wescos.Find(id);
            if (wesco == null)
            {
                return HttpNotFound();
            }
            return View(wesco);
        }

        // GET: wescoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: wescoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "wescoID,password,managerfname,managerlname")] wesco wesco)
        {
            if (ModelState.IsValid)
            {
                db.wescos.Add(wesco);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(wesco);
        }

        // GET: wescoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            wesco wesco = db.wescos.Find(id);
            if (wesco == null)
            {
                return HttpNotFound();
            }
            return View(wesco);
        }

        // POST: wescoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "wescoID,password,managerfname,managerlname")] wesco wesco)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wesco).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wesco);
        }

        // GET: wescoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            wesco wesco = db.wescos.Find(id);
            if (wesco == null)
            {
                return HttpNotFound();
            }
            return View(wesco);
        }

        // POST: wescoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            wesco wesco = db.wescos.Find(id);
            db.wescos.Remove(wesco);
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
