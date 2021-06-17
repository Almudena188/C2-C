using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T09_POO
{
    class Ejercicio3
    {
        class OperacionesCalculo
        {
            int valor1;
            int valor2;

            public OperacionesCalculo()
            {
                Console.Write("Ingrese primer valor:");
                string linea = Console.ReadLine();
                valor1 = int.Parse(linea);
                Console.Write("Ingrese segundo valor:");
                linea = Console.ReadLine();
                valor2 = int.Parse(linea);
            }

            public void Sumar()
            {
                int suma;
                suma = valor1 + valor2;
                Console.WriteLine("La suma es:" + suma);
            }

            public void Restar()
            {
                int resta;
                resta = valor1 - valor2;
                Console.WriteLine("La resta es:" + resta);
            }

            public void Multiplicar()
            {
                int multiplicacion;
                multiplicacion = valor1 * valor2;
                Console.WriteLine("La multiplicación es:" + multiplicacion);
            }

            public void Dividir()
            {
                int division;
                division = valor1 / valor2;
                Console.WriteLine("La división es:" + division);
            }

            static void Main(string[] args)
            {
                OperacionesCalculo opera = new OperacionesCalculo();
                opera.Sumar();
                opera.Restar();
                opera.Multiplicar();
                opera.Dividir();
                Console.ReadKey();
            }
        }
    }
}
