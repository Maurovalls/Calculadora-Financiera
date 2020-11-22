using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFinancieraLaboratio2020.Clases
{
    class InteresCompuesto
    {

        public double Compuesto(double importe, double taza, double tiempo)
        {
            double interes;
            double t = taza / 100;
            double ta = t + 1;
            double taz = Math.Pow(ta, tiempo);
            interes = importe * taz;
            return interes;
        }

        public double CompuestoAñoMes(double importe, double taza, double tiempo)
        {
            double interes;
            double t = taza / 100;
            double n = tiempo / 12;
            double ta = t + 1;
            double taz = Math.Pow(ta,n);
            interes = importe * taz;
            return interes;          
        }

        public double CompuestoMesAño(double importe, double taza, double tiempo)
        {
            double interes;
            double t = taza / 100;
            double n = tiempo / 30;
            double ta = t + 1;
            double taz = Math.Pow(ta, n);
            interes = importe * taz;
            return interes;
        }

    }
}
