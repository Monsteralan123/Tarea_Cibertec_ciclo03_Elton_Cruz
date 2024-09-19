using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            video vi = new video(100, "titanic", 90.43, 30, 3.25);

            vi.listado();
            vi.PrecioS += 5.50;
            vi.listado();
            Console.ReadKey();  
        }
    }
}
