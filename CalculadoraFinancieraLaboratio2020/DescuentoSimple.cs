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
    public partial class DescuentoSimple : Form
    {
        double monto;
        double taza;
        double tiempo;
        public DescuentoSimple()
        {
            InitializeComponent();
        }
        Clases.DescuentoSimple descuento = new Clases.DescuentoSimple();
        private void botonCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                monto = Convert.ToDouble(textMonto.Text);
                taza = Convert.ToDouble(textDescuento.Text);
                tiempo = Convert.ToDouble(textTiempo.Text);
                if (monto <= 0 || taza < 0 || tiempo <= 0 )
                {
                    MessageBox.Show("Error, ingrese bien los datos por favor");
                }
                else
                {
                    object des = comboDescuento.SelectedItem;
                    object ti = comboTiempo.SelectedItem;
                    object ta = comboTaza.SelectedItem;
                    double resultado;
                    if (ti.Equals("Años") && ta.Equals("Años") && des.Equals("Comercial"))
                    {
                        resultado = descuento.Simple(monto, taza, tiempo);
                    }
                    else if (ti.Equals("Meses") && ta.Equals("Meses") && des.Equals("Comercial"))
                    {
                        resultado = descuento.Simple(monto, taza, tiempo);
                    }
                    else if (ti.Equals("Meses") && ta.Equals("Años") && des.Equals("Comercial"))
                    {
                        resultado = descuento.SimpleAñoMes(monto, taza, tiempo);
                    }
                    else if (ti.Equals("Años") && ta.Equals("Meses") && des.Equals("Comercial"))
                    {
                        resultado = descuento.SimpleMesAño(monto, taza, tiempo);
                    }
                    else if (ti.Equals("Años") && ta.Equals("Años") && des.Equals("Racional"))
                    {
                        resultado = descuento.SimpleRacional(monto, taza, tiempo);
                    }
                    else if (ti.Equals("Meses") && ta.Equals("Meses") && des.Equals("Racional"))
                    {
                        resultado = descuento.SimpleRacional(monto, taza, tiempo);
                    }
                    else if (ti.Equals("Año") && ta.Equals("Meses") && des.Equals("Racional"))
                    {
                        resultado = descuento.SimpleRacionalAñoMes(monto, taza, tiempo);
                    }
                    else
                    {
                        resultado = descuento.SimpleRacionalMesAño(monto, taza, tiempo);
                    }
                    MessageBox.Show("El descuento simple es : " + resultado.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error , ingreso mal los datos");
                textMonto.Clear();
                textDescuento.Clear();
                textTiempo.Clear();
            }
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            textMonto.Clear();
            textDescuento.Clear();
            textTiempo.Clear();
        }
    }
}
            
    

