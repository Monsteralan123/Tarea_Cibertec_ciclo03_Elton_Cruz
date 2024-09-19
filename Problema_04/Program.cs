using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obrero obre = new Obrero(12, "Mario Hugo", 80, 30.30);

            obre.listado();
            Console.WriteLine("");
            obre.HorasTrabajadas += 8;
            obre.TarifaxHora /= 1.015;
            Console.WriteLine("Horas aumentadas 8 y tarifa disminuida en 1.5%");
            Console.WriteLine("");
            obre.listado();

            Console.ReadKey();
        }
    }
}
