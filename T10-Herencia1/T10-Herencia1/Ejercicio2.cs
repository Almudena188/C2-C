using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10_Herencia1
{
    class Ejercicio2
    {
        public class Persona
        {
            private static char SEXODEF = 'H';

            private String nombre;
            private int edad;
            private String DNI;
            private char sexo;
            private double peso;
            private double altura;

            // constructores
            public Persona()
            {
                this.nombre = "";
                this.edad = 0;
                this.sexo = SEXODEF;
                this.peso = 0;
                this.altura = 0;

            }
            public Persona(String nombre, int edad, char sexo)
            {
                this.nombre = nombre;
                this.edad = edad;
                this.sexo = sexo;
                this.altura = 0;
                this.peso = 0;
            }
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

            // metodos
            private void comprobarSexo()
            {
                if (sexo != 'H' && sexo != 'M')
                {
                    this.sexo = SEXODEF;
                }
            }

            private void generarDni()
            {
                    int divisor = 23;
                    var seed = Environment.TickCount;
                    var random = new Random(seed);
                    var value = random.Next(10000000, 100000000);
                    int numDNI = value;
                    int res = numDNI - (numDNI / divisor * divisor);
                    char letraDNI = generaLetraDNI(res);
                    DNI = "" + numDNI + letraDNI;                
            }

            private char generaLetraDNI(int res)
            {
                char[] letras = {'T', 'R', 'W', 'A', 'G', 'M', 'Y',
            'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z',
            'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E'};

                return letras[res];
            }

            public int calcularIMC()
            {
                //Calculamos el peso de la persona
                double pesoActual = peso / (Math.Pow(altura, 2));
                //Segun el peso, devuelve un codigo
                if (pesoActual >= 20 && pesoActual <= 25)
                {
                    return 0;
                }
                else if (pesoActual < 20)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            public Boolean esMayorDeEdad()
            {
                Boolean mayor = false;
                if (edad >= 18)
                {
                    mayor = true;
                }
                return mayor;
            }

            // setter and getter
            public void setNombre(String nombre)
            {
                this.nombre = nombre;
            }
            public void setEdad(int edad)
            {
                this.edad = edad;
            }
            public void setSexo(char sexo)
            {
                this.sexo = sexo;
            }
            public void setPeso(double peso)
            {
                this.peso = peso;
            }
            public void setAltura(double altura)
            {
                this.altura = altura;
            }

            public String toString()
            {
                String sexo;
                if (this.sexo == 'H')
                {
                    sexo = "hombre";
                }
                else
                {
                    sexo = "mujer";
                }
                return "Informacion de la persona:\n"
                        + "Nombre: " + nombre + "\n"
                        + "Sexo: " + sexo + "\n"
                        + "Edad: " + edad + " años\n"
                        + "DNI: " + DNI + "\n"
                        + "Peso: " + peso + " kg\n"
                        + "Altura: " + altura + " metros\n";
            }

            public static void Main(String[] args)
            {

                Console.WriteLine("Introduce el nombre");
                String nombre = Console.ReadLine();

                Console.WriteLine("Introduce la edad");
                int edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Introduce el sexo");
                char sexo = char.Parse(Console.ReadLine());

                Console.WriteLine("Introduce el peso");
                double peso = double.Parse(Console.ReadLine());

                Console.WriteLine("Introduce la  altura");
                double altura = double.Parse(Console.ReadLine());


                //Creamos objetos con cada constructor
                Persona persona1 = new Persona();
                Persona persona2 = new Persona(nombre, edad, sexo);
                Persona persona3 = new Persona(nombre, edad, sexo, peso, altura);

                //Los datos que no esten completos los insertamos con los metodos set
                persona1.setNombre("Laura");
                persona1.setEdad(30);
                persona1.setSexo('M');
                persona1.setPeso(60);
                persona1.setAltura(1.60);

                persona2.setPeso(90.5);
                persona2.setAltura(1.80);

                //Usamos metodos para realizar la misma accion para cada objeto
                Console.WriteLine("Persona 1");
                MuestraMensajePeso(persona1);
                MuestraMayorDeEdad(persona1);
                Console.WriteLine(persona1.toString());

                Console.WriteLine("Persona2");
                MuestraMensajePeso(persona2);
                MuestraMayorDeEdad(persona2);
                Console.WriteLine(persona2.toString());

                Console.WriteLine("Persona3");
                MuestraMensajePeso(persona3);
                MuestraMayorDeEdad(persona3);
                Console.WriteLine(persona3.toString());
            }

            public static void MuestraMensajePeso(Persona p)
            {
                int IMC = p.calcularIMC();
                switch (IMC)
                {
                    case 0:
                        Console.WriteLine("La persona esta en su peso ideal");
                        break;
                    case -1:
                        Console.WriteLine("La persona esta por debajo de su peso ideal");
                        break;
                    case 1:
                        Console.WriteLine("La persona esta por encima de su peso ideal");
                        break;
                }
            }

            public static void MuestraMayorDeEdad(Persona p)
            {

                if (p.esMayorDeEdad())
                {
                    Console.WriteLine("La persona  es mayor de edad");
                }
                else
                {
                    Console.WriteLine("La persona no es mayor de edad");
                }
            }
        }

        
    }
}
