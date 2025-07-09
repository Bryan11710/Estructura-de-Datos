using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== SEMANA 07 – PILAS EN C# ===");
            Console.WriteLine("1. Verificar paréntesis balanceados");
            Console.WriteLine("2. Resolver Torres de Hanoi");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            string? opcion = Console.ReadLine();
            if (opcion == null) opcion = "";

            if (opcion == "1")
            {
                Console.Write("Ingrese una expresión matemática: ");
                string? expresion = Console.ReadLine();

                if (string.IsNullOrEmpty(expresion))
                {
                    Console.WriteLine("⚠️ Expresión vacía.");
                }
                else
                {
                    Console.WriteLine(EstaBalanceada(expresion)
                        ? "✅ Fórmula balanceada."
                        : "❌ Fórmula no balanceada.");
                }
            }
            else if (opcion == "2")
            {
                Console.Write("Ingrese el número de discos: ");
                string? entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int n) && n > 0)
                {
                    Stack<int> origen = new Stack<int>();
                    Stack<int> auxiliar = new Stack<int>();
                    Stack<int> destino = new Stack<int>();

                    for (int i = n; i >= 1; i--)
                        origen.Push(i);

                    MostrarTorres(origen, auxiliar, destino);
                    ResolverHanoi(n, origen, destino, auxiliar);
                }
                else
                {
                    Console.WriteLine("⚠️ Número inválido.");
                }
            }
            else if (opcion == "0")
            {
                break;
            }
            else
            {
                Console.WriteLine("⚠️ Opción no válida.");
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }

    static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();
        Dictionary<char, char> pares = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        foreach (char c in expresion)
        {
            if (pares.ContainsValue(c))
                pila.Push(c);
            else if (pares.ContainsKey(c))
            {
                if (pila.Count == 0 || pila.Pop() != pares[c])
                    return false;
            }
        }

        return pila.Count == 0;
    }

    static void ResolverHanoi(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar)
    {
        if (n == 1)
        {
            destino.Push(origen.Pop());
            MostrarTorres(origen, auxiliar, destino);
        }
        else
        {
            ResolverHanoi(n - 1, origen, auxiliar, destino);
            destino.Push(origen.Pop());
            MostrarTorres(origen, auxiliar, destino);
            ResolverHanoi(n - 1, auxiliar, destino, origen);
        }
    }

    static void MostrarTorres(Stack<int> origen, Stack<int> auxiliar, Stack<int> destino)
    {
        Console.WriteLine("Origen:   " + string.Join(", ", origen.ToArray()));
        Console.WriteLine("Auxiliar: " + string.Join(", ", auxiliar.ToArray()));
        Console.WriteLine("Destino:  " + string.Join(", ", destino.ToArray()));
        Console.WriteLine("-----------------------------------");
    }
}