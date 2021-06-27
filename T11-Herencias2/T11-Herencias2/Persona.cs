using System;
namespace T11_Herencias2
{
    public abstract class Persona
    {
        private String _nombre;
        private char _sexo;
        private int _edad;
        private Boolean _asistencia;

        private String[] NOMBRES_CHICOS = { "Pepe", "Fernando", "Alberto", "Nacho", "Eustaquio" };
        private String[] NOMBRES_CHICAS = { "Alicia", "Laura", "Clotilde", "Pepa", "Elena" };
        private int CHICO = 0;
        private int CHICA = 1;

        public Persona()
        {

            //entre 0 y 1
            Random r = new Random();
            int determinar_sexo = r.Next(0, 1);

            //Si es 0 es un chico
            if (determinar_sexo == CHICO)
            {
                _nombre = NOMBRES_CHICOS[r.Next(0, 4)];
                _sexo = 'H';
            }
            else
            {
                _nombre = NOMBRES_CHICAS[r.Next(0, 4)];
                _sexo = 'M';
            }

            //Indicamos la disponibilidad
            disponibilidad();

        }
        public abstract void disponibilidad();

        public Boolean asistencia
        {

            set
            {
                _asistencia = value;
            }
            get
            {
                return _asistencia;
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
        public char sexo
        {

            set
            {
                _sexo = value;
            }
            get
            {
                return _sexo;
            }
        }

        public string nombre
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

    }
}
