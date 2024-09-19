using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_04
{
    internal class Obrero
    {
        private int codigo;
        private string nombre;
        private int horasTrabajadas;
        private double tarifaxHora;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int HorasTrabajadas { get => horasTrabajadas; set => horasTrabajadas = value; }
        public double TarifaxHora { get => tarifaxHora; set => tarifaxHora = value; }

        public Obrero(int codigo, string nombre, int horasTrabajadas, double tarifaxHora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horasTrabajadas = horasTrabajadas;
            this.tarifaxHora = tarifaxHora;
        }
        public double SueldoBruto()
        {
            return (
                horasTrabajadas * tarifaxHora
                );
        }
        public double AFP()
        {
            return (
                SueldoBruto() * 0.10
                );
        }
        public double EPS()
        {
            return (
                SueldoBruto() * 0.05
                );
        }
        public double sueldoNeto()
        {
            return (
                (SueldoBruto() - AFP()) - EPS()
                );
        }
        public void listado() {

            Console.WriteLine($"Codigo Obrero : {codigo}:");
            Console.WriteLine($"Nombre Obrero : {nombre}:");
            Console.WriteLine($"Horas trabajadas : {horasTrabajadas}:");
            Console.WriteLine($"Tarifa por hora : {tarifaxHora:C}");
            Console.WriteLine($"Sueldo Bruto:{SueldoBruto():C}");
            Console.WriteLine($"AFP:{AFP():C}");
            Console.WriteLine($"EPS:{EPS():C}");
            Console.WriteLine($"Sueldo Neto:{sueldoNeto():C}");
        }
    }
}
