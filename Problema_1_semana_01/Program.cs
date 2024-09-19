using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1_semana_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Docente doce = new Docente(100, "Miguel", 100, 30);

            Console.WriteLine($"Código: {doce.codigo}");
            Console.WriteLine($"Nombre: {doce.nombre}");
            Console.WriteLine($"Horas Trabajadas: {doce.horasT}");
            Console.WriteLine($"Tarifa por Hora: {doce.tarifaH:C}");
            Console.WriteLine($"Sueldo Bruto: {doce.SueldoBruto():C}");
            Console.WriteLine($"Descuento: {doce.Descuento():C}");
            Console.WriteLine($"Sueldo Neto: {doce.SueldoNeto():C}");
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
