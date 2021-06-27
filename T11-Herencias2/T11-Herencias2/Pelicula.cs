using System;

namespace T11_Herencias2
{
    public class Pelicula
    {
        private String _titulo;
        private int _duracion;
        private int _edadMinima;
        private String _director;

        public Pelicula(String titulo, int duracion, int edadMinima, String director)
        {
            this._titulo = titulo;
            this._duracion = duracion;
            this._edadMinima = edadMinima;
            this._director = director;
        }

        public int edadMinima
        {

            set
            {
                _edadMinima = value;
            }
            get
            {
                return _edadMinima;
            }
        }
        public int duracion
        {

            set
            {
                _duracion = value;
            }
            get
            {
                return _duracion;
            }
        }

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
        public string director
        {
            get
            {
                return _director;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _director = value;
                }
            }
        }

        public String toString()
        {
            return "'" + titulo + "' del director " + director + ", con una duracion de " + duracion + " minutos y la edad minima es de " + edadMinima + " años";
        }
    }
}
