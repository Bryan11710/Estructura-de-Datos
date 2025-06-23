using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // === EJERCICIO 1: Notas por asignatura ===
        List<(string, double)> asignaturas1 = new List<(string, double)>
        {
            ("Matemáticas", 8.5),
            ("Historia", 6.0),
            ("Inglés", 9.0)
        };

        Console.WriteLine("Notas por asignatura:");
        foreach (var (nombre, nota) in asignaturas1)
            Console.WriteLine($"{nombre}: {nota}");

        Console.WriteLine("\n"); // Espacio visual entre ejercicios



        // === EJERCICIO 4: Números ganadores ordenados ===
        int[] numeros = { 34, 7, 21, 4, 15 };
        Array.Sort(numeros);
        Console.WriteLine("Números ganadores ordenados:");
        Console.WriteLine(string.Join(", ", numeros));

        Console.WriteLine("\n");



        // === EJERCICIO 6: Asignaturas reprobadas ===
        List<(string, double)> asignaturas2 = new List<(string, double)>
        {
            ("Biología", 4.5),
            ("Química", 6.0),
            ("Arte", 3.0)
        };

        Console.WriteLine("Asignaturas reprobadas:");
        foreach (var (nombre, nota) in asignaturas2.Where(a => a.Item2 < 5))
            Console.WriteLine($"{nombre}: {nota}");

        Console.WriteLine("\n");



        // === EJERCICIO 10: Precio mínimo y máximo ===
        double[] precios = { 10.5, 3.99, 7.25, 22.30, 5.0 };
        double min = precios.Min();
        double max = precios.Max();
        Console.WriteLine($"Precio mínimo: {min}");
        Console.WriteLine($"Precio máximo: {max}");

        Console.WriteLine("\n");



        // === EJERCICIO 5: Producto escalar ===
        int[] v1 = { 1, 2, 3 };
        int[] v2 = { 4, 5, 6 };
        int productoEscalar = 0;
        for (int i = 0; i < v1.Length; i++)
            productoEscalar += v1[i] * v2[i];

        Console.WriteLine($"Producto escalar: {productoEscalar}");
    }
}