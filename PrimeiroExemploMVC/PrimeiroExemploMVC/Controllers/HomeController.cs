using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeiroExemploMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/Index
        //Esse método será chamado sempre no caminho padrão, que foi definido na Rota
        public ActionResult Index()
        {
            return View();
        }
        //Criar um novo action para representar o sobre do site
        public ActionResult About() 
        {
            return View();
        }

    }
}
