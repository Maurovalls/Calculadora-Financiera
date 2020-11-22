using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFinancieraLaboratio2020.Clases
{
    class Depositar
    {
        public double Deposita(double valorFinal , double taza, double tiempo)
        {
            double valorDepositar;
            double t = (taza / 100) + 1;
            double resul = Math.Pow(t,5);
            valorDepositar = valorFinal / resul;
            return valorDepositar;
        }
    }
}
