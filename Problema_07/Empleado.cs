using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_07
{
    internal class Empleado
    {
        private int codigo;
        private string nombre;
        private int numeroCelular;
        private double sueldo;

        public Empleado(int codigo, string nombre, int numeroCelular, double sueldo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.numeroCelular = numeroCelular;
            this.sueldo = sueldo;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NumeroCelular { get => numeroCelular; set => numeroCelular = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public string SueldoES() {
            if (sueldo > 3500)
                return (" Mayor a 3500");
            else if (sueldo < 3500)
                return (" Menor a 3500");
            else return (" Igual a 3500");
        }
        public void listado() {

            Console.WriteLine($"Codigo empleado : {Codigo}:");
            Console.WriteLine($"Nombre empleado : {Nombre}:");
            Console.WriteLine($"Numero de celular  : {numeroCelular}:");
            Console.WriteLine($"Sueldo empleado : {Sueldo:C2}:");
            Console.WriteLine("");
            Console.WriteLine($"Su sueldo  : {SueldoES()}:");
            Console.WriteLine("");
        }
    }
}
