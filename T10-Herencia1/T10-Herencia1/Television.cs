using System;
using class Electrodomestico;
namespace T10_Herencia1
{
	
    class Television :Electrodomestico
	{
        privat static int RESOLUCION_DEF = 20;

        private int resolucion;

        private Boolean sintonizadorTDT;

        public double precioFinal()
        {
           
            double plus = super.precioFinal();

           
            if (resolucion > 40)
            {
                plus += precioBase * 0.3;
            }
            if (sintonizadorTDT)
            {
                plus += 50;
            }

            return plus;
        }

        public Television()
        {
            this(PRECIO_BASE_DEF, PESO_DEF, CONSUMO_ENERGETICO_DEF, COLOR_DEF, RESOLUCION_DEF, false);
        }

        public Television(double precioBase, double peso)
        {
            this(precioBase, peso, CONSUMO_ENERGETICO_DEF, COLOR_DEF, RESOLUCION_DEF, false);
        }

        public Television(double precioBase, double peso, char consumoEnergetico, String color, int resolucion, Boolean sintonizadorTDT)
        {
            Super(precioBase, peso, consumoEnergetico, color);
            this.resolucion = resolucion;
            this.sintonizadorTDT = sintonizadorTDT;
        }
    }
}
