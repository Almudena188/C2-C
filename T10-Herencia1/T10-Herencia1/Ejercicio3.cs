using System;


namespace T10_Herencia1
{
    class Ejercicio3
    {
        public class Password {
            // constantes
             static int LONG_DEF = 8;
            // atributos
            int _longitud;
            private string _contrasenia;

            public int longitud {

                set {
                    _longitud = value;
                }
                get {
                    return _longitud;
                }
            }

            public string contrasenia
            {
                get
                {
                    return _contrasenia;
                }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        _contrasenia = value;
                    }
                }
            }


            public String generaPassword()
            {
                String password = "";
                for (int i = 0; i < _longitud; i++)
                {
                    //Generamos un numero aleatorio, segun este elige si añadir una minuscula, mayuscula o numero

                    Random r = new Random();
                    int eleccion = r.Next(1, 3);
                   
                    if (eleccion == 1)
                    {
                        Random r = new Random();
                        int num = r.Next(97, 123);
                        char minusculas = (char)num;
                        password += minusculas;
                    }
                    else
                    {
                        if (eleccion == 2)
                        {
                            Random r = new Random();
                            int num = r.Next(65, 91);
                            char mayusculas = (char)num;
                            password += mayusculas;
                        }
                        else
                        {
                            Random r = new Random();
                            int num = r.Next(48, 58);
                            char numeros = (char)num;
                            password += numeros;
                        }
                    }
                }
                return password;
            }

            public Boolean esFuerte()
            {
                int cuentanumeros = 0;
                int cuentaminusculas = 0;
                int cuentamayusculas = 0;
                //Vamos caracter a caracter y comprobamos que tipo de caracter es
                for (int i = 0; i < _contrasenia.Length(); i++)
                {
                    if (_contrasenia.Substring(i) >= 97 && _contrasenia.Substring(i) <= 122)
                    {
                        cuentaminusculas += 1;
                    }
                    else
                    {
                        if (_contrasenia.Substring(i) >= 65 && _contrasenia.Substring(i) <= 90)
                        {
                            cuentamayusculas += 1;
                        }
                        else
                        {
                            cuentanumeros += 1;
                        }
                    }
                }
                //Si la constraseña tiene mas de 5 numeros, mas de 1 minuscula y mas de 2 mayusculas
                if (cuentanumeros >= 5 && cuentaminusculas >= 1 && cuentamayusculas >= 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public Password()
            {
                this(LONG_DEF);
            }

            /**
             * La contraseña sera la pasada por parametro
             * @param longitud
             */
            public Password(int longitud)
            {
                this._longitud = longitud;
                _contrasenia = generaPassword();
            }


        }

        public static void main(String[] args)
        {

            //Introducimos el tamaño del array y la longitud del password
            Console.WriteLine("Introduce el tamaño del array");
            int  tamanio = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la longitud del password");
            int longitud = int.Parse(Console.ReadLine());

            //Creamos los arrays
            Password listaPassword[] = new Password[tamanio];
            Boolean fortalezaPassword[] = new Boolean[tamanio];

            //Creamos objetos, indicamos si es fuerte y mostramos la contraseña y su fortaleza.
            for (int i = 0; i < listaPassword.Lenght(); i++)
            {
                listaPassword[i] = new Password(longitud);
                fortalezaPassword[i] = listaPassword[i].esFuerte();
                Console.WriteLine(listaPassword[i].getContraseña() + " " + fortalezaPassword[i]);
            }
        }
    }
}
