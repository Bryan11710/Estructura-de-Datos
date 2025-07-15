using System;

namespace Semana6
{
    class Semana6
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("===== MENÚ DE EJERCICIOS SEMANA 6 =====");
                Console.WriteLine("1. Ejercicio 1: Suma de dos números");
                Console.WriteLine("2. Ejercicio 2: Tabla de multiplicar");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Entrada inválida. Presione una tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("===== EJERCICIO 1: Suma de dos números =====\n");
                        Ejercicio1_SumaDeDosNumeros();
                        break;
                    case 2:
                        Console.WriteLine("===== EJERCICIO 2: Tabla de multiplicar =====\n");
                        Ejercicio2_TablaDeMultiplicar();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione una tecla para volver al menú...");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }

        // ===================== EJERCICIO 1 =====================
        static void Ejercicio1_SumaDeDosNumeros()
        {
            Console.Write("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int suma = num1 + num2;
            Console.WriteLine($"La suma es: {suma}");
        }

        // ===================== EJERCICIO 2 =====================
        static void Ejercicio2_TablaDeMultiplicar()
        {
            Console.Write("Ingrese un número para ver su tabla de multiplicar: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}
 