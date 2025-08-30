using System;
using System.Collections.Generic;

class Program
{
    // Diccionario inicial limpio (solo caracteres ASCII simples)
    static Dictionary<string, string> diccionario = new Dictionary<string, string>()
    {
        {"time", "tiempo"},
        {"person", "persona"},
        {"year", "ano"},
        {"way", "camino"},
        {"day", "dia"},
        {"thing", "cosa"},
        {"man", "hombre"},
        {"world", "mundo"},
        {"life", "vida"},
        {"eye", "ojo"}
    };

    static void Main()
    {
        Menu();
    }

    static void Menu()
    {
        while (true)
        {
            Console.WriteLine("\n==================== MENU ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opcion: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    TraducirFrase();
                    break;
                case "2":
                    AgregarPalabra();
                    break;
                case "0":
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opcion invalida, intente de nuevo.");
                    break;
            }
        }
    }

    static void TraducirFrase()
    {
        Console.Write("\nFrase ingresada: ");
        string frase = Console.ReadLine();
        string[] palabras = frase.Split(' ');
        string traduccion = "";

        foreach (string palabra in palabras)
        {
            // Limpiar signos de puntuacion
            string palabraLimpia = palabra.Trim(',', '.', '!', '?', ';', ':').ToLower();
            string traducida;

            if (diccionario.ContainsKey(palabraLimpia))
            {
                traducida = diccionario[palabraLimpia];
                // Mantener mayuscula inicial si la palabra original estaba en mayuscula
                if (char.IsUpper(palabra[0]))
                    traducida = char.ToUpper(traducida[0]) + traducida.Substring(1);
            }
            else
            {
                traducida = palabra;
            }

            // Mantener signos de puntuacion
            char ultimo = palabra[palabra.Length - 1];
            if (",.!?;:".Contains(ultimo))
                traducida += ultimo;

            traduccion += traducida + " ";
        }

        Console.WriteLine("Traduccion parcial: " + traduccion.Trim());
    }

    static void AgregarPalabra()
    {
        Console.Write("Ingrese la palabra en ingles: ");
        string ingles = Console.ReadLine().Trim().ToLower();
        Console.Write("Ingrese la traduccion al espanol: ");
        string espanol = Console.ReadLine().Trim();

        if (!diccionario.ContainsKey(ingles))
        {
            diccionario.Add(ingles, espanol);
            Console.WriteLine($"Palabra '{ingles}' agregada con traduccion '{espanol}'.");
        }
        else
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
        }
    }
}
