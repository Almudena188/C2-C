using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3enRaya
{

    public partial class Form1 : Form
    {

        int estado = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                if (estado == 1)
                {
                    button1.Text = "X";
                }
                if (estado == 2)
                {
                    button1.Text = "O";
                }
                cambioTurno();
                compruebaGanador();
            }
            else {
                MessageBox.Show("Este cuadro ya esta ocupado");
            }



        }

        private  void cambioTurno() {
            if (estado == 1) {
                this.labelTurno.Text = this.tbNombreJugador1.Text + ", coloca ficha...";
                estado = 2;
            }
            else
            {
                this.labelTurno.Text = this.tbNombreJugador2.Text + ", coloca ficha...";
                estado = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                if (estado == 1)
                {
                    button2.Text = "X";
                }
                if (estado == 2)
                {
                    button2.Text = "O";
                }
                cambioTurno();
                compruebaGanador();
            }
            else
            {
                MessageBox.Show("Este cuadro ya esta ocupado");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                if (estado == 1)
                {
                    button3.Text = "X";
                }
                if (estado == 2)
                {
                    button3.Text = "O";
                }
                cambioTurno();
                compruebaGanador();
            }
            else
            {
                MessageBox.Show("Este cuadro ya esta ocupado");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                if (estado == 1)
                {
                    button4.Text = "X";
                }
                if (estado == 2)
                {
                    button4.Text = "O";
                }
                cambioTurno();
                compruebaGanador();
            }
            else
            {
                MessageBox.Show("Este cuadro ya esta ocupado");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                if (estado == 1)
                {
                    button5.Text = "X";
                }
                if (estado == 2)
                {
                    button5.Text = "O";
                }
                cambioTurno();
                compruebaGanador();
            }
            else
            {
                MessageBox.Show("Este cuadro ya esta ocupado");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                if (estado == 1)
                {
                    button6.Text = "X";
                }
                if (estado == 2)
                {
                    button6.Text = "O";
                }
                cambioTurno();
                compruebaGanador();
            }
            else
            {
                MessageBox.Show("Este cuadro ya esta ocupado");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                if (estado == 1)
                {
                    button7.Text = "X";
                }
                if (estado == 2)
                {
                    button7.Text = "O";
                }
                cambioTurno();
                compruebaGanador();
            }
            else
            {
                MessageBox.Show("Este cuadro ya esta ocupado");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                if (estado == 1)
                {
                    button8.Text = "X";
                }
                if (estado == 2)
                {
                    button8.Text = "O";
                }
                cambioTurno();
                compruebaGanador();
            }
            else
            {
                MessageBox.Show("Este cuadro ya esta ocupado");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                if (estado == 1)
                {
                    button9.Text = "X";
                }
                if (estado == 2)
                {
                    button9.Text = "O";
                }
                cambioTurno();
                compruebaGanador();
            }
            else
            {
                MessageBox.Show("Este cuadro ya esta ocupado");
            }
        }
        private void compruebaGanador() {
            //posiciones ganadoras horizontales
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text !="") {
                if (button3.Text == "X") {
                    MessageBox.Show("Ha ganado el jugador 1" + this.tbNombreJugador1.Text);
                }
                else
                {
                    MessageBox.Show("Ha ganado el jugador 2: " + this.tbNombreJugador2.Text);
                }
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                if (button5.Text == "X")
                {
                    MessageBox.Show("Ha ganado el jugador 1" + this.tbNombreJugador1.Text);
                }
                else
                {
                    MessageBox.Show("Ha ganado el jugador 2: " + this.tbNombreJugador2.Text);
                }
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                if (button7.Text == "X")
                {
                    MessageBox.Show("Ha ganado el jugador 1" + this.tbNombreJugador1.Text);
                }
                else
                {
                    MessageBox.Show("Ha ganado el jugador 2: " + this.tbNombreJugador2.Text);
                }
            }
            //posiciones ganadoras verticales
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                if (button4.Text == "X")
                {
                    MessageBox.Show("Ha ganado el jugador 1" + this.tbNombreJugador1.Text);
                }
                else
                {
                    MessageBox.Show("Ha ganado el jugador 2: " + this.tbNombreJugador2.Text);
                }
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text != "")
            {
                if (button8.Text == "X")
                {
                    MessageBox.Show("Ha ganado el jugador 1" + this.tbNombreJugador1.Text);
                }
                else
                {
                    MessageBox.Show("Ha ganado el jugador 2: " + this.tbNombreJugador2.Text);
                }
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button6.Text != "")
            {
                if (button9.Text == "X")
                {
                    MessageBox.Show("Ha ganado el jugador 1" + this.tbNombreJugador1.Text);
                }
                else
                {
                    MessageBox.Show("Ha ganado el jugador 2: " + this.tbNombreJugador2.Text);
                }
            }
            //posiciones ganadoras diagonales
            if (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text != "")
            {
                if (button5.Text == "X")
                {
                    MessageBox.Show("Ha ganado el jugador 1" + this.tbNombreJugador1.Text);
                }
                else
                {
                    MessageBox.Show("Ha ganado el jugador 2: " + this.tbNombreJugador2.Text);
                }
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button5.Text != "")
            {
                if (button5.Text == "X")
                {
                    MessageBox.Show("Ha ganado el jugador 1" + this.tbNombreJugador1.Text);
                }
                else
                {
                    MessageBox.Show("Ha ganado el jugador 2: " + this.tbNombreJugador2.Text);
                }
            }

        }

        private void labelTurno_Click(object sender, EventArgs e)
        {

        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            labelTurno.Text = "";

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

        }
    }
}
