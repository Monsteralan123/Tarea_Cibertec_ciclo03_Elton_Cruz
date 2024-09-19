using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_09
{
    internal class Pelota
    {
        private string marca;
        private double pesoGramos; 
        private double presionLibras; 
        private double diametroCenti; 
        private double precio;

        public Pelota(string marca, double pesoGramos, double presionLibras, double diametroCenti, double precio)
        {
            this.marca = marca;
            this.pesoGramos = pesoGramos;
            this.presionLibras = presionLibras;
            this.diametroCenti = diametroCenti;
            this.precio = precio;
        }

        public string Marca { get => marca; set => marca = value; }
        public double PesoGramos { get => pesoGramos; set => pesoGramos = value; }
        public double PresionLibras { get => presionLibras; set => presionLibras = value; }
        public double DiametroCenti { get => diametroCenti; set => diametroCenti = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Radio() {
            return diametroCenti / 2;
        }
        public double Volumen() {
            return (4 * 3.1416 * Radio() * Radio() * Radio() / 3);
        }
        public double Descuento(){
            return precio * 0.10; 
        }
        public double ImporteTotal() {
            return precio - Descuento();           
        }
        public void listado() {

            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Peso: {PesoGramos} g");
            Console.WriteLine($"Presión: {PresionLibras} lb");
            Console.WriteLine($"Diámetro: {DiametroCenti} cm");
            Console.WriteLine($"Precio: {Precio:F2}");
            Console.WriteLine($"Radio: {Radio()} cm");
            Console.WriteLine($"Volumen: {Volumen():F2} cm³");
            Console.WriteLine($"Descuento: {Descuento():F2}");
            Console.WriteLine($"Importe a Pagar: {ImporteTotal():F2}");
            Console.WriteLine("");  
        }
    }
}
