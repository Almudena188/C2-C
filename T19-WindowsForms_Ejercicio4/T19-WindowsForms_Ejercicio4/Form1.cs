using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T19_WindowsForms_Ejercicio4
{
    public partial class Form1 : Form
    {
        String solucion = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(tbNum1.Text);
            double num2 = double.Parse(tbNum2.Text);

            solucion = "" + (num1 + num2);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            this.tbResultado.ResetText();
            this.tbResultado.Text = solucion;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(tbNum1.Text);
            double num2 = double.Parse(tbNum2.Text);

            solucion = "" + (num1 - num2);
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(tbNum1.Text);
            double num2 = double.Parse(tbNum2.Text);

            solucion = "" + (num1 * num2);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(tbNum1.Text);
            double num2 = double.Parse(tbNum2.Text);

            solucion = "" + (num1 / num2);
        }
    }
}
