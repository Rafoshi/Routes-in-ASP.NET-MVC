using AppRoute66.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppRoute66.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<Noticia> Noticias;

        public HomeController()
        {
            Noticias = new Noticia().TodasNoticias().OrderByDescending(x => x.Data);
        }

        public ActionResult Index()
        {
            return View();

        }

        public ActionResult MostrarNoticia(int noticiaID)
        {
            Noticia noticiaSelecionada = Noticias.FirstOrDefault(x => x.NoticiaID == noticiaID);
            return View(noticiaSelecionada);
        }

        public ActionResult UltimasNoticias()
        {
            var ultimasNoticias = Noticias.Take(3);
            var Categorias = Noticias.Select(x => x.Categoria).Distinct().ToList();

            ViewBag.Categorias = Categorias;
            return View(ultimasNoticias);
        }

        public ActionResult MostrarCategoria(string categoria)
        {
            var categoriaSelecionada = Noticias.Where(x => x.Categoria.ToLower() == categoria.ToLower()).ToList();
            ViewBag.Categoria = categoria;
            return View(categoriaSelecionada);
        }

        public ActionResult TodasNoticias()
        {
            return View(Noticias);
        }

        public ActionResult Criatividade()
        {
            return View();
        }
    }
}