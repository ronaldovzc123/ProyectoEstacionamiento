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
	public class ClienteController : Controller
	{
		//private EstacionamientoBDContext db = new EstacionamientoBDContext();
		private readonly IUnityOfWork _UnityOfWork;

		public ClienteController()
		{

		}

		public ClienteController(IUnityOfWork unityOfWork)
		{
			_UnityOfWork = unityOfWork;
		}

		// GET: Cliente
		public ActionResult Index()
		{
			//var cliente = db.Cliente.Include(c => c.Beneficio).Include(c => c.TipoCliente);
			//return View(cliente.ToList());
			return View(_UnityOfWork.Clientes.GetAll());
		}

		// GET: Cliente/Details/5
		public ActionResult Details(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}

			//Cliente cliente = db.Cliente.Find(id);
			Cliente cliente = _UnityOfWork.Clientes.Get(id);
			if (cliente == null)
			{
				return HttpNotFound();
			}
			return View(cliente);
		}

		// GET: Cliente/Create
		public ActionResult Create()
		{
			//ViewBag.BeneficioID = new SelectList(db.Beneficio, "BeneficioID", "BeneficioID");
			//ViewBag.TipoClienteID = new SelectList(db.TipoCliente, "TipoClienteID", "Descripcion");
			return View();
		}

		// POST: Cliente/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "ClienteID,DNI,TipoClienteID,Nombre,Apellido,BeneficioID")] Cliente cliente)
		{
			if (ModelState.IsValid)
			{
				//db.Cliente.Add(cliente);
				_UnityOfWork.Clientes.Add(cliente);
				//db.SaveChanges();
				_UnityOfWork.SaveChanges();
				return RedirectToAction("Index");
			}

			//ViewBag.BeneficioID = new SelectList(db.Beneficio, "BeneficioID", "BeneficioID", cliente.BeneficioID);
			//ViewBag.TipoClienteID = new SelectList(db.TipoCliente, "TipoClienteID", "Descripcion", cliente.TipoClienteID);
			return View(cliente);
		}

		// GET: Cliente/Edit/5
		public ActionResult Edit(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			//Cliente cliente = db.Cliente.Find(id);
			Cliente cliente = _UnityOfWork.Clientes.Get(id);
			if (cliente == null)
			{
				return HttpNotFound();
			}
			//ViewBag.BeneficioID = new SelectList(db.Beneficio, "BeneficioID", "BeneficioID", cliente.BeneficioID);
			//ViewBag.TipoClienteID = new SelectList(db.TipoCliente, "TipoClienteID", "Descripcion", cliente.TipoClienteID);
			return View(cliente);
		}

		// POST: Cliente/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "ClienteID,DNI,TipoClienteID,Nombre,Apellido,BeneficioID")] Cliente cliente)
		{
			if (ModelState.IsValid)
			{
				//db.Entry(cliente).State = EntityState.Modified;
				_UnityOfWork.StateModified(cliente);
				//db.SaveChanges();
				_UnityOfWork.SaveChanges();
				return RedirectToAction("Index");
			}
			//ViewBag.BeneficioID = new SelectList(db.Beneficio, "BeneficioID", "BeneficioID", cliente.BeneficioID);
			//ViewBag.TipoClienteID = new SelectList(db.TipoCliente, "TipoClienteID", "Descripcion", cliente.TipoClienteID);
			return View(cliente);
		}

		// GET: Cliente/Delete/5
		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			//Cliente cliente = db.Cliente.Find(id);
			Cliente cliente = _UnityOfWork.Clientes.Get(id);
			if (cliente == null)
			{
				return HttpNotFound();
			}
			return View(cliente);
		}

		// POST: Cliente/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			//Cliente cliente = db.Cliente.Find(id);
			Cliente cliente = _UnityOfWork.Clientes.Get(id);

			//db.Cliente.Remove(cliente);
			_UnityOfWork.Clientes.Delete(cliente);

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
