using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _7_11_Slack.Models;

namespace _7_11_Slack.Controllers
{
    public class SubCategoriasController : Controller
    {
        private sl_baseEntities db = new sl_baseEntities();

        // GET: SubCategorias
        public ActionResult Index()
        {
            var subCategorias = db.SubCategorias.Include(s => s.Categoria);
            return View(subCategorias.ToList());
        }

        // GET: SubCategorias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubCategoria subCategoria = db.SubCategorias.Find(id);
            if (subCategoria == null)
            {
                return HttpNotFound();
            }
            return View(subCategoria);
        }

        // GET: SubCategorias/Create
        public ActionResult Create()
        {
            ViewBag.IdCategoria = new SelectList(db.Categorias, "IdCategoria", "NombreCategoria");
            return View();
        }

        // POST: SubCategorias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdSubCategoria,IdCategoria,NombreSubCategoria,Estado")] SubCategoria subCategoria)
        {
            if (ModelState.IsValid)
            {
                db.SubCategorias.Add(subCategoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCategoria = new SelectList(db.Categorias, "IdCategoria", "NombreCategoria", subCategoria.IdCategoria);
            return View(subCategoria);
        }

        // GET: SubCategorias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubCategoria subCategoria = db.SubCategorias.Find(id);
            if (subCategoria == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCategoria = new SelectList(db.Categorias, "IdCategoria", "NombreCategoria", subCategoria.IdCategoria);
            return View(subCategoria);
        }

        // POST: SubCategorias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdSubCategoria,IdCategoria,NombreSubCategoria,Estado")] SubCategoria subCategoria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subCategoria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCategoria = new SelectList(db.Categorias, "IdCategoria", "NombreCategoria", subCategoria.IdCategoria);
            return View(subCategoria);
        }

        // GET: SubCategorias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubCategoria subCategoria = db.SubCategorias.Find(id);
            if (subCategoria == null)
            {
                return HttpNotFound();
            }
            return View(subCategoria);
        }

        // POST: SubCategorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SubCategoria subCategoria = db.SubCategorias.Find(id);
            db.SubCategorias.Remove(subCategoria);
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
