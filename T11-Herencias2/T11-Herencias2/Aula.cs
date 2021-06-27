using System;

namespace T11_Herencias2
{
	public class Aula
	{
		private int _id;
		private Profesor _profesor;
		private Alumno[] _alumnos;
		private String _materia;

		private int MAX_ALUMNOS = 20;

        public Aula()
        {
            Random r = new Random();
            _id = 1;
            _profesor = new Profesor();
            _alumnos = new Alumno[MAX_ALUMNOS];
            creaAlumnos();
            _materia = Constantes.MATERIAS[r.Next(0, 2)];

        }
        private void creaAlumnos()
        {

            for (int i = 0; i < _alumnos.Length; i++)
            {
                _alumnos[i] = new Alumno();
            }

        }

        private Boolean asistenciaAlumnos()
        {

            int cuentaAsistencias = 0;

            //contamos las asistencias
            for (int i = 0; i < _alumnos.Length; i++)
            {

                if (_alumnos[i].asistencia == true)
                {
                    cuentaAsistencias++;
                }

            }

            //Muestro la asistencia total
            Console.WriteLine("Hay " + cuentaAsistencias + " alumnos");

            return cuentaAsistencias >= ((int)(_alumnos.Length / 2));

        }

        public Boolean darClase()
        {

            //Indicamos las condiciones para que se pueda dar la clase

            if (_profesor.asistencia == false)
            {
                Console.WriteLine("El profesor no esta, no se puede dar clase");
                return false;
            }
            else if (!_profesor.materia.Equals(_materia))
            {
                Console.WriteLine("La materia del profesor y del aula no es la misma, no se puede dar clase");
                return false;
            }
            else if (!asistenciaAlumnos())
            {
                Console.WriteLine("La asistencia no es suficiente, no se puede dar clase");
                return false;
            }

            Console.WriteLine("Se puede dar clase");
            return true;

        }

        public void notas()
        {

            int chicosApro = 0;
            int chicasApro = 0;

            for (int i = 0; i < _alumnos.Length; i++)
            {

                //Comprobamos si el alumno esta aprobado
                if (_alumnos[i].nota >= 5)
                {
                    //Segun el sexo, aumentara uno o otro
                    if (_alumnos[i].sexo == 'H')
                    {
                        chicosApro++;
                    }
                    else
                    {
                        chicasApro++;
                    }

                    Console.WriteLine(_alumnos[i].toString());

                }

            }

            Console.WriteLine("Hay " + chicosApro + " chicos y " + chicasApro + " chicas aprobados/as");

        }
    }
}
