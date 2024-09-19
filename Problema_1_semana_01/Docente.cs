using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1_semana_01
{
    internal class Docente
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int horasT { get; set; }
        public double tarifaH { get; set; }

        public Docente(int codigo, string nombre, int horasT, double tarifaH)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horasT = horasT;
            this.tarifaH = tarifaH;
        }

        public double SueldoBruto() {
            return (horasT*tarifaH);
        }
        public double Descuento() {
            if (SueldoBruto() < 4500)
                return (SueldoBruto()*0.12);
            else if (SueldoBruto() >= 4500 || SueldoBruto() < 6000)
                return (SueldoBruto() * 0.14);
            else return (SueldoBruto() * 0.16);

        }
        public double SueldoNeto() {

            return SueldoBruto() - Descuento();
        }


    }
}
