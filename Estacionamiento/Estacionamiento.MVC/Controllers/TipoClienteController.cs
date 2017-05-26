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
using Estacionamiento.Entities.IRepositories;

namespace Estacionamiento.MVC.Controllers
{
	public class TipoClienteController : Controller
	{
		//private EstacionamientoBDContext db = new EstacionamientoBDContext();
		private readonly IUnityOfWork _UnityOfWork;

		public TipoClienteController()
		{

		}

		public TipoClienteController(IUnityOfWork unityOfWork)
		{
			_UnityOfWork = unityOfWork;
		}

		// GET: TipoCliente
		public ActionResult Index()
		{
			//return View(db.TipoCliente.ToList());
			return View(_UnityOfWork.Clientes.GetAll());
		}

		// GET: TipoCliente/Details/5
		public ActionResult Details(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			//TipoCliente tipoCliente = db.TipoCliente.Find(id);
			TipoCliente tipoCliente = _UnityOfWork.TiposCliente.Get(id);
			if (tipoCliente == null)
			{
				return HttpNotFound();
			}
			return View(tipoCliente);
		}

		// GET: TipoCliente/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: TipoCliente/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "TipoClienteID,Descripcion")] TipoCliente tipoCliente)
		{
			if (ModelState.IsValid)
			{
				//db.TipoCliente.Add(tipoCliente);
				_UnityOfWork.TiposCliente.Add(tipoCliente);

				//db.SaveChanges();
				_UnityOfWork.SaveChanges();

				return RedirectToAction("Index");
			}

			return View(tipoCliente);
		}

		// GET: TipoCliente/Edit/5
		public ActionResult Edit(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}

			//TipoCliente tipoCliente = db.TipoCliente.Find(id);
			TipoCliente tipoCliente = _UnityOfWork.TiposCliente.Get(id);
			if (tipoCliente == null)
			{
				return HttpNotFound();
			}
			return View(tipoCliente);
		}

		// POST: TipoCliente/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "TipoClienteID,Descripcion")] TipoCliente tipoCliente)
		{
			if (ModelState.IsValid)
			{
				//db.Entry(tipoCliente).State = EntityState.Modified;
				_UnityOfWork.StateModified(tipoCliente);

				//db.SaveChanges();
				_UnityOfWork.SaveChanges();

				return RedirectToAction("Index");
			}
			return View(tipoCliente);
		}

		// GET: TipoCliente/Delete/5
		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}

			//TipoCliente tipoCliente = db.TipoCliente.Find(id);
			TipoCliente tipoCliente = _UnityOfWork.TiposCliente.Get(id);

			if (tipoCliente == null)
			{
				return HttpNotFound();
			}
			return View(tipoCliente);
		}

		// POST: TipoCliente/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			//TipoCliente tipoCliente = db.TipoCliente.Find(id);
			TipoCliente tipoCliente = _UnityOfWork.TiposCliente.Get(id);

			//db.TipoCliente.Remove(tipoCliente);
			_UnityOfWork.TiposCliente.Delete(tipoCliente);

			//db.SaveChanges();
			_UnityOfWork.SaveChanges();

			return RedirectToAction("Index");
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				//db.Dispose();
				_UnityOfWork.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}
