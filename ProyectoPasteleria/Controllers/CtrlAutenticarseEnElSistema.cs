using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoPasteleria.Repositorio;
using ProyectoPasteleria.Models;



namespace ProyectoPasteleria.Controllers
{
    public class CtrlAutenticarseEnElSistema : Controller
    {

        private IRepositorio<Usuario> _repositorio;

        public CtrlAutenticarseEnElSistema(Repositorio<Usuario> repositorio)
        {
            _repositorio = repositorio;
            
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
