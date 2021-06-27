using System;

namespace T11_Herencias2
{
    public class Asiento
    {
        /*Atributos*/
        private char _letra;
        private int _fila;
        private Espectador _espectador; // informacion del espectador que esta sentado, null si es vacio

        /*Constructores*/
        public Asiento(char letra, int fila)
        {
            this._letra = letra;
            this._fila = fila;
            this._espectador = null; //al iniciar el asiento, no habrá nadie sentado
        }

        public int fila
        {

            set
            {
                _fila = value;
            }
            get
            {
                return _fila;
            }
        }
        public char letra
        {

            set
            {
                _letra = value;
            }
            get
            {
                return _letra;
            }
        }

        public Espectador espectador
        {
            set {
                _espectador = value;
            }
            get {
                return _espectador;
            }
        }

        public Boolean ocupado()
        {
            return _espectador != null;
        }
        public String toString()
        {
            if (ocupado())
            {
                return "Asiento: " + _fila + _letra + " y " + _espectador;
            }

            return "Asiento: " + _fila + _letra + " y este asiento está vacio ";

        }
    }
}
