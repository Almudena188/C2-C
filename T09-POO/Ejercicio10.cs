using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T09_POO
{
    class Ejercicio10
    {
        public class Serie
        {
            private static int NUMTEMPORADASDEFECTO = 3;
            private static Boolean ENTREGADODEFECTO = false;

            private string titulo;
            private int numTemporadas;
            private Boolean entregada;
            private string genero;
            private string creador;

            public Serie()
            {
                this("", NUMTEMPORADASDEFECTO, "", "");
            }
            public Serie(String titulo, String creador)
            {
                this(titulo, NUMTEMPORADASDEFECTO, "", creador);
            }

            public Serie(String titulo, int numeroTemporadas, String genero, String creador)
            {
                this.titulo = titulo;
                this.numTemporadas = numeroTemporadas;
                this.genero = genero;
                this.creador = creador;
                this.entregada = false;
            }


            public String toString()
            {
                return "Informacion de la Serie: \n" +
                        "\tTitulo: " + titulo + "\n" +
                        "\tNumero de temporadas: " + numTemporadas + "\n" +
                        "\tGenero: " + genero + "\n" +
                        "\tCreador: " + creador + "\n"+
                         "\tEntregado: " + entregada;
            }

        }
        static void Main(string[] args)
        {
            Serie c1 = new Serie("La laguna", "Gustabo");
            Console.WriteLine(c1.ToString());

            Serie c2 = new Serie();
            Console.WriteLine(c2.ToString());

            Serie c3 = new Serie("La casa", 5, "Miedo", "Pedro");
            Console.WriteLine(c3.ToString());
            Console.ReadKey();
        }
    }
}
