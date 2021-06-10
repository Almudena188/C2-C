using System;

namespace T04_FlujodeDatos
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
            ejercicio22();
            ejercicio23();
        }

        public static void ejercicio1()
        {
            int num1, num2, num3, num4;
            num1 = 34;
            num2 = 9;
            num3 = 10;

            num4 = num1 + num2 + num3;
            Console.WriteLine(num4);
        }

        public static void ejercicio2()
        {
            Console.WriteLine("Escribe tu nombre"); // escribe en consola la cadenas qu el hemos introducido
            String nombre = Console.ReadLine(); // coge la cadena que has escrito en consola y se guarda en nombre

            Console.WriteLine("Escribe una ciudad"); // escribe en consola la cadenas qu el hemos introducido
            String ciudad = Console.ReadLine(); // coge la cadena que has escrito en consola y se guarda en ciudad

            Console.WriteLine("Hola " + nombre + " bienvenido a " + ciudad);
        }
        public static void ejercicio3()
        {
            Console.WriteLine("Escribe tu nombre");
            String nombre = Console.ReadLine();

            Console.WriteLine("Escribe tu edad");
            String edad = Console.ReadLine();

            Console.WriteLine("Te llamas " + nombre + " y tienes " + edad + " años.");
        }
        public static void ejercicio4()
        {
            Console.WriteLine("Escribe un número");
            double num1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Escribe otro número");
            double num2 = Double.Parse(Console.ReadLine());

            if (num1 > num2) Console.WriteLine("El número mayor es " + num1);
            else Console.WriteLine("El número mayor es " + num2);
        }

        public static void ejercicio5() {

            Console.WriteLine("Escribe el dia de la semana");
            String nombre = Console.ReadLine();

            String[] dias = { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };
            Boolean dia = false;
            for (int i = 0; i <= dias.Length - 1; i++) {
                if (dias[i] == nombre) {
                    dia = true;
                    if (nombre == "sabado" || nombre == "domingo")
                        Console.WriteLine("Es fin de semana");
                    else
                        Console.WriteLine("No es fin de semana");
                    break;
                }
            }

            if (dia == false)
            {
                Console.WriteLine("Ha escrito mal el dia de la semana");
            }

        }
        public static void ejercicio6()
        {
            Console.WriteLine("Inserte el precio");
            double precio = Double.Parse(Console.ReadLine());
            Console.WriteLine("forma de pago: tarjeta o ejectivo");
            String pago = Console.ReadLine();
            if (pago == "tarjeta")
            {
                Console.WriteLine("Escriba el número de cuenta");
                String cuenta = Console.ReadLine();

                Console.WriteLine("Precio del producto es de " + precio + ". Modo de pago: " + pago + ". Número de cuenta : " + cuenta);
            } else
                Console.WriteLine("Precio del producto es de " + precio + ". Modo de pago: " + pago);



        }
        public static void ejercicio7() {
            for (int i = 2; i < 100; i++) {
                Console.WriteLine(i);
            }
        }

        public static void ejercicio8()
        {
            int i = 2;
            while (i < 100)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public static void ejercicio9()
        {
            for (int i = 2; i < 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
        public static void ejercicio10()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                    Console.WriteLine(i);
            }
        }
        public static void ejercicio11()
        {
            int num1 = 6;
            int num2 = 6;

            if (num1 == num2)
                Console.WriteLine("Los dos números son iguales");
            if (num1 > num2)
                Console.WriteLine($"El num1 = {num1} es mayor al num2 = {num2}");
            if (num1 > num2)
                Console.WriteLine($"El num2 = {num2} es mayor al num1 = {num1}");
        }

        public static void ejercicio12() {
            String nombre = "Juan";
            Console.WriteLine("Bienvenido " + nombre);
        }

        public static void ejercicio13()
        {
            Console.WriteLine("Escribe su nombre");
            String nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido " + nombre);
        }
        public static void ejercicio14()
        {
            Console.WriteLine("Escribe el radio de la circinferencia");
            double r = Double.Parse(Console.ReadLine());

            double a = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("El área de la circunferencia es : " + a);
        }
        public static void ejercicio15()
        {
            Console.WriteLine("Inserte un número");
            double num = Double.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("El número es divisible entre 2");
            else
                Console.WriteLine("El número no es divisible entre 2");
        }
        public static void ejercicio16() {
            Console.WriteLine("Escribe el precio");
            double precio = Double.Parse(Console.ReadLine());
            double iva = precio * 0.21;
            double precioFinal = precio + iva;

            Console.WriteLine("Precio con IVA incluido es : " + precioFinal);
        }
        public static void ejercicio17()
        {
            int i = 1;
            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public static void ejercicio18()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
        public static void ejercicio19()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                    Console.WriteLine(i);
            }
        }
        public static void ejercicio20()
        {
            Console.WriteLine("Inserte el número de ventas que va sa introducir");
            int ventas = int.Parse(Console.ReadLine());
            double venta = 0;
            double suma = 0;
            for (int i = 1; i <= ventas; i++) {
                Console.WriteLine("Escrbe el precio de la venta");
                venta = double.Parse(Console.ReadLine());
                suma = suma + venta;
            }

            Console.WriteLine("Preio total de todas la ventas: " + suma);
        }
        public static void ejercicio21()
        {
            Console.WriteLine("Inserte un dia de la semana");
            String dia = Console.ReadLine();

            switch (dia)
            {
                case "lunes":
                    Console.WriteLine("Día laboral");
                    break;
                case "martes":
                    Console.WriteLine("Día laboral");
                    break;
                case "miercoles":
                    Console.WriteLine("Día laboral");
                    break;
                case "jueves":
                    Console.WriteLine("Día laboral");
                    break;
                case "viernes":
                    Console.WriteLine("Día laboral");
                    break;
                case "sabado":
                    Console.WriteLine("Día no laborable");
                    break;
                case "domingo":
                    Console.WriteLine("Día no laborable");
                    break;

            }
        }

        public static void ejercicio22()
        {
            String pass = "1234";
            
            int contador = 0;
            String str = "";
            do
            {
                Console.WriteLine("Introduce la contraseña");
                str = Console.ReadLine();
                contador++;

            } while (pass != str || contador <= 3);

            if(str == pass)
                Console.Write("ENHORABUENA");
        }

        public static void ejercicio23() {
            Console.WriteLine("Introduce el primer operando");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo operando");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el signo");
            String signo = Console.ReadLine();
            switch (signo) {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                case "^":
                    Console.WriteLine(Math.Pow(num1, num2));
                    break;
                case "%":
                    Console.WriteLine(num1 % num2);
                    break;
            }
        }
    }
}