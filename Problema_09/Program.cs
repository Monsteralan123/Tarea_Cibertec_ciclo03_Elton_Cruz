using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pelota pelo = new Pelota("Nike", 400.0, 12.0, 22.0, 50.00);
            pelo.listado();
            pelo.Precio *= 0.75;
            pelo.DiametroCenti += 1;
            pelo.listado();
            Console.ReadKey();  
        }
    }
}
