using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T09_POO
{
    class Ejercicio8
    {
        public class Password
        {
            private int longitud = 8;
            private string contra;

            // Constructores
            public Password()
            {
                this(longitud);
            }
            public Password(int longitud)
            {
                this.longitud = longitud;
                contra = generaPassword();
            }

            // metodos
            public String generaPassword()
            {
                String password = "";
                for (int i = 0; i < longitud; i++)
                {

                    var seed = Environment.TickCount;
                    var random = new Random(seed);
                    var value = random.Next(0, 9);
                    password = password + "" + value; // concateno los valores alatorios a la variable
                    
                }
                return password;
            }


        }

        static void Main(string[] args)
        {
            Password c1 = new Password(9);
            Console.WriteLine(c1.ToString());

            Password c2 = new Password();
            Console.WriteLine(c2.ToString());

            Console.ReadKey();
        }
    }
}
