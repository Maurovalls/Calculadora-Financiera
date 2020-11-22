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
    public partial class Depositar : Form
    {
        double importeDeseado;
        double taza;
        double tiempo;
        public Depositar()
        {
            InitializeComponent();
        }
        Clases.Depositar interes = new Clases.Depositar();

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                importeDeseado = Convert.ToDouble(textImporte.Text);
                taza = Convert.ToDouble(textTaza.Text);
                tiempo = Convert.ToDouble(textTiempo.Text);
                if (importeDeseado <= 0 || taza < 0 || tiempo <= 0)
                {
                    MessageBox.Show("Error, ingrese bien los datos por favor");
                }
                else
                {
                    object ti = comboElegir.SelectedItem;
                    double resultado;
                    if (ti.Equals("Años"))
                    {
                        resultado = interes.Deposita(importeDeseado, taza, tiempo);
                    }
                    else
                    {
                        resultado = interes.Deposita(importeDeseado, taza, tiempo);
                    }
                    MessageBox.Show("El dinero a depositar para poder obtener "+importeDeseado+" es de: " + resultado.ToString());
                }
                }
            catch(Exception ex)
            {
                MessageBox.Show("Error , ingreso mal los datos");
                textImporte.Clear();
                textTaza.Clear();
                textTiempo.Clear();
            }


        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            textImporte.Clear();
            textTaza.Clear();
            textTiempo.Clear();
        }
    }
}
