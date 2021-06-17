using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T09_POO
{
    class Ejercicio7
    {
        public class Persona
        {
            private static char SEXODEFECTO = 'H';
            private string nombre;
            private int edad;
            private string dni;
            private char sexo;
            private double peso;
            private double altura;

            // constructor por defecto
            public Persona()
            {
                this("", 0, SEXODEFECTO, 0, 0);
            }
            // contructor con 3 parametros
            public Persona(String nombre, int edad, char sexo)
            {
                this(nombre, edad, sexo, 0, 0);
            }
            //  construtor  con 5 parametros
            public Persona(String nombre, int edad, char sexo, double peso, double altura)
            {
                this.nombre = nombre;
                this.edad = edad;
                this.peso = peso;
                this.altura = altura;
                generarDni();
                this.sexo = sexo;
                comprobarSexo();
            }

            private void comprobarSexo()
            {

                //Si el sexo no es una H o una M, por defecto es H
                if (sexo != 'H' && sexo != 'M')
                {
                    this.sexo = SEXODEFECTO;
                }
            }

            private void generarDni()
            {
                int divisor = 23;
                var seed = Environment.TickCount;
                var random = new Random(seed);

                //Generamos un número de 8 digitos
                var value = random.Next(10000000, 100000000);
                
                int numDNI = value;
                int res = numDNI - (numDNI / divisor * divisor);

                //Calculamos la letra del DNI
                char letraDNI = generaLetraDNI(res);

                //Pasamos el DNI a String
                dni = "" + numDNI + letraDNI;
            }

            private char generaLetraDNI(int res)
            {
                char[] letras = {'T', 'R', 'W', 'A', 'G', 'M', 'Y',
            'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z',
            'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E'};

                return letras[res];
            }
        }
    }
}
