using System;
namespace T11_Herencias2
{
    public class Espectador
    {
        private String _nombre;
        private int _edad;
        private double _dinero;

        /*Constructores*/
        public Espectador(String nombre, int edad, double dinero)
        {
            this._nombre = nombre;
            this._edad = edad;
            this._dinero = dinero;
        }

        public String nombre
        {

            get
            {
                return _nombre;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nombre = value;
                }
            }
        }
        public int edad
        {

            set
            {
                _edad = value;
            }
            get
            {
                return _edad;
            }
        }
        public double dinero
        {

            set
            {
                _dinero = dinero;
            }
            get
            {
                return _dinero;
            }
        }
        public void pagar(double precio)
        {
            dinero -= precio;
        }
        public Boolean tieneEdad(int edadMinima)
        {
            return _edad >= edadMinima;
        }
        public Boolean tieneDinero(double precioEntrada)
        {
            return _dinero >= precioEntrada;
        }
        public String toString()
        {
            return "el nombre del espectador es " + _nombre + " de " + _edad + " años y con " + _dinero + " euros en su bolsillo";
        }
    }
}
