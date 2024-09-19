using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Computadora compu = new Computadora(001,"CyberMax","Negro",500.50);

            compu.listado();
            Console.WriteLine("Con el dolar disminuido 10%");
            compu.Dolares *=0.90;
            Console.WriteLine("");
            compu.listado();
            Console.ReadKey();



        }
    }
}
