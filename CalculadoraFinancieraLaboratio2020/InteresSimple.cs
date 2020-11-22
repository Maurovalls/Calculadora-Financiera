using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraFinancieraLaboratio2020
{
    public partial class InteresSimple : Form
    {
        double importe;
        double taza;
        double tiempo;
        public InteresSimple()
        {
            InitializeComponent();
        }

        Clases.InteresSimple interes = new Clases.InteresSimple();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                importe = Convert.ToDouble(textImporte.Text);
                taza = Convert.ToDouble(textTaza.Text);
                tiempo = Convert.ToDouble(textTiempo.Text);
                if (importe <= 0 || taza < 0 || tiempo <= 0)
                {
                    MessageBox.Show("Error, ingrese bien los datos por favor");
                }
                else
                {
                    object ti = comboTiempo.SelectedItem;
                    object ta = comboTaza.SelectedItem;
                    double resultado;
                    if (ti.Equals("Años") && ta.Equals("Años") )
                    {
                        resultado = interes.SimpleAño(importe, taza, tiempo);
                    }
                    else if (ti.Equals("Meses") && ta.Equals("Meses"))
                    {
                        resultado = interes.SimpleMes(importe, taza, tiempo);
                    }
                    else if (ti.Equals("Dias") && ta.Equals("Dias"))
                    {
                        resultado = interes.SimpleDia(importe, taza, tiempo);
                    }
                    //Año Dias y Años Meses
                    else if (ti.Equals("Dias") && ta.Equals("Años"))
                    {
                        resultado = interes.SimpleAñoDia(importe, taza, tiempo);
                    }
                    else if (ti.Equals("Meses") && ta.Equals("Años"))
                    {
                        resultado = interes.SimpleAñoMes(importe, taza, tiempo);
                    }
                    //Meses Dias y Meses Años
                    else if (ti.Equals("Dias") && ta.Equals("Meses"))
                    {
                        resultado = interes.SimpleMesDia(importe, taza, tiempo);
                    }
                    else if (ti.Equals("Años") && ta.Equals("Meses"))
                    {
                        resultado = interes.SimpleMesAño(importe, taza, tiempo);
                    }
                    // Dias Meses y Dias Años
                    else if (ti.Equals("Meses") && ta.Equals("Dias"))
                    {
                        resultado = interes.SimpleDiaMes(importe, taza, tiempo);
                    }
                    else
                    {
                        resultado = interes.SimpleDiaAño(importe, taza, tiempo);
                    }                  
                    MessageBox.Show("El interes simple es : " + resultado.ToString());                                                
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
