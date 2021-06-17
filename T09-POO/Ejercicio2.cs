using System;

namespace T09_POO
{
    class Ejecicio2
    {
        static void Main(string[] args)
        {
            EmpleadoFabrica empleado1 = new EmpleadoFabrica();
            empleado1.Imprimir();
            empleado1.PagaImpuestos();
            Console.ReadKey();

        }

        class EmpleadoFabrica
        {
            //ATRIBUTOS
            string nombre;
            float sueldo;

            // CONSRUCTOR
            public EmpleadoFabrica()
            {
                Console.Write("Ingrese el nombre del empleado:");
                nombre = Console.ReadLine();
                Console.Write("Ingrese su sueldo:");
                string linea = Console.ReadLine();
                sueldo = float.Parse(linea);
            }

            public void PagaImpuestos()
            {
                if (sueldo > 3000)
                {
                    Console.WriteLine("Debe abonar impuestos");
                }
                else
                {
                    Console.WriteLine("No paga impuestos");
                }
                Console.ReadKey();
            }
            public void Imprimir()
            {
                Console.WriteLine("Nombre:" + nombre);
                Console.WriteLine("Sueldo:" + sueldo);
            }

           
        }

        
    }
}