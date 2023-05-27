using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Models
{
    public class Coordenadas
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }

        public int X2 { get; set; }
        public int Y2 { get; set; }

        public int X3 { get; set; }
        public int Y3 { get; set; } 

        public Double LadoAB { get; set; }
        public Double LadoAC { get; set; }
        public Double LadoBC { get; set;}

        public String Resultado { get; set; }

        public String Area { get; set; }

        public Double AreaTotal { get; set; }  

        public Double SemiPerimetro { get; set; }


        public void DistanciaPuntos()
        {
            this.LadoAB = Math.Round(Math.Sqrt((Math.Pow((this.X2 - this.X1), 2)) + (Math.Pow((this.Y2 - this.Y1), 2))));
            this.LadoAC = Math.Round(Math.Sqrt((Math.Pow((this.X3 - this.X1), 2)) + (Math.Pow((this.Y3 - this.Y1), 2))));
            this.LadoBC = Math.Round(Math.Sqrt((Math.Pow((this.X3 - this.X2), 2)) + (Math.Pow((this.Y3 - this.Y2), 2))));

            if (Forma(this.LadoAB, this.LadoAC, this.LadoBC))
            {
                TipoTriangulo(this.LadoAB, this.LadoAC, this.LadoBC);

            }
            else
            {
                this.Resultado = "No es un triangulo";
                this.Area = "No hay un Area que calcular";
            }

        }

        public bool Forma(double lado1, double lado2, double lado3)
        {
            if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
            {
                return true;
            }
            return false;
        }

        public void TipoTriangulo(double lado1, double lado2, double lado3)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
               this.Resultado= "Equilátero";
                CalcularArea(lado1, lado2, lado3);
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                this.Resultado= "Isósceles";
                CalcularArea(lado1, lado2, lado3);
            }
            else
            {
                this.Resultado= "Escaleno";
                CalcularArea(lado1, lado2, lado3);
            }
        }

        public void CalcularArea(double lado1, double lado2, double lado3)
        {
            
           this.SemiPerimetro = (lado1 + lado2 + lado3) / 2;
           this.AreaTotal = Math.Sqrt(this.SemiPerimetro * ((this.SemiPerimetro * lado1) * (this.SemiPerimetro * lado2) * (this.SemiPerimetro * lado3)));
            this.Area = "El Area del trinagulo es: "+this.AreaTotal;
        }






    }
}