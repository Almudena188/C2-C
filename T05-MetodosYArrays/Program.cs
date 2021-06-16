using System;

namespace T05_MetodosYArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ejercicio1();
            ejercicio2();
            ejercicio3();
            ejercicio4();
            ejercicio5();
            ejercicio6();
            ejercicio7();
            ejercicio8();
            ejercicio9();
            ejercicio10();
            ejercicio11();
            ejercicio12();
            ejercicio13();
            ejercicio14();
            ejercicio15();
            ejercicio16();
            ejercicio17();
            ejercicio18();
            ejercicio19();
            ejercicio20();
            ejercicio21();
        }

        public static void ejercicio1()
        {
            int menu;
            Console.WriteLine("Inserte el número de la figura que quieres calcular el área:\n" +
                "1 triangulo\n" +
                "2 circulo\n" +
                "3 cuadrado\n");
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1: Console.WriteLine("Resultado : " + areaTriangulo());
                    break;
                case 2: Console.WriteLine("Resultado : " + areaCirculo());
                    break;
                case 3: Console.WriteLine("Resultado : " + areaCuadrado());
                        break;
            }
            
        }
        public static double areaTriangulo() {
            Console.WriteLine("Inserte el valor de la base");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Inserte el valor de la altura");
            double a = double.Parse(Console.ReadLine());

            double resultado = 0;
            resultado = b * a;
            resultado = resultado / 2;
            return resultado;
        }
        public static double areaCirculo()
        {
            Console.WriteLine("Inserte el valor del radio");
            double r = double.Parse(Console.ReadLine());
            double resultado = 0;
            resultado = Math.Pow(r, 2) * Math.PI;
            return resultado;
        }
        public static double areaCuadrado()
        {
            Console.WriteLine("Inserte el valor del lado");
            double l = double.Parse(Console.ReadLine());
            double resultado = 0;
            resultado = Math.Pow(l, 2);
            return resultado;
        }


        public static void ejercicio2() {
            Console.WriteLine("Inserte la cantidad de números que quiere generar");
            int cant = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Inserte el valor minimo que quiere tener");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserte el valor máximo que quiere tener");
            int max = int.Parse(Console.ReadLine());

            for (int i = 0; i <= cant; i++) {
                Console.WriteLine(numAleatorioMaxMin(max, min));
            }


        }

        public static int numAleatorioMaxMin(int max, int min) {
            int a = 0;
          //  a = min + Random() % (max + 1 - min);
            return a;
        }

        public static void ejercicio3() {
            Console.WriteLine("Introduce un número");
            int num = int.Parse(Console.ReadLine());
            
            if (esPrimo(num))
            {
                Console.WriteLine("El numero " + num + " es primo");
            }
            else
            {
                Console.WriteLine("El numero " + num + " no es primo");
            }
        }

        public static Boolean esPrimo(int numero)
        {

            if (numero <= 1)
            {
                return false;
            }

            int cont = 0;
            for (int divisor = (int)Math.Sqrt(numero); divisor > 1; divisor--)
            {
                if (numero % divisor == 0)
                {
                    cont += 1;
                }
            }
            if (cont >= 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void ejercicio4() {
            Console.WriteLine("Escribe un número"); 
            int num = int.Parse(Console.ReadLine());
            factorial(num);
        }

        public static void factorial(int num) {
            int resultado = num;
            for (int i = num - 1; i > 1; i--)
            {
                resultado *= i;
            }
            Console.WriteLine(resultado);
        }
        public static void ejercicio5()
        {
            Console.WriteLine("Escribe un número");
            int num = int.Parse(Console.ReadLine());

            decimalABinario(num);
        }

        public static void decimalABinario(int num) {
            String binario = "";
            String digito;
            for (int i = num; i > 0; i /= 2)
            {
                if (i % 2 == 1)
                {
                    digito = "1";
                }
                else
                {
                    digito = "0";
                }
                binario = digito + binario;
            }
            Console.WriteLine("El numero " + num + " en binario es " + binario);
        }

        public static void ejercicio6() {
            int num = 0;
            do
            {
                Console.WriteLine("Escribe un número positivo");
                num = int.Parse(Console.ReadLine()); ;
            } while (num < 0);
            int numCifras = cuentaCifras(num);
            if (numCifras == 1)
            {
                Console.WriteLine("El numero " + num + " tiene " + numCifras + " cifra");
            }
            else
            {
                Console.WriteLine("El numero " + num + " tiene " + numCifras + " cifras");
            } 
        }
        public static int cuentaCifras(int numero)
        {
            int contador = 0;
            for (int i = numero; i > 0; i /= 10)
            {
                contador++;
            }
            return contador;
        }

        public static void ejercicio7()
        {
            Console.WriteLine("Escribe una cantidad en euros");
            double cantidad = Double.Parse(Console.ReadLine());
            
            Console.WriteLine("Escribe la moneda a la que quieres convertir\n" +
                "libras\n" +
                "dolares\n" +
                "yenes");

            String moneda = Console.ReadLine();
            conversor(cantidad, moneda);
        }
        public static void conversor(double cantidad, String moneda)
        {
            double resultado = 0;
            Boolean correcto = true;

            switch (moneda)
            {
                case "libras":
                    resultado = cantidad * 0.86;
                    break;
                case "dolares":
                    resultado = cantidad * 1.29;
                    break;
                case "yenes":
                    resultado = cantidad * 129.852;
                    break;
                default:
                    Console.WriteLine("No has introducido una moneda correcta");
                    correcto = false;
                    break;
            }

            if (correcto)
            {
                Console.WriteLine(cantidad + " euros en " + moneda + " son " + resultado);
            }

        }

        public static void ejercicio8()
        {
            int[] numeros = new int[10];
            
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i;
                Console.WriteLine(numeros[i]);
            }
        }

        public static void ejercicio9()
        {
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Escriba un número");
                int num = int.Parse(Console.ReadLine());
                numeros[i] = num;
            }

            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
        public static void ejercicio10()
        {
            Console.WriteLine("Escriba un número");
            int num = int.Parse(Console.ReadLine());

            int[] numeros = new int[11];
            Console.WriteLine("\nRESULTADO\n");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = num * i;
                Console.WriteLine(numeros[i]);
            }

           
        }

        public static void ejercicio11() 
        {
            int[] numeros = new int[10];
            int i = 0;
            int suma = i;
            for (; i < numeros.Length; i++)
            {
                numeros[i] = i;
                suma = suma + numeros[i];
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("SUMA: " + suma);
        }

        public static void ejercicio12()
        {
            int[] numeros = new int[10];
            int i = 0;
            int suma = i;
            for (; i < numeros.Length; i++)
            {
                numeros[i] = i;
                suma = suma + numeros[i];
                Console.WriteLine(numeros[i]);
            }

            double media = suma /(double) numeros.Length;
            Console.WriteLine("MEDIA: " + media);
        }

        public static void ejercicio13() {

            Console.WriteLine("Escriba un número");
            int num = int.Parse(Console.ReadLine());
            int[] numeros = new int[num];
            var seed = Environment.TickCount;
            var random = new Random(seed);
            Console.WriteLine("ARRAY");
            for (int i = 0; i < numeros.Length; i++)
            {
                var value = random.Next(0, 10);
                numeros[i] = value;
                Console.WriteLine(numeros[i]);
            }
        }

        public static void ejercicio14()
        {
            Boolean encontrado = false;
            Console.WriteLine("Escriba la longitud del array");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el numero que quieres buscar");
            int buscar = int.Parse(Console.ReadLine());
            int[] numeros = new int[num];
            var seed = Environment.TickCount;
            var random = new Random(seed);
            Console.WriteLine("ARRAY");
            for (int i = 0; i < numeros.Length; i++)
            {
                
                var value = random.Next(0, 10);
                numeros[i] = value;
                if (numeros[i] == buscar)
                    encontrado = true;
                Console.WriteLine(numeros[i]);
            }

            if (encontrado) { Console.WriteLine($"EL NÚMERO {buscar} SE ENCUENTRA EN EL ARRAY"); }
            else { Console.WriteLine($"EL NÚMERO {buscar} NO SE ENCUENTRA EN EL ARRAY"); }
        }

        public static void ejercicio15() {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] invertido = new int[10];
            for (int i = 0, j = numeros.Length - 1; i < numeros.Length; i++, j--)
            {
                invertido[j] = numeros[i];
            }
            Console.WriteLine("ORIGINAL");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("INVERTIDO");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(invertido[i]);
            }
        }

        public static void ejercicio16() {

            int[] numeros = { 1, 1, 2, 1,11 };
            Boolean capicuo = true;
            int j = numeros.Length - 1;

            for (int i = 0; i < (numeros.Length - 1) / 2; i++) {
                if (numeros[i] != numeros[j])
                    capicuo = false;
                j--;
            }

            if (capicuo) { Console.WriteLine("EL ARRAY ES CAPICUO"); } else { Console.WriteLine("EL ARRAY NO ES CAPICUO"); }
        }

        public static void ejercicio17() {

            int[] numeros = new int[10];
            numeros = relleno(numeros);
            mostrarArray(numeros);
                
        }
        public static int[] relleno(int[] array) { 
            
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Inserte un numero");
                int num = int.Parse(Console.ReadLine());
                array[i] = num;
            }

            return array;
        
        }

        public static void mostrarArray(int[] array) {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Indice {i} valor {array[i]}");
            }
        }

        public static void ejercicio18()
        {

            Console.WriteLine("Escriba el tamaño del array");
            int num = int.Parse(Console.ReadLine());
            int[] numeros = new int[num];
            numeros = rellenarArray(0, 9, numeros);
            Console.WriteLine("ARRAY");
            mostrar(numeros);
            
        }

        public static void mostrar (int[] array)
        {
            int suma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                suma = suma + array[i];
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("SUMA : " + suma);

        }

        public static int[] rellenarArray(int valormin, int valormax, int[] array) {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            for (int i = 0; i < array.Length; i++)
            {
                var value = random.Next(valormin, valormax);
                array[i] = value;
                //array[i] = aleatoriomaxmin(valormin, valormax);

            }
            return array;
        }

        private static int aleatoriomaxmin(int min, int max) {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            var value = random.Next(min, max);
            Console.WriteLine("valor  : " + value);
            return value;
        }

        public static void ejercicio19() {
            Console.WriteLine("Escriba el tamaño del array");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el valor minimo que quieras que contenta el array");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el valor máximo que quieras que contenta el array");
            int max = int.Parse(Console.ReadLine());

            int[] numeros = new int[num];

            rellenarArrayConPrimo(min, max, numeros);
            Console.WriteLine("ARRAY");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("El mayor es : " + mayor(numeros));


        }

        public static int[] rellenarArrayConPrimo(int valormin, int valormax, int[] array)
        {
            var value = 0;
            var seed = Environment.TickCount;
            var random = new Random(seed);
            for (int i = 0; i < array.Length; i++)
            {
                 
                do
                {
                   value = random.Next(valormin, valormax);
                } while (!esPrimo(value));

                array[i] = value;

            }
            return array;
        }

        public static int mayor(int[] array)
        {
            int mayor = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mayor)
                {
                    mayor = array[i];
                }
            }

            return mayor;
        }

        public static void ejercicio20()
        {
            Console.WriteLine("Escriba el tamaño del array");
            int tamanio = int.Parse(Console.ReadLine());

            int[] array1 = new int[tamanio];
            int[] array2;

            rellenarNumAleatorioArray(10, 50, array1);
            array2 = array1;
            array1 = new int[tamanio];
            rellenarNumAleatorioArray(10, 100, array1);
            int[] array3 = multiplicador(array1, array2);

            Console.WriteLine("Array 1");
            mostrarArray(array1);
            Console.WriteLine("Array 2");
            mostrarArray(array2);
            Console.WriteLine("Array 3");
            mostrarArray(array3);
        }


        
        public static int[] rellenarNumAleatorioArray(int valormin, int valormax, int[] array)
        {
            var value = 0;
            var seed = Environment.TickCount;
            var random = new Random(seed);
            for (int i = 0; i < array.Length; i++)
            {
                value = random.Next(valormin, valormax);
                array[i] = value;

            }
            return array;
        }
        public static int[] multiplicador(int[] array1, int[] array2)
        {
            int[] array3 = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i] * array2[i];
            }
            return array3;
        }

        public static void ejercicio21() {
            Console.WriteLine("Escriba el tamaño del array");
            int tamanio = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el valor de la terminación");
            int terminacion = int.Parse(Console.ReadLine());

            int[] array1 = new int[tamanio];
            array1 = rellenarNumAleatorioArrayConTerminacionEspecifica(terminacion, array1);
            mostrarArray(array1);
        }

        public static int[] rellenarNumAleatorioArrayConTerminacionEspecifica(int valor, int[] array)
        {
            var value = 0;
            var seed = Environment.TickCount;
            var random = new Random(seed);
            int primerResto = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Boolean esTerminado = false;
                do {
                    value = random.Next(1, 300);

                    if (value <= 100)
                        if (value % 10 == valor)
                            esTerminado = true;
                    
                    if (value <= 1000)

                        primerResto = value % 100;
                   
                    if (primerResto % 10 == valor)
                        esTerminado = true;

                } while (!esTerminado);

                array[i] = value;

            }
            return array;
        }

    }
}
