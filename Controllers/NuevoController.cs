using IDGS903_Tema1.Models;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class NuevoController : Controller
    {
        // GET: Nuevo
        public ActionResult Ventana()
        {
            return View();
        }

        public ActionResult Calculos(int n1, int n2)
        {
            int res = Convert.ToInt16(n1)+ Convert.ToInt16(n2); 
            ViewBag.Res = Convert.ToString(res);
            return View();
        }

        public ActionResult Ventana2(OperasBas op, String operacion)
        {
            op.Operacion(operacion);  
            var model = new OperasBas();
            model.Res = op.Res;
           
            
            return View(model);
        }
    }
}