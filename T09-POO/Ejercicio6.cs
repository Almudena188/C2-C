using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T09_POO
{
    class Ejercicio6
    {
        public class Coche
        {
            private string marca;
            private string modelo;
            private int cilindrada;
            private double potencia;
            public Coche() { }
            public Coche(string marca, string modelo, int cilindrada, double potencia)
            {
                this.marca = marca;
                this.modelo = modelo;
                this.cilindrada = cilindrada;
                this.potencia = potencia;

            }
        }

        static void Main(string[] args)
        {
            Coche c1 = new Coche("Peugeot", "307", 1200, 12.7);
            Coche c2 = new Coche("Jeep", "Cpmpass", 2500, 50.7);
            Coche c3 = new Coche("Porsche", "Panamena", 4500, 250.7);

            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            Console.WriteLine(c3.ToString());


            Console.ReadKey();
        }
    }
}
