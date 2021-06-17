using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T09_POO
{
    class Ejercicio9
    {
        public class Electrodomestico
        {
            private static double PRECIOBASEDEFECTO = 100;
            private static double PESODEFECTO = 5;
            private static char CONSUMOENERGETICODEFECO = 'F';

            private double precioBase;
            private string color;
            private char consumoEnergetico;
            private double peso;

            // constructores

            public Electrodomestico()
            {
                this(PRECIOBASEDEFECTO, PESODEFECTO, CONSUMOENERGETICODEFECO, "");
            }

            public Electrodomestico(double precioBase, double peso)
            {
                this(precioBase, peso, CONSUMOENERGETICODEFECO, "");
            }

            public Electrodomestico(double precioBase, double peso, char consumoEnergetico, String color)
            {
                this.precioBase = precioBase;
                this.peso = peso;
                comprobarConsumoEnergetico(consumoEnergetico);
                comprobarColor(color);
            }

            // metodos

            private void comprobarColor(String color)
            {

                //Colores disponibles
                String[] colores = { "blanco", "negro", "rojo", "azul", "gris" };
                Boolean encontrado = false;

                for (int i = 0; i < colores.Length && !encontrado; i++)
                {

                    if (colores[i] == color)
                    {
                        encontrado = true;
                    }

                }

                if (encontrado)
                {
                    this.color = color;
                }
                else
                {
                    Console.WriteLine("Color no encontrado\nColores disponibles:\n BLANCO, NEGRO, ROJJO, AZUL, GRIS");
                }


            }

            public void comprobarConsumoEnergetico(char consumoEnergetico)
            {

                if (consumoEnergetico >= 65 && consumoEnergetico <= 70)
                {
                    this.consumoEnergetico = consumoEnergetico;
                }
                else
                {
                    Console.WriteLine("Color no encontrado el consumo energético indicado");
                }

            }
        }
        static void Main(string[] args)
        {
            Electrodomestico c1 = new Electrodomestico(2.5 , 15.26);
            Console.WriteLine(c1.ToString());

            Electrodomestico c2 = new Electrodomestico();
            Console.WriteLine(c2.ToString());

            Electrodomestico c3 = new Electrodomestico(200, 52.2, 'A', "negro");
            Console.WriteLine(c3.ToString());
            Console.ReadKey();
        }
    }
}
