using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class TrianguloController : Controller
    {
        public ActionResult Puntos()
        {
            return View();
        }

        // GET: Triangulo
        [HttpPost]
        public ActionResult Puntos(Coordenadas coor)
        {
            coor.DistanciaPuntos();
            var obj1 = new Coordenadas();
            var obj2 = new Coordenadas();
            var obj3 = new Coordenadas();
            obj1.LadoAB = coor.LadoAB;
            obj2.LadoAC = coor.LadoAC;
            obj3.LadoBC = coor.LadoBC;
            ViewBag.LadoAB = coor.LadoAB;
            ViewBag.LadoAC = coor.LadoAC;
            ViewBag.LadoBC = coor.LadoBC;


            return View(coor);
        }

    }
}