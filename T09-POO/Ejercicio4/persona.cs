using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T09_POO.Ejercicio4
{
    class persona
    {
        private string nombre;
        public persona()
        {
        }
        public persona(string nombre1)
        {
            nombre = nombre1;
        }

        public  void SetNombre(String nombre1) {
            nombre = nombre1;
        }

        public String GetNombre()
        {
            return nombre != null ? nombre : "Sin nombre";
        }
        public void saludar(String nombre)
        {
            Console.WriteLine("Hola, soy " + nombre);
        }
    }
}
