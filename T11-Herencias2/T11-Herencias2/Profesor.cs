using System;
using static T11_Herencias2.Persona;

namespace T11_Herencias2
{
	public class Profesor : Persona
	{
        private String _materia;

        /*Constructores*/
        public Profesor()
        {
            Random r = new Random();
            this.edad = r.Next(25, 30);
            
            _materia = Constantes.MATERIAS[r.Next(0, 2)];
        }

        public String materia {

            get
            {
                return _materia;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _materia = value;
                }
            }
        }

        public override void disponibilidad()
        {
            Random r = new Random();
            int prob =r.Next(0, 100);

            if (prob < 20)
            {
                this.asistencia = false;
            }
            else
            {
                this.asistencia = true;
            }
        }
    }
}
