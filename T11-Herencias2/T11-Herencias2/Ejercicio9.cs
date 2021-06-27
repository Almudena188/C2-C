using System;
using T11_Herencias2;

public class Ejercicio9
{
    public static void main(String[] args)
    {

        //Creo la pelicula
        Pelicula pelicula = new Pelicula("Mi vida", 90, 16, "DDR");

        // Pido datos (esto no se mostro en el video por falta de tiempo)
        // No valida nada al respecto de tamaños (siguiente version)
        
        Console.WriteLine("Introduce el numero de filas");
        int filas = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el numero de columnas");
        int columnas = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el precio de la entrada de cine");
        double precio = double.Parse(Console.ReadLine());

        //Creo el cine, necesito la pelicula para ello
        Cine cine = new Cine(filas, columnas, precio, pelicula);

        //Numero de espectadores que seran creados
        Console.WriteLine("Introduce el numero de espectadores a crear");
        int numEspectadores = int.Parse(Console.ReadLine());

        //Variables y objetos usados
        Espectador e;
        int fila;
        char letra;

        Console.WriteLine("Espectadores generados: ");
        //Termino cuando no queden espectadores o no haya mas sitio en el cine
        for (int i = 0; i < numEspectadores && cine.haySitio(); i++) {

            //Generamos un espectador
            e = new Espectador(
                    Metodos.nombres[Metodos.generaNumeroEnteroAleatorio(0, Metodos.nombres.Length - 1)], //Nombre al azar
                    Metodos.generaNumeroEnteroAleatorio(10, 30), //Generamos una edad entre 10 y 30
                    Metodos.generaNumeroEnteroAleatorio(1, 10)); //Generamos el dinero entre 1 y 10 euros

            //Mostramos la informacion del espectador
            Console.WriteLine(e);

            //Generamos una fila y letra
            //Si esta libre continua sino busca de nuevo
            do
            {

                fila = Metodos.generaNumeroEnteroAleatorio(0, cine.getFilas() - 1);
                letra = (char)Metodos.generaNumeroEnteroAleatorio('A', 'A' + (cine.getColumnas() - 1));

            } while (cine.haySitioButaca(fila, letra));

            //Si el espectador cumple con las condiciones
            if (cine.sePuedeSentar(e))
            {
                e.pagar(cine.precio); //El espectador paga el precio de la entrada
                cine.sentar(fila, letra, e); //El espectador se sienta
            }

        }

        Console.WriteLine("");
        cine.mostrar(); //Mostramos la información del cine, tambien se puede usar un toString

        Console.WriteLine("Fin");

    }
}
