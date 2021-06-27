using System;
using static T11_Herencias2.Persona;

namespace T11_Herencias2
{
	public class Alumno :Persona
	{
		private int _nota;
        public Alumno()
        {
            Random r = new Random();

            _nota = r.Next(0, 10);
            this.edad = r.Next(12, 15);
            
        }

        public int nota
        {

            set
            {
                _nota = value;
            }
            get
            {
                return _nota;
            }
        }

        public override void disponibilidad()
        {
            Random r = new Random();
            int prob = r.Next(0, 100);

            if (prob < 50)
            {
                this.asistencia = false;
            }
            else
            {
                this.asistencia = true;
            }
        }

        public String toString()
        {

            return "Nombre: " + this.nombre + " ,sexo: " + this.sexo + " , nota: " + nota;

        }
    }
}
