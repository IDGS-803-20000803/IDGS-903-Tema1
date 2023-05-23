using IDGS903_Tema1.Models;
using IDGS903_Tema1.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class DiccionarioController : Controller
    {
        // GET: Diccionario
        public ActionResult Registrar()
        {
            var dd = new LeerService();
            ViewBag.Palabras = dd.LeerDiccionario();
            ViewBag.Tabla = false;

            return View();
        }
        [HttpPost]
        public ActionResult Registrar(Diccionario dic)
        {
            var op = new GuardaService();
            var rd = new LeerService();

            op.RegistrarPalabra(dic);

            ViewBag.Palabras = rd.LeerDiccionario();

            ViewBag.Tabla = false;

            return View();
        }

        public ActionResult MostrarPalabras()
        {
            var dic = new LeerService();
            ViewBag.Palabras = dic.LeerDiccionario();

            return View();
        }

        public ActionResult Traductor(string Palabra, string Lenguaje)
        {
            var Traduccion = "";
            var dic = new LeerService();
            var palabras = dic.LeerDiccionario();

            bool TraduccionEncontrada = false;

            foreach (string item in palabras)
            {
                string[] tupla = item.Split(',');

                if (Lenguaje == "Ingles")
                {
                    if (Palabra.ToLower() == tupla[0])
                    {
                        Traduccion = tupla[1];
                        TraduccionEncontrada = true;
                    }
                }
                else if (Lenguaje == "Español")
                {
                    if (Palabra.ToLower() == tupla[1])
                    {
                        Traduccion = tupla[0];
                        TraduccionEncontrada = true;
                    }
                }

                if (TraduccionEncontrada == false)
                {
                    Traduccion = "No hay traducción para: " + Palabra;
                }
            }


            ViewBag.Resultado = Traduccion;
            return View();
        }


    }
}