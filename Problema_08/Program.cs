using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asesor ase = new Asesor(1, "María López", 40, 50.00); 
            
            ase.Listado();
            ase.HorasTrabajadas += 10; 
            ase.TarifaPorHora *= 0.85;
            ase.Listado();
            Console.ReadKey();
        }
    }
}
