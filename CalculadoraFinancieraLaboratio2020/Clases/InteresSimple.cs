using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFinancieraLaboratio2020.Clases
{
    class InteresSimple
    {
        public double SimpleAño(double importe , double taza , double tiempo)
        {
            double interes;
            double t = taza / 100;
            interes = (importe * t * tiempo);
            return interes;
        }

        public double SimpleMes(double importe, double taza, double tiempo)
        {
            double interes;
            double t = taza / 100;
            interes = (importe * t * tiempo);
            return interes;
        }

        public double SimpleDia(double importe, double taza, double tiempo)
        {
            double interes;
            double t = taza / 100;
            interes = (importe * t * tiempo);
            return interes;
        }

        public double SimpleAñoDia(double importe , double taza, double tiempo)
        {
            double interes;
            double t = taza / 100;
            interes = (importe * (t / 360) * tiempo);
            return interes;
        }

        public double SimpleAñoMes(double importe , double taza, double tiempo)
        {
            double interes;
            double t = taza / 100;
            interes = (importe * (t / 12) * tiempo);
            return interes;
        }

        public double SimpleMesAño(double importe, double taza , double tiempo)
        {
            double interes;
            double t = taza / 100;
            double ti = tiempo * 12;
            interes = importe * t * ti;
            return interes;
        }

        public double SimpleMesDia(double importe, double taza, double tiempo)
        {
            double interes;
            double t = taza / 100;
            double ta = t / 30;
            interes = importe * ta * tiempo;
            return interes;               
        }

        public double SimpleDiaMes(double importe , double taza, double tiempo)
        {
            double interes;
            double t = taza / 100;
            double ti = tiempo * 30;
            interes = importe * t * ti;
            return interes;
        }

        public double SimpleDiaAño(double importe , double taza, double tiempo)
        {
            double interes;
            double t = taza / 100;
            double ti = tiempo * 360;
            interes = importe * t * ti;
            return interes;
        }
    }
}
