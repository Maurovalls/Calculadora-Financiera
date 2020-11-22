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
    public partial class InteresCompuesto : Form
    {
        double importe2;
        double taza2;
        double tiempo2;
        public InteresCompuesto()
        {
            InitializeComponent();
        }

        Clases.InteresCompuesto interes = new Clases.InteresCompuesto();
        private void botonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                importe2 = Convert.ToDouble(textImporte2.Text);
                 taza2 = Convert.ToDouble(textTaza2.Text);
                 tiempo2 = Convert.ToDouble(textTiempo2.Text);
            if (importe2 <= 0 || taza2 < 0 || tiempo2 <= 0 )
            {
                MessageBox.Show("Error, ingrese bien los datos por favor");
            }
            else
            {
                object ti = comboTiempo2.SelectedItem;
                object ta = comboTaza2.SelectedItem;
                double resultado2;
                if (ti.Equals("Años") && ta.Equals("Años"))
                {
                    resultado2 = interes.Compuesto(importe2, taza2, tiempo2);
                }
                else if (ti.Equals("Meses") && ta.Equals("Meses"))
                {
                    resultado2 = interes.Compuesto(importe2, taza2, tiempo2);
                }
                else if (ti.Equals("Meses") && ta.Equals("Años"))
                {
                    resultado2 = interes.CompuestoAñoMes(importe2, taza2, tiempo2);
                }
                else
                {
                    resultado2 = interes.CompuestoMesAño(importe2, taza2, tiempo2);
                }
                MessageBox.Show("El interes compuesto es : " + resultado2.ToString());
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error , ingreso mal los datos");
                textImporte2.Clear();
                textTaza2.Clear();
                textTiempo2.Clear();
            }

        }
        private void botonBorrar_Click(object sender, EventArgs e)
        {
            textImporte2.Clear();
            textTaza2.Clear();
            textTiempo2.Clear();
        }
    }
}
