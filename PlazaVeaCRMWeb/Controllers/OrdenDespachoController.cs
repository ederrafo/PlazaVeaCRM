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
    public class OrdenDespachoController : Controller
    {
        private PlazaVeaCrmContext db = new PlazaVeaCrmContext();


        // GET: OrdenDespacho
        public ActionResult Index()
        {
            
            List<SelectListItem> selectEstado = new List<SelectListItem>()
            {
                new SelectListItem { Text = "Seleccionar", Value = "-1"},
                new SelectListItem { Text = "Pendiente", Value = "1"},
                new SelectListItem { Text = "Devuelto", Value = "2"}
            };
            
            ViewBag.Estado = selectEstado;


            var ordenDespacho = db.OrdenDespacho.Include(o => o.PersonalProgramado).Include(o => o.Transporte);
            return View(ordenDespacho.ToList());
        }

        // GET: OrdenDespacho/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdenDespacho ordenDespacho = db.OrdenDespacho.Find(id);
            if (ordenDespacho == null)
            {
                return HttpNotFound();
            }
            return View(ordenDespacho);
        }

        // GET: OrdenDespacho/Create
        public ActionResult Create()
        {
            ViewBag.IdOperario = new SelectList(db.PersonalProgramado, "IdPersonalProgramado", "Observacion");
            ViewBag.IdTransporte = new SelectList(db.Transporte, "IdTransporte", "NroPlaca");
            return View();
        }

        // POST: OrdenDespacho/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdOrdenDespacho,FechaDespacho,TipoPrioridadOrdenDespacho,IdTransporte,IdConductor,IdOperario,Observacion,EstadoOrdenDespacho")] OrdenDespacho ordenDespacho)
        {
            if (ModelState.IsValid)
            {
                db.OrdenDespacho.Add(ordenDespacho);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdOperario = new SelectList(db.PersonalProgramado, "IdPersonalProgramado", "Observacion", ordenDespacho.IdOperario);
            ViewBag.IdTransporte = new SelectList(db.Transporte, "IdTransporte", "NroPlaca", ordenDespacho.IdTransporte);
            return View(ordenDespacho);
        }

        // GET: OrdenDespacho/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdenDespacho ordenDespacho = db.OrdenDespacho.Find(id);
            if (ordenDespacho == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdOperario = new SelectList(db.PersonalProgramado, "IdPersonalProgramado", "Observacion", ordenDespacho.IdOperario);
            ViewBag.IdTransporte = new SelectList(db.Transporte, "IdTransporte", "NroPlaca", ordenDespacho.IdTransporte);
            return View(ordenDespacho);
        }

        // POST: OrdenDespacho/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdOrdenDespacho,FechaDespacho,TipoPrioridadOrdenDespacho,IdTransporte,IdConductor,IdOperario,Observacion,EstadoOrdenDespacho")] OrdenDespacho ordenDespacho)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ordenDespacho).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdOperario = new SelectList(db.PersonalProgramado, "IdPersonalProgramado", "Observacion", ordenDespacho.IdOperario);
            ViewBag.IdTransporte = new SelectList(db.Transporte, "IdTransporte", "NroPlaca", ordenDespacho.IdTransporte);
            return View(ordenDespacho);
        }

        // GET: OrdenDespacho/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdenDespacho ordenDespacho = db.OrdenDespacho.Find(id);
            if (ordenDespacho == null)
            {
                return HttpNotFound();
            }
            return View(ordenDespacho);
        }

        // POST: OrdenDespacho/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrdenDespacho ordenDespacho = db.OrdenDespacho.Find(id);
            db.OrdenDespacho.Remove(ordenDespacho);
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
