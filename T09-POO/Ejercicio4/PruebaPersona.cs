using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T09_POO.Ejercicio4
{
    class PruebaPersona
    {
        static void Main(string[] args)
        {
            persona p = new persona();

            persona p2 = new persona(); 
            Console.WriteLine("Escriba el nombre del primero");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba el nombre del segundo");
            string nombre2 = Console.ReadLine();
            p.SetNombre(nombre);
            p2.SetNombre(nombre2);
            p.saludar(p.GetNombre());
            p2.saludar(p2.GetNombre());

            Console.ReadKey();
        }
    }
}
