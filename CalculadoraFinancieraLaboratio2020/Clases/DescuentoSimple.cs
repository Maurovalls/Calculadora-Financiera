using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFinancieraLaboratio2020.Clases
{
    class DescuentoSimple
    {
        public double Simple(double nominal, double descuento, double tiempo)
        {
            double descuentoSimple;
            double d = descuento / 100;
            descuentoSimple = nominal * d * tiempo;
            return descuentoSimple;
        }

        public double SimpleAñoMes(double nominal, double descuento, double tiempo)
        {
            double descuentoSimple;
            double d = descuento / 100;
            double t = tiempo / 12;
            descuentoSimple = nominal * d * t;
            return descuentoSimple;
        }

        public double SimpleMesAño(double nominal , double descuento, double tiempo)
        {
            double descuentoSimple;
            double d = descuento / 100;
            double t = tiempo * 12;
            descuentoSimple = nominal * d * t;
            return descuentoSimple;
        }

        public double SimpleRacional(double nominal, double descuento, double tiempo)
        {
            double descuentoSimple;
            double d = descuento / 100;
            double c = 1 + (d * tiempo);
            descuentoSimple = nominal / c;
            double ca = descuentoSimple * d * tiempo;
            return ca;
        }

        public double SimpleRacionalAñoMes(double nominal, double descuento, double tiempo)
        {
            double descuentoSimple;
            double d = descuento / 100;
            double t = tiempo / 12;
            double c = 1 + (d * t);
            descuentoSimple = nominal / c;
            double ca = descuentoSimple * d * t;
            return ca;
        }

        public double SimpleRacionalMesAño(double nominal, double descuento, double tiempo)
        {
            double descuentoSimple;
            double d = descuento / 100;
            double t = tiempo * 12;
            double c = 1 + (d * t);
            descuentoSimple = nominal / c;
            double ca = descuentoSimple * d * t;
            return ca;
        }
    }
}
