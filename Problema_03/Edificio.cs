using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_03
{
    internal class Edificio
    {
        private int codigo;
        private int numeroDepa;
        private int canPisos;
        private double precioDepaDolares;

        public Edificio(int codigo, int numeroDepa, int canPisos, double precioDepaDolares)
        {
            this.codigo = codigo;
            this.numeroDepa = numeroDepa;
            this.canPisos = canPisos;
            this.precioDepaDolares = precioDepaDolares;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public int NumeroDepa { get => numeroDepa; set => numeroDepa = value; }
        public int CanPisos { get => canPisos; set => canPisos = value; }
        public double PrecioDepaDolares { get => precioDepaDolares; set => precioDepaDolares = value; }

        public double PrecioEdificio() {
            return (numeroDepa * PrecioDepaDolares);
        }
        public void listado() {

            Console.WriteLine($"Codigo edificio : {codigo}:");
            Console.WriteLine($"Numero de Departamentos : {numeroDepa}:");
            Console.WriteLine($"Cantidad de pisos : {canPisos}:");
            Console.WriteLine($"Precio de cada departamento : {PrecioDepaDolares:C}");
            Console.WriteLine($"Precio en Soles:{PrecioEdificio():C}");
        }

    }
}
