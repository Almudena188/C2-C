using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T09_POO
{
    class Ejercicio5
    {
        public class libro
        {
            private string autor;
            private string titulo;
            private string ubicacion;

            public libro()
            {
            }
            public libro(string autor1, string titulo1, string ubicacion1)
            {
                autor = autor1;
                titulo = titulo1;
                ubicacion = ubicacion1;
            }

            public void SetAutor(String autor1)
            {
                autor = autor1;
            }

            public String GetAutor()
            {
                return autor != null ? autor : "Sin autor";
            }
            public void SetTitulo(String titulo1)
            {
                titulo = titulo1;
            }

            public String GetTitulo()
            {
                return titulo != null ? titulo : "Sin titulo";
            }
            public void SetUbicacion(String autor1)
            {
                ubicacion = autor1;
            }

            public String GetUbicacion()
            {
                return ubicacion != null ? ubicacion : "Sin autor";
            }
        }

        static void Main(string[] args)
        {
            libro l1 = new libro();
            libro l2 = new libro();
            libro l3 = new libro();

            Console.WriteLine("Escriba el autor del libro");
            string autor1 = Console.ReadLine();
            l1.SetAutor(autor1);
            Console.WriteLine("Escriba el titulo del libro");
            string t1 = Console.ReadLine();
            l1.SetTitulo(t1);
            Console.WriteLine("Escriba la ubicacion del libro");
            string u1 = Console.ReadLine();
            l1.SetUbicacion(u1);

            Console.WriteLine("Escriba el autor del libro");
            string autor2 = Console.ReadLine();
            l2.SetAutor(autor2);
            Console.WriteLine("Escriba el titulo del libro");
            string t2 = Console.ReadLine();
            l2.SetTitulo(t2);
            Console.WriteLine("Escriba la ubicacion del libro");
            string u2 = Console.ReadLine();
            l2.SetUbicacion(u2);


            Console.WriteLine("Escriba el autor del libro");
            string autor3 = Console.ReadLine();
            l3.SetAutor(autor3);
            Console.WriteLine("Escriba el titulo del libro");
            string t3 = Console.ReadLine();
            l3.SetTitulo(t3);
            Console.WriteLine("Escriba la ubicacion del libro");
            string u3 = Console.ReadLine();
            l3.SetUbicacion(u3);

            Console.WriteLine(l1.ToString());
            Console.WriteLine(l2.ToString());
            Console.WriteLine(l3.ToString());


            Console.ReadKey();
        }
    }
}
