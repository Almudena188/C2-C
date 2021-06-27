using System;

public class Metodos
{
    public static  String[] nombres = {"Fernando", "Laura", "Pepe", "Eufrasio"};
 
    public static int generaNumeroEnteroAleatorio(int minimo, int maximo)
    {
        Random r = new Random();

        int num = (int)(r.Next(minimo, maximo));
        return num;
    }
}
