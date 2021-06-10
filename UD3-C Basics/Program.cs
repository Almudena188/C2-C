using System;

namespace UD3_C_Basics
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
        }

        public static void ejercicio1(){
            Console.WriteLine("EJERCICIO 1");

            // declaración de variables
            int a = 2;
            int b = 1;
            // suma
            int suma = a + b;
            Console.WriteLine(suma);
            //resta
            int resta = a - b;
            Console.WriteLine(resta);
            //multiplicación
            int mult = a * b;
            Console.WriteLine(mult);
            //división
            int div = a / b;
            Console.WriteLine(div);
            //módulo
            int modulo = a % b;
            Console.WriteLine(modulo);
        }

        public static void ejercicio2()
        {
            Console.WriteLine("EJERCICIO 2");

            // declaración de variables
            int N = 20;
            double A = 9.87;
            char C = 'f';

            Console.WriteLine($"Valor de N = {N}");
            Console.WriteLine($"Valor de A = {A}");
            Console.WriteLine($"Valor de C = {C}");

            double suma = N + A;
            Console.WriteLine($"{N} + {A} = {suma}");
            double resta = A - N;
            Console.WriteLine($"{A} - {N} = {resta}");
            int num = C;
            Console.WriteLine($"Valor numérico de {C} es {num}");


        }
        public static void ejercicio3()
        {
            Console.WriteLine("EJERCICIO 3");

            // declaración de variables
            int X = 3;
            int Y = 5;
            double N = 4.6;
            double M = 2.7;

            Console.WriteLine($"Valor de N = {N}");
            Console.WriteLine($"Valor de M = {M}");
            Console.WriteLine($"Valor de X = {X}");
            Console.WriteLine($"Valor de Y = {Y}");

            int suma = X + Y;
            Console.WriteLine($"{X} + {Y} = {suma}");
            int resta = X - Y;
            Console.WriteLine($"{X} - {Y} = {resta}");
            int producto = X * Y; ;
            Console.WriteLine($"{X} * {Y} = {producto}");
            int cociente = X / Y; ;
            Console.WriteLine($"{X} / {Y} = {cociente}");
            int resto = X % Y; ;
            Console.WriteLine($"(resto) {X} % {Y} = {resto}");
            Console.WriteLine();
            double suma2 = N + M;
            Console.WriteLine($"{N} + {M} = {suma2}");
            double resta2 = N - M;
            Console.WriteLine($"{N} - {M} = {resta2}");
            double producto2 = N * M; ;
            Console.WriteLine($"{N} * {M} = {producto2}");
            double cociente2 = N / M; ;
            Console.WriteLine($"{N} / {M} = {cociente2}");
            double resto2 = N % M; ;
            Console.WriteLine($"(resto) {N} % {M} = {resto2}");

            Console.WriteLine();
            Console.WriteLine($"Doble de N = {N * 2}");
            Console.WriteLine($"Doble de M = {M * 2}");
            Console.WriteLine($"Doble de X = {X * 2}");
            Console.WriteLine($"Doble de Y = {Y * 2}");

            Console.WriteLine();
            double sumaTotal = X + Y + N + M;
            Console.WriteLine($"Suma de {X} + {Y} + {N} + {M} = {sumaTotal}");
            double productoTotal = X * Y * N * M;
            Console.WriteLine($"Producto de {X} * {Y} * {N} * {M} = {productoTotal}");

        }
        public static void ejercicio4()
        {
            Console.WriteLine("EJERCICIO 4");

            // declaración de variables
            int N = 10;
            Console.WriteLine($"Valor de N = {N}");
            N = N + 77;
            Console.WriteLine($"Incremento de N  en 77 = {N}");
            N = N - 3;
            Console.WriteLine($"Decremento de N  en 3 = {N}");
            N = N * 2;
            Console.WriteLine($"Duplicar el valor de N = {N}");
        }
        public static void ejercicio5()
        {
            Console.WriteLine("EJERCICIO 5");

            // declaración de variables
            int A = 10;
            int B = 20;
            int C = 30;
            int D = 40;
            Console.WriteLine($"Valor de A = {A}");
            Console.WriteLine($"Valor de B = {B}");
            Console.WriteLine($"Valor de C = {C}");
            Console.WriteLine($"Valor de D = {D}");
            int x;
            x = D;
            D = B;
            B = A;
            A = x;
            x = C;
            C = B;
            B = x;

            Console.WriteLine($"Valor de A = {A}");
            Console.WriteLine($"Valor de B = {B}");
            Console.WriteLine($"Valor de C = {C}");
            Console.WriteLine($"Valor de D = {D}");
        }
    }
}
