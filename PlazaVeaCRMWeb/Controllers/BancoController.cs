using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PlazaVeaCRMWeb.DAL;
using PlazaVeaCRMWeb.Models;

namespace PlazaVeaCRMWeb.Controllers
{
    public class BancoController : Controller
    {
        private PlazaVeaCrmContext db = new PlazaVeaCrmContext();

        // GET: Banco
        public ActionResult Index()
        {
            return View(db.Banco.ToList());
        }

        // GET: Banco/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Banco banco = db.Banco.Find(id);
            if (banco == null)
            {
                return HttpNotFound();
            }
            return View(banco);
        }

        // GET: Banco/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Banco/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Codigo,Nombre")] Banco banco)
        {
            if (ModelState.IsValid)
            {
                db.Banco.Add(banco);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(banco);
        }

        // GET: Banco/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Banco banco = db.Banco.Find(id);
            if (banco == null)
            {
                return HttpNotFound();
            }
            return View(banco);
        }

        // POST: Banco/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Codigo,Nombre")] Banco banco)
        {
            if (ModelState.IsValid)
            {
                db.Entry(banco).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(banco);
        }

        // GET: Banco/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Banco banco = db.Banco.Find(id);
            if (banco == null)
            {
                return HttpNotFound();
            }
            return View(banco);
        }

        // POST: Banco/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Banco banco = db.Banco.Find(id);
            db.Banco.Remove(banco);
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
