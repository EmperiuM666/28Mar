using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _28Mar.Models;

namespace _28Mar.Controllers
{
    public class NovoController : Controller
    {
        // GET: Novo
        public ActionResult Um()
        {

            return Content("Olá mundo");
        }

        public ActionResult Dois() 
        {
            return Json(new { Num = 1, Nome = "Tio Patinhas" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Tres()
        {

            return Content("<script>alert('Ola Mundo');</script>");
        }

        public ActionResult Quatro()
        {

            return new EmptyResult ();
        }

        public ActionResult Cinco()
        {

            return File (Url.Content("~/Textos/mundo.txt"), "text/plain" );
        }

        public ActionResult Seis()
        {

            return RedirectToAction("About", "Home", new { id = 234});
        }

        public ActionResult Sete()
        {

            return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest, "Cometi um erro");
        }

        public ActionResult Oito()
        {

            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa { Id = 1, Nome = "Penina", Turma = "A" });
            pessoas.Add(new Pessoa { Id = 2, Nome = "Pato Donald", Turma = "B" });
            pessoas.Add(new Pessoa { Id = 3, Nome = "Mickey", Turma = "B" });
            pessoas.Add(new Pessoa { Id = 4, Nome = "Bafo de Onça", Turma = "A" });
            pessoas.Add(new Pessoa { Id = 5, Nome = "Margarida", Turma = "A" });
            ViewBag.escola = "Istec";
            ViewData["curso"] = "Informática";
            TempData["disciplina"] = "TintIII";
            return View(pessoas );
        }
    }
}