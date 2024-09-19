using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_01
{
    internal class Celular
    {

        private int numero;
        private string usuario;
        private int segundoCon;
        private double precioxSegundo;

        public Celular(int numero, string usuario, int segundoCon, double precioxSegundo)
        {
            this.numero = numero;
            this.usuario = usuario;
            this.segundoCon = segundoCon;
            this.precioxSegundo = precioxSegundo;
        }

        public int Numero { get => numero; set => numero = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public int SegundoCon { get => segundoCon; set => segundoCon = value; }
        public double PrecioxSegundo { get => precioxSegundo; set => precioxSegundo = value; }

        public double CostoConsumo() {
            return (segundoCon * precioxSegundo);
                }
        public double IGV() {
            return (CostoConsumo() * 0.18);
        }
        public double TotalPago() {
            return (CostoConsumo() + IGV());
        }

        public void listado() {
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Usuario: {Usuario}");
            Console.WriteLine($"Segundos Consumidos: {SegundoCon}");
            Console.WriteLine($"Precio por Segundo: {PrecioxSegundo:C}"); /*:C para que que tenga solo 2 decimales y aparezca simbolo de plata*/
            Console.WriteLine($"Costo por Consumo: {CostoConsumo():C}");
            Console.WriteLine($"Impuesto IGV: {IGV():C}");
            Console.WriteLine($"Total a Pagar: {TotalPago():C}");
        }
    }
}
