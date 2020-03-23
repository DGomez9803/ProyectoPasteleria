using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ProyectoPasteleria.Repositorio;
using ProyectoPasteleria.Models;

namespace ProyectoPasteleria.Controllers
{
    public class HomeController : Controller
    {
        private IRepositorio<Usuario> _repositorio;

        public HomeController()
        {
            _repositorio = new Repositorio<Usuario>();
            Usuario usuario = new Usuario();
            _repositorio.Agregar(usuario);
        }

        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}