using BD.entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BD.Controllers
{
    public class UsuariosController : Controller
    {
        public readonly Contexto db;
        public UsuariosController(Contexto banco)
        {
            db = banco;
        }



        // GET: UsuariosController
        public ActionResult Index()
        {
            return View(db.Usuarios.ToList() );
        }

        // GET: UsuariosController/Details/5

        // GET: UsuariosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuariosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuario collection)
        {
            db.Usuarios.Add(collection);
            db.SaveChanges();
            return RedirectToAction("index");
        }

        // GET: UsuariosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View( db.Usuarios.Where(a => a.Id == id).FirstOrDefault());
        }

        // POST: UsuariosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Usuario collection)
        {
            db.Usuarios.Update(collection);
            db.SaveChanges();
            return RedirectToAction("index");
        }

        // GET: UsuariosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuariosController/Delete/5
    }
}
