using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class video
    {
        private int codigo;
        private string nombreV;
        private double duracion;
        private double precioS;
        private double tipoCambio;

        public video(int codigo, string nombreV, double duracion, double precioS, double tipoCambio)
        {
            this.codigo = codigo;
            this.nombreV = nombreV;
            this.duracion = duracion;
            this.precioS = precioS;
            this.tipoCambio = tipoCambio;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string NombreV { get => nombreV; set => nombreV = value; }
        public double Duracion { get => duracion; set => duracion = value; }
        public double PrecioS { get => precioS; set => precioS = value; }
        public double TipoCambio { get => tipoCambio; set => tipoCambio = value; }

        public double PrecioDolar()
        {
            return PrecioS / TipoCambio;
        }

        public void listado() {

            Console.WriteLine($"Codigo de video : {Codigo}:");
            Console.WriteLine($"Nombre del video : {NombreV}:");
            Console.WriteLine($"Duracion del video : {Duracion}:");
            Console.WriteLine($"Precio en Soles : {PrecioS:F2}:");
            Console.WriteLine($"Tipo de Cambio_Dolar : {TipoCambio}:");
            Console.WriteLine($"Precio en Doalar : {PrecioDolar():C1}");
            Console.WriteLine("");

        }
    }

}
