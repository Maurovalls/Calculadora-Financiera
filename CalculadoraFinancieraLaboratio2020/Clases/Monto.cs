using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFinancieraLaboratio2020.Clases
{
    class Monto
    {
        public double MontoFinal(double importe, double interes)
        {
            double monto;
            monto = importe + interes;
            return monto;
        }
    }
}
