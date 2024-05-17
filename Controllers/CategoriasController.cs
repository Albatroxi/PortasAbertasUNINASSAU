using PortasAbertasUNINASSAU.Data;
using PortasAbertasUNINASSAU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortasAbertasUNINASSAU.Controllers
{
    public class CategoriasController : Controller
    {
        ProdutoDbContext db;
        public CategoriasController()
        {
            db = new ProdutoDbContext();
        }

        // GET: Categoria
        public ActionResult Index()
        {
            var categorias = db.Categorias.ToList();
            return View(categorias);
        }

        public ActionResult Create()
        {
            ViewBag.Categorias = db.Categorias;
            var model = new CategoriaViewModel();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriaViewModel model)
        {
            var categoria = new Categoria();

            categoria.CategoriaId = model.CategoriaId;
            categoria.CategoriaNome = model.CategoriaNome;

            db.Categorias.Add(categoria);
            db.SaveChanges();
            return RedirectToAction("Index");
            }
    }
}