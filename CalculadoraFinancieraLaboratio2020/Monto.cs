using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraFinancieraLaboratio2020
{
    public partial class Monto : Form
    {
        double importe;
        double interes;
        public Monto()
        {
            InitializeComponent();
        }
        Clases.Monto montoFinal = new Clases.Monto();
        private void botonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                importe = Convert.ToDouble(textImporte.Text);
                interes = Convert.ToDouble(textInteres.Text);
                if (importe <= 0 || interes < 0)
                {
                    MessageBox.Show("Error, ingrese bien los datos por favor");
                }
                else
                {
                    double resultado;
                    resultado = montoFinal.MontoFinal(importe, interes);
                    MessageBox.Show("El monto final es : " + resultado.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error , ingreso mal los datos");
                textImporte.Clear();
                textInteres.Clear();
            }
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            textImporte.Clear();
            textInteres.Clear();
        }
    }
}

