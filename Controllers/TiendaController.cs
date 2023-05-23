using IDGS903_Tema1.Models;
using IDGS903_Tema1.Servicios;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda
        public ActionResult MuestraPulques()
        {
            var pulquesVenta = new PulqueServices();
            var model = pulquesVenta.ObtenerPulque();
            return View(model);
        }

        public ActionResult MuestraPulques2()
        {

            var pulquesVenta = new PulqueServices();
            var model = pulquesVenta.ObtenerPulque();
            return View(model);
        }

        public JsonResult Index()
        {
            var pulque1 = new Pulques() { Nombre = "Pulque Mango", Descripcion = "Pulque de Mango" };
            return Json(pulque1, JsonRequestBehavior.AllowGet);
            //return Content("Daniel Abraham Sanchez Aboytes");
           // return View();
        }

        public ActionResult Vista()
        {
            var pulque1 = new Pulques() {
                Nombre = "Pulque Mango", 
                Descripcion = "Pulque de Mango" , 
                Caducidad = new DateTime(2023,11,4),
           Litros =23
            };
            ViewBag.Pulque = pulque1;
            return View();  
        }
        public ActionResult Vista2()
        {
            ViewBag.saludo = "Hola MUNDO";
            ViewBag.fecha = new DateTime(2023,11,2);
            ViewData["Nombre"] = "Ricardo";
            //return RedirectToAction("MuestraPulques2");

            string nombre = "";
            if (TempData.ContainsKey("nombre"))
            {
                nombre = TempData["nombre"] as string;
            }
            ViewBag.nombreNuevo = nombre;
            return View();
        }
    }
}