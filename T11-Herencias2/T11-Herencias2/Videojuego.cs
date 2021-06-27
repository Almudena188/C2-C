using System;
using static T11_Herencias2.Entregable;

namespace T11_Herencias2
{
	public class Videojuego : Entregable
	{
        private  static int HORAS_ESTIMADAS_DEF = 100;

        public  static int MAYOR = 1;

        public  static int MENOR = -1;

        public  static int IGUAL = 0;

        //Atributos

        private String _titulo;

        private int _horasEstimadas;

        private Boolean _entregado;

        private String _genero;

        private String _compañia;

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

        public string compañia
        {
            get
            {
                return _compañia;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _compañia =value;
                }
            }
        }

        public int horasEstimadas
        {

            set
            {
                _horasEstimadas = value;
            }
            get
            {
                return _horasEstimadas;
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
            Videojuego refe= (Videojuego)a;
            if (_horasEstimadas > refe.horasEstimadas)
            {
                estado = MAYOR;
            }
            else if (_horasEstimadas == refe.horasEstimadas)
            {
                estado = IGUAL;
            }

            return estado;
        }

        public String toString()
        {
            return "Informacion del videojuego: \n" +
                    "\tTitulo: " + _titulo + "\n" +
                    "\tHoras estimadas: " + _horasEstimadas + "\n" +
                    "\tGenero: " + _genero + "\n" +
                    "\tcompañia: " + _compañia;
        }

        public Boolean equals(Videojuego a)
        {
            if (_titulo.Equals(a.titulo) && _compañia.Equals(a.compañia))
            {
                return true;
            }
            return false;
        }
        //CONSTRUCTOR
        public Videojuego()
        {
            this._titulo = "";
            this._horasEstimadas = HORAS_ESTIMADAS_DEF;
            this._genero = "";
            this._compañia = "";
        }
        public Videojuego(String titulo, String compañia)
        {
            this._titulo = titulo;
            this._horasEstimadas = HORAS_ESTIMADAS_DEF;
            this._genero = "";
            this._compañia = compañia;
        }
        public Videojuego(String titulo, int horasEstimadas, String genero, String compañia)
        {
            this._titulo = titulo;
            this._horasEstimadas = horasEstimadas;
            this._genero = genero;
            this._compañia = compañia;
            this._entregado = false;
        }
    }
}
