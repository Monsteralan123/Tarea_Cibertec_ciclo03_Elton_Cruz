using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular miCelular = new Celular(123456789, "Juan Perez", 100, 0.50);


            miCelular.listado();

            miCelular.SegundoCon += 20;
            miCelular.PrecioxSegundo *= 0.95;

            Console.WriteLine("");

            miCelular.listado();

            Console.ReadKey();
        }
    }
}
