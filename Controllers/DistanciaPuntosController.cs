using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class DistanciaPuntosController : Controller
    {
        // GET: DistanciaPuntos
        public ActionResult Distancia(Distancia dis)
        {
            dis.Operacion();
            var model = new Distancia();
            model.Resultado = dis.Resultado;
            ViewBag.Resultado = dis.Resultado;
            return View(dis);
        }

        public ActionResult Distancia2(Distancia dis)
        {
            var model = new Distancia();
            dis.Operacion();
            model.Resultado = dis.Resultado;
            ViewBag.Resultado = dis.Resultado;
            return View(dis);
        }

    }
}