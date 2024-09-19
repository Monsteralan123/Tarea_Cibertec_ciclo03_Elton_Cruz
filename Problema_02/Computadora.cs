using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_02
{
    internal class Computadora
    {


        private int codigo;
        private string marca;
        private string color;
        private double dolares;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Color { get => color; set => color = value; }
        public double Dolares { get => dolares; set => dolares = value; }

        public Computadora(int codigo, string marca, string color, double dolares)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.color = color;
            this.dolares = dolares;
        }
        public double PrecioComputadoraSol() {
            return (dolares * 3.35);
        }
        public double PrecioComputadoraEuro() {
            return (dolares / 1.20);
        }

        public void listado() {
            Console.WriteLine($"Codigo de Computadora: {codigo}");
            Console.WriteLine($"Marca de Computadora: {marca}");
            Console.WriteLine($"Color de Computadora: {color}");
            Console.WriteLine($"Precio Dolares: {dolares:C}");
            Console.WriteLine("");
            Console.WriteLine($"Precio en Soles: {PrecioComputadoraSol():C}");
            Console.WriteLine($"Precio en Euros: {PrecioComputadoraEuro():C}");
            Console.WriteLine("");
        }

    }
}
