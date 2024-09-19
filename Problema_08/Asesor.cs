using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_08
{
    internal class Asesor
    {
        private int codigo;
        private string nombre;
        private int horasTrabajadas;
        private double tarifaPorHora;

        public Asesor(int codigo, string nombre, int horasTrabajadas, double tarifaPorHora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horasTrabajadas = horasTrabajadas;
            this.tarifaPorHora = tarifaPorHora;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int HorasTrabajadas { get => horasTrabajadas; set => horasTrabajadas = value; }
        public double TarifaPorHora { get => tarifaPorHora; set => tarifaPorHora = value; }

        public double SueldoBruto()
        {
            return horasTrabajadas * tarifaPorHora;
        }
        public double Descuento()
        {
            return SueldoBruto() * 0.15; 
        }
        public double SueldoNeto() { 
            return SueldoBruto() - Descuento();
        }
        public void Listado()
        {
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Horas Trabajadas: {HorasTrabajadas}");
            Console.WriteLine($"Tarifa por Hora: {TarifaPorHora:C}");
            Console.WriteLine($"Sueldo Bruto: {SueldoBruto():C}");
            Console.WriteLine($"Descuento: {Descuento():C}");
            Console.WriteLine($"Sueldo Neto: {SueldoNeto():C}");
            Console.WriteLine("");
        }

    }
}
