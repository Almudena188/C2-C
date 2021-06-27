using System;

public class Raices
{
    private double a;
    private double b;
    private double c;

    public Raices(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    private void obtenerRaices()
    {

        double x1 = (-b + Math.Sqrt(getDiscriminante())) / (2 * a);
        double x2 = (-b - Math.Sqrt(getDiscriminante())) / (2 * a);

        Console.WriteLine("Solucion X1");
        Console.WriteLine(x1);
        Console.WriteLine("Solucion X2");
        Console.WriteLine(x2);
    }

    private void obtenerRaiz()
    {
        double x = (-b) / (2 * a);
        Console.WriteLine("Unica solucion");
        Console.WriteLine(x);
    }

    private double getDiscriminante()
    {
        return Math.Pow(b, 2) - (4 * a * c);
    }
    private Boolean tieneRaices()
    {
        return getDiscriminante() > 0;
    }
    private Boolean tieneRaiz()
    {
        return getDiscriminante() == 0;
    }

    public void calcular()
    {

        if (tieneRaices())
        {
            obtenerRaices();
        }
        else if (tieneRaiz())
        {
            obtenerRaiz();
        }
        else
        {
            Console.WriteLine("No tiene soluciones");
        }

    }
}
