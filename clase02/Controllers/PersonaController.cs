using clase02.DAORE;
using clase02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace clase02.Controllers
{
    public class PersonaController : Controller
    {
        
        public ActionResult Descripcion(String Variable)
        {

            //var per = new ClsPersona { Nombre = "Stanley" };
            ViewBag.variabledinamica = Variable;
            //return View(per);

            PersonaRepository per = new PersonaRepository();

            return View(per.obtenerPersona());
        }


        
    }
}