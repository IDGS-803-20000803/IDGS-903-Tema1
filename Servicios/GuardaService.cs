using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Servicios
{
    public class GuardaService
    {
        public void GuardarArchivo(Maestros maes)
        {
            var mat = maes.Matricula;
            var nom = maes.Nombre;
            var ape = maes.Apaterno;
            var ama = maes.Amaterno;
            var email = maes.Email;
            var datos = mat + "," + nom + "," + ape + "," + ama + "," + email+Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            File.AppendAllText(archivo, datos);
        }

        public void RegistrarPalabra(Diccionario dic)
        {
            var esp = dic.Espanol;
            var ing = dic.Ingles;

            var datos = esp + ',' + ing + Environment.NewLine;

            var conversion = datos.ToLower();

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");
            File.AppendAllText(archivo, conversion);
        }
    }
}