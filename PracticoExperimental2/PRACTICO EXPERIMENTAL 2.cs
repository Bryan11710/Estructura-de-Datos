using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> fila = new Queue<string>();
        const int capacidad = 30;
        int turno = 1;

        Console.WriteLine("=== Ingreso a la atracción (máximo 30 personas) ===\n");

        while (fila.Count < capacidad)
        {
            Console.Write($"Ingrese el nombre de la persona #{turno}: ");
            string nombre = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine(" Nombre inválido. Intente nuevamente.\n");
                continue;
            }

            fila.Enqueue(nombre);
            Console.WriteLine(" Registro exitoso.\n");
            turno++;
        }

        Console.WriteLine("\n=== Lista de personas registradas ===");
        turno = 1;
        foreach (var nombre in fila)
        {
            Console.WriteLine($"Turno: {turno} | Nombre: {nombre}");
            turno++;
        }

        Console.WriteLine($"\nTotal ocupados: {fila.Count}/{capacidad}");
    }
}
