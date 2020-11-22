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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void operacionesBasicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new CalculadoraBasica();
            formulario.Show();
        }

        private void interesSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new InteresSimple();
            formulario.Show();
        }

        private void interesCompuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new InteresCompuesto();
            formulario.Show();
        }

        private void descuentoSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new DescuentoSimple();
            formulario.Show();
        }

        private void descuentoCompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Monto();
            formulario.Show();
        }

        private void amortizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Depositar();
            formulario.Show();
        }
    }
}
