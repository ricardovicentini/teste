using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteCrudNetFramework.Models;
using TesteCrudNetFramework.Repositorios;

namespace TesteCrudNetFramework.Controllers
{
    public class ManobristaController : Controller
    {
        ManobristaRepositorio repositorio;

        public ManobristaController(ManobristaRepositorio manobristaRepositorio)
        {
            repositorio = manobristaRepositorio;

        }
        // GET: Manobrista
        public ActionResult Index()
        {
            var manobristas = repositorio.Listar();
            return View(manobristas);
        }

       

        // GET: Manobrista/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manobrista/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                DateTime dtNascimento = DateTime.TryParse(collection["DataNascimento"], out dtNascimento) ? dtNascimento : throw new ArgumentException("Data nascimento inválida");
                var manobrista = new Manobrista(collection["Nome"], collection["Cpf"], dtNascimento);
                repositorio.Adicionar(manobrista);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Manobrista/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Manobrista/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Manobrista/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Manobrista/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
