using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente paci = new Paciente("Mariano", "Lorez", 14, 1.70, 80.2);
            paci.listado();
            paci.Edad = 30;
            paci.listado();
            Console.ReadKey();
        }
    }
}
