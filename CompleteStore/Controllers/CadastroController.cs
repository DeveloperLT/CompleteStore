using CompleteStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompleteStore.Controllers
{
    public class CadastroController : Controller
    {
        private static List<GrupoProduto> _listaGrupoProduto = new List<GrupoProduto>()
        {
            new GrupoProduto() { Id=1, Nome="Perfume X", Ativo=true}
        };
        
        
        // GET: Cadastro
        [Authorize]
        public ActionResult GProd()
        {
            return View(_listaGrupoProduto);
        }
        [Authorize]
        public ActionResult Cat()
        {
            return View();
        }

        [Authorize]
        public ActionResult SubCategoria()
        {
            return View();
        }

        [Authorize]
        public ActionResult MarcProd()
        {
            return View();
        }

        [Authorize]
        public ActionResult LArm()
        {
            return View();
        }

        [Authorize]
        public ActionResult UnMed()
        {
            return View();
        }

        [Authorize]
        public ActionResult Prod()
        {
            return View();
        }

        [Authorize]
        public ActionResult Country()
        {
            return View();
        }

        [Authorize]
        public ActionResult State()
        {
            return View();
        }

        [Authorize]
        public ActionResult City()
        {
            return View();
        }

        [Authorize]
        public ActionResult Forn()
        {
            return View();
        }
        [Authorize]
        public ActionResult Profiles()
        {
            return View();
        }
        [Authorize]
        public ActionResult Users()
        {
            return View();
        }
    }
}