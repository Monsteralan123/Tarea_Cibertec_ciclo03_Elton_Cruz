using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Paciente
    {

        private string nombre;
        private string apellido;
        private int edad;
        private double talla;
        private double peso;


        public Paciente(string nombre, string apellido, int edad, double talla, double peso)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Talla = talla;
            this.Peso = peso;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Talla { get => talla; set => talla = value; }
        public double Peso { get => peso; set => peso = value; }

        public string menorEdad()
        {
            if (Edad < 18)
                return ("Eres menor");
            else
                return ("Eres Mayor");

        }

        public void listado() {

            Console.WriteLine($"Nombre paciente : {Nombre}:");
            Console.WriteLine($"Apellido paciencia : {Apellido}:");
            Console.WriteLine($"Edad : {Edad}:");
            Console.WriteLine($"Peso paciente : {Peso}:");
            Console.WriteLine($"Talla paciente : {Talla}:");
            Console.WriteLine($"Eres ?? : {menorEdad()}:");
            Console.WriteLine("");

        }
    }

}
