using System;

namespace T11_Herencias2
{
	public class Ejercicio6
	{
		static void Main(string[] args)
		{
            //Creamos lo objetos
            Libro libro1 = new Libro(1111111111, "titulo1", "autor1", 30);
            Libro libro2 = new Libro(1111111112, "titulo2", "autor2", 60);

            //Mostramos su estado
            Console.WriteLine(libro1.toString());
            Console.WriteLine(libro2.toString());

            //Modificamos el atributo numPaginas del libro1
            
            libro1.numPaginas = 70;

            //Comparamos quien tiene mas paginas
            if (libro1.numPaginas > libro2.numPaginas)
            {
                Console.WriteLine(libro1.titulo + " tiene más páginas");
            }
            else
            {
                Console.WriteLine(libro2.titulo + " tiene más páginas");
            }
        }
	}
}
