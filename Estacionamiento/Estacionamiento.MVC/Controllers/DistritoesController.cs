using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Estacionamiento.Entities;
using Estacionamiento.Persistence;
using Estacionamiento.Persistence.Repositories;
using Estacionamiento.Entities.IRepositories;

namespace Estacionamiento.MVC.Controllers
{
    public class DistritoesController : Controller
    {
        //private EstacionamientoBDContext db = new EstacionamientoBDContext();

        private readonly IUnityOfWork _UnityOfWork;

        public DistritoesController()
        {
                
        }

        public DistritoesController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }


    // GET: Distritoes
        public ActionResult Index()
        {
           //var distrito = db.Distrito.Include(d => d.SedeEstacionamiento);
            // return View(distrito.ToList());
            return View(unityOfWork.Distritos.GetAll());
        }

        // GET: Distritoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Distrito distrito = db.Distrito.Find(id);
            Distrito distrito = unityOfWork.Distritos.Get(id);

            if (distrito == null)
            {
                return HttpNotFound();
            }
            return View(distrito);
        }

        // GET: Distritoes/Create
        public ActionResult Create()
        {
 //ViewBag.SedeEstacionamientoID = new SelectList(db.SedeEstacionamiento, "SedeEstacionamientoID", "NombreSede");
            return View();
        }

        // POST: Distritoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DistritoID,SedeEstacionamientoID,NombreDistrito,Direccion")] Distrito distrito)
        {
            if (ModelState.IsValid)
            {
                // db.Distrito.Add(distrito);
                unityOfWork.Distritos.Add(distrito);
                //db.SaveChanges();
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

           // ViewBag.SedeEstacionamientoID = new SelectList(db.SedeEstacionamiento, "SedeEstacionamientoID", "NombreSede", distrito.SedeEstacionamientoID);
            return View(distrito);
        }

        // GET: Distritoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Distrito distrito = db.Distrito.Find(id);
            Distrito distrito = unityOfWork.Distritos.Get(id);
            {
                return HttpNotFound();
            }

         //  ViewBag.SedeEstacionamientoID = new SelectList(db.SedeEstacionamiento, "SedeEstacionamientoID", "NombreSede", distrito.SedeEstacionamientoID);
            return View(distrito);
        }

        // POST: Distritoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DistritoID,SedeEstacionamientoID,NombreDistrito,Direccion")] Distrito distrito)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(distrito).State = EntityState.Modified;
                unityOfWork.StateModified(distrito);
                //db.SaveChanges();
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
      //      ViewBag.SedeEstacionamientoID = new SelectList(db.SedeEstacionamiento, "SedeEstacionamientoID", "NombreSede", distrito.SedeEstacionamientoID);
            return View(distrito);
        }

        // GET: Distritoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Distrito distrito = db.Distrito.Find(id);
            Distrito distrito = unityOfWork.Distritos.Get(id);
            if (distrito == null)
            {
                return HttpNotFound();
            }
            return View(distrito);
        }

        // POST: Distritoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Distrito distrito = db.Distrito.Find(id);
            Distrito distrito = unityOfWork.Distritos.Get(id);
            //db.Distrito.Remove(distrito);
            unityOfWork.Distritos.Delete(distrito);
            //db.SaveChanges();
            unityOfWork.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
                unityOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
