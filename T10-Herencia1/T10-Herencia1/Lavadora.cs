using System;
using class Electrodomestico;

namespace T10_Herencia1{

    class Lavadora:Electrodomestico{

        private final static int CARGA_DEF = 5;
        private int carga;

        public int Carga
        {

            set
            {
                carga = value;
            }
            get
            {
                return consumoEnergetico;
            }
        }

    public double precioFinal()
    {
        //Invocamos el método precioFinal del método padre
        double plus = super.precioFinal();

        //añadimos el código necesario
        if (carga > 30)
        {
            plus += 50;
        }

        return plus;
    }
    public Lavadora()
    {
        this(PRECIO_BASE_DEF, PESO_DEF, CONSUMO_ENERGETICO_DEF, COLOR_DEF, CARGA_DEF);
    }
    
    public Lavadora(double precioBase, double peso){
        this(precioBase, peso, CONSUMO_ENERGETICO_DEF, COLOR_DEF, CARGA_DEF);
    }

     public Lavadora(double precioBase, double peso, char consumoEnergetico, String color, int carga){
            super(precioBase,peso, consumoEnergetico,color);
            this.carga=carga;
        }



}
}

