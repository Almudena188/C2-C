using System;

namespace T09_POO
{
    class Ejecicio1
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            alumno1.Imprimir();
            alumno1.EsMayorEdad();
            Console.ReadKey();
        }

        class Alumno
        {
            private string nombre;
            private int edad;

            public Alumno()
            {
                Console.WriteLine("Ingrese el nombre:");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la edad:");
                string linea = Console.ReadLine();
                edad = int.Parse(linea);
            }

            public void Imprimir()
            {
                Console.WriteLine("Nombre:" + nombre);
                Console.WriteLine("Edad:" + edad);
            }

            public void EsMayorEdad()
            {
                if (edad >= 18)
                {
                    Console.WriteLine(nombre + " es mayor de edad.");
                }
                else
                {
                    Console.WriteLine(nombre + " no es mayor de edad.");
                }
            }


        }
    }
}