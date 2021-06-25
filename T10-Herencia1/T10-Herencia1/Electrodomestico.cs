using System;
namespace T10_Herencia1 { 

    public class Electrodomestico{

        protected static String COLOR_DEF = "blanco";
        protected static char CONSUMO_ENERGETICO_DEF = 'F';
        protected static double PRECIO_BASE_DEF = 100;
        protected static double PESO_DEF = 5;

        protected double precioBase;
        protected String color;
        protected char consumoEnergetico;
        protected double peso;


        public Char ConsumoEnergetico
        {

            set
            {
                consumoEnergetico = value;
            }
            get
            {
                return consumoEnergetico;
            }
        }

        public int Peso
        {

            set
            {
                peso = value;
            }
            get
            {
                return peso;
            }
        }



        private void comprobarColor(String color)
        {

            //Colores disponibles
            String colores[] = { "blanco", "negro", "rojo", "azul", "gris" };
            Boolean encontrado = false;

            for (int i = 0; i < colores.length && !encontrado; i++)
            {

                if (colores[i].Equals(color))
                {
                    encontrado = true;
                }

            }

            if (encontrado)
            {
                this.color = color;
            }
            else
            {
                this.color = COLOR_DEF;
            }
        }


        public void comprobarConsumoEnergetico(char consumoEnergetico)
        {

            if (consumoEnergetico >= 65 && consumoEnergetico <= 70)
            {
                this.consumoEnergetico = consumoEnergetico;
            }
            else
            {
                this.consumoEnergetico = CONSUMO_ENERGETICO_DEF;
            }

        }


        public double precioFinal()
        {
            double plus = 0;
            switch (consumoEnergetico)
            {
                case 'A':
                    plus += 100;
                    break;
                case 'B':
                    plus += 80;
                    break;
                case 'C':
                    plus += 60;
                    break;
                case 'D':
                    plus += 50;
                    break;
                case 'E':
                    plus += 30;
                    break;
                case 'F':
                    plus += 10;
                    break;
            }

            if (peso >= 0 && peso < 19)
            {
                plus += 10;
            }
            else if (peso >= 20 && peso < 49)
            {
                plus += 50;
            }
            else if (peso >= 50 && peso <= 79)
            {
                plus += 80;
            }
            else if (peso >= 80)
            {
                plus += 100;
            }

            return precioBase + plus;
        }


        public Electrodomestico()
        {
            this(PRECIO_BASE_DEF, PESO_DEF, CONSUMO_ENERGETICO_DEF, COLOR_DEF);
        }

        public Electrodomestico(double precioBase, double peso)
        {
            this(precioBase, peso, CONSUMO_ENERGETICO_DEF, COLOR_DEF);
        }

        public Electrodomestico(double precioBase, double peso, char consumoEnergetico, String color)
        {
            this.precioBase = precioBase;
            this.peso = peso;
            comprobarConsumoEnergetico(consumoEnergetico);
            comprobarColor(color);
        }
    }

}
