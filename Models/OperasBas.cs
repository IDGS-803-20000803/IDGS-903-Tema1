using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Models
{
    public class OperasBas
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Res { get; set; }


        public void Sumar()
        {
            this.Res = this.Num1 + this.Num2;
        }

        public void Resta()
        {
            this.Res = this.Num1 - this.Num2;
        }

        public void Multiplicacion()
        {
            this.Res = this.Num1 * this.Num2;
        }

        public void Division()
        {
            this.Res = this.Num1 / this.Num2;
        }

        public void Operacion(String operacion)
        {
            switch (operacion)
            {
                case "suma":
                    Sumar();
                    break;
                case "resta":
                    Resta();
                    break;
                case "multiplicacion":
                    Multiplicacion();
                    break;
                case "division":
                    Division();
                    break;
            }
        }

    }
}