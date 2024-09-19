using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Edificio edi = new Edificio(010, 20, 4, 400.20);
            edi.listado();
            Console.WriteLine("");
            Console.WriteLine("Precio del Departamneto aumento en 20%");
            edi.PrecioDepaDolares *= 1.20;
            Console.WriteLine("");
            edi.listado();
            Console.ReadKey(); 
        }
    }
}
