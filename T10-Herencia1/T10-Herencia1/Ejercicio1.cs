using System;

namespace T10_Herencia1
{
    class Ejercicio1
    {   public class Cuenta
        {
            private String titular;
            private double cantidad;

            // constructores
            public Cuenta(String titular)
            {
                this.titular = titular;
                cantidad = 0;
            }

            public Cuenta(String titular, double cantidad)
            {
                this.titular = titular;
                if (cantidad < 0)
                {
                    this.cantidad = 0;
                }
                else
                {
                    this.cantidad = cantidad;
                }
            }

            // getter and setter
            public string getTitular()
            {
                return this.titular;
            }

            public void setTitular(string titular)
            {
                this.titular = titular;
            }

            public double getCantidad()
            {
                return this.cantidad;
            }

            public void setCantidad(double cantidad)
            {
                this.cantidad = cantidad;
            }
            
            public String toString()
            {
                return "El titular " + titular + " tiene " + cantidad + " euros en la cuenta";
            }

            // metodos
            public void ingresar(double cantidad)
            {
                if (cantidad > 0)
                {
                    this.cantidad += cantidad;
                }
            }

            public void retirar(double cantidad)
            {
                if (this.cantidad - cantidad < 0)
                {
                    this.cantidad = 0;
                }
                else
                {
                    this.cantidad -= cantidad;
                }
            }
        }
        static void Main(string[] args)
        {
            Cuenta c = new Cuenta("Pepe", 746);
            c.ingresar(50.3);
            c.retirar(5.89);

            Console.WriteLine(c.toString());

        }
    }
}
