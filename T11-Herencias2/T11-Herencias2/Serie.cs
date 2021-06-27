using System;
using static T11_Herencias2.Entregable;

namespace T11_Herencias2
{
    public class Serie : Entregable
    {
        //CONSTANTES
        private static int NUM_TEMPORADAS_DEF = 3;

        public static int MAYOR = 1;

        public static int MENOR = -1;

        public static int IGUAL = 0;

       
        //ATRIBUTOS
        private String _titulo;

        private int _numeroTemporadas;

        private Boolean _entregado;

        private String _genero;

        private String _creador;

        //GETTER AND SETTER
        public string titulo
        {
            get
            {
                return _titulo;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _titulo = value;
                }
            }
        }

        public string genero
        {
            get
            {
                return _genero;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _genero = value;
                }
            }
        }

        public string creador
        {
            get
            {
                return _creador;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _creador = value;
                }
            }
        }


        public int numeroTemporadas
        {

            set
            {
                _numeroTemporadas = value;
            }
            get
            {
                return _numeroTemporadas;
            }
        }
        public Boolean entregado
        {

            set
            {
                _entregado = value;
            }
            get
            {
                return _entregado;
            }
        }

        public void entregar()
        {
            _entregado = true;
        }
        public void devolver()
        {
            _entregado = false;
        }
        public Boolean isEntregado()
        {
            if (_entregado)
            {
                return true;
            }
            return false;
        }
        public int compareTo(Object a)
        {
            int estado = MENOR;

            //Hacemos un casting de objetos para usar el metodo get
            Serie refe = (Serie) a;

            if (numeroTemporadas > refe.numeroTemporadas)
            {
                estado = MAYOR;
            }
            else if (numeroTemporadas == refe.numeroTemporadas)
            {
                estado = IGUAL;
            }

            return estado;
        }
        public String toString()
        {
            return "Informacion de la Serie: \n" +
                    "\tTitulo: " + _titulo + "\n" +
                    "\tNumero de temporadas: " + _numeroTemporadas + "\n" +
                    "\tGenero: " + _genero + "\n" +
                    "\tCreador: " + _creador;
        }
        public Boolean equals(Serie a)
        {
            if (_titulo.Equals(a.titulo) && _creador.Equals(a.creador))
            {
                return true;
            }
            return false;
        }

        //CONSTRUCTOR
        public Serie()
        {
            this._titulo = "";
            this._numeroTemporadas = numeroTemporadas;
            this._genero = "";
            this._creador = creador;
        }
        public Serie(String titulo, String creador)
        {

            this._titulo = titulo;
            this._numeroTemporadas = numeroTemporadas;
            this._genero = "";
            this._creador = creador;
        }
        public Serie(String titulo, int numeroTemporadas, String genero, String creador)
        {
            this._titulo = titulo;
            this._numeroTemporadas = numeroTemporadas;
            this._genero = genero;
            this._creador = creador;
            this._entregado = false;
        }
    }
}
