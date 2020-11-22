using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFinancieraLaboratio2020.Clases
{
    class Division
    {
        public double Dividir(double numeroUno, double numeroDos)
        {
            if (numeroDos == 0)
            {
                throw new Exception();
            }
            else
            {
                double div;
                div = numeroUno / numeroDos;
                return div;
            }
        }
    }
}
