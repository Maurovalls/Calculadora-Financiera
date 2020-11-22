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
    public partial class CalculadoraBasica : Form
    {
        double primero;
        double segundo;
        string operador;
        public CalculadoraBasica()
        {
            InitializeComponent();
        }

        Clases.Suma obj = new Clases.Suma();
        Clases.Resta obj2 = new Clases.Resta();
        Clases.Multiplicacion obj3 = new Clases.Multiplicacion();
        Clases.Division obj4 = new Clases.Division();
        private void botonCero_Click(object sender, EventArgs e)
        {
            textPantalla.Text = textPantalla.Text + "0";
        }

        private void botonUno_Click(object sender, EventArgs e)
        {
            textPantalla.Text = textPantalla.Text + "1";
        }

        private void botonDos_Click(object sender, EventArgs e)
        {
            textPantalla.Text = textPantalla.Text + "2";
        }

        private void botonTres_Click(object sender, EventArgs e)
        {
            textPantalla.Text = textPantalla.Text + "3";
        }

        private void botonCuatro_Click(object sender, EventArgs e)
        {
            textPantalla.Text = textPantalla.Text + "4";
        }

        private void botonCinco_Click(object sender, EventArgs e)
        {
            textPantalla.Text = textPantalla.Text + "5";
        }

        private void botonSeis_Click(object sender, EventArgs e)
        {
            textPantalla.Text = textPantalla.Text + "6";
        }

        private void botonSiete_Click(object sender, EventArgs e)
        {
            textPantalla.Text = textPantalla.Text + "7";
        }

        private void botonOcho_Click(object sender, EventArgs e)
        {
            textPantalla.Text = textPantalla.Text + "8";
        }

        private void botonNueve_Click(object sender, EventArgs e)
        {
            textPantalla.Text = textPantalla.Text + "9";
        }

        private void botonPunto_Click(object sender, EventArgs e)
        {
            textPantalla.Text = textPantalla.Text + ".";
        }

        private void CalculadoraBasica_Load(object sender, EventArgs e)
        {

        }

        private void botonSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = Convert.ToDouble(textPantalla.Text);
            textPantalla.Clear();
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = Convert.ToDouble(textPantalla.Text);
            textPantalla.Clear();
        }

        private void botonMulti_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = Convert.ToDouble(textPantalla.Text);
            textPantalla.Clear();
        }

        private void botonDividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = Convert.ToDouble(textPantalla.Text);
            textPantalla.Clear();
        }

        private void botonIgual_Click(object sender, EventArgs e)
        {
            try
            {
                segundo = Convert.ToDouble(textPantalla.Text);
                double s;
                double r;
                double m;
                double d;

                switch (operador)
                {
                    case "+":
                        s = obj.Sumar(primero, segundo);
                        textPantalla.Text = s.ToString();
                        break;
                    case "-":
                        r = obj2.Restar(primero, segundo);
                        textPantalla.Text = r.ToString();
                        break;
                    case "*":
                        m = obj3.Multiplicar(primero, segundo);
                        textPantalla.Text = m.ToString();
                        break;
                    case "/":
                        d = obj4.Dividir(primero, segundo);
                        textPantalla.Text = d.ToString();
                        break;
                }
            }catch(Exception ex)
            {
                
                textPantalla.Text = "Math ERROR"+ex;
            }
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            textPantalla.Clear();
        }

        private void botonRetroceder_Click(object sender, EventArgs e)
        {
            if(textPantalla.Text.Length == 1)
            {
                textPantalla.Text = "";
            }
            else
            {
                textPantalla.Text = textPantalla.Text.Substring(0, textPantalla.Text.Length - 1);
            }
        }
    }
}
