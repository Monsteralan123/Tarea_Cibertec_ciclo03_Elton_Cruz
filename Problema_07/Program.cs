using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado emple = new Empleado(01,"Marcelo",94849331,3500);
            emple.listado();
            emple.NumeroCelular = 999888777;
            emple.Sueldo += 200;
            emple.listado();
            Console.ReadKey();
        }
    }
}
