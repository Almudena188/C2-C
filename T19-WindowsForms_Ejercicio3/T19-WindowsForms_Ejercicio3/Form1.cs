using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T19_WindowsForms_Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            String sistema="";
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {
                if (this.radioButton1.Checked)
                {
                    sistema = this.radioButton1.Text;
                }
                else if (this.radioButton2.Checked)
                {
                    sistema = this.radioButton2.Text;
                }
                else if (this.radioButton3.Checked)
                {
                    sistema = this.radioButton3.Text;
                }
            }
            
            String especialidad = "";
            for (int i = 0; i < clbEspecialidad.CheckedItems.Count; i++) {
                especialidad = especialidad + " " + clbEspecialidad.CheckedItems[i].ToString() + "\n";
            }
            
            MessageBox.Show("Sistema Operativo: " + sistema + "\n" +
                "Especialidad: " + especialidad + "\n" +
                "Horas dedicadas al ordenador: " + this.numHoras.Value);s
        }

        
    }
}
