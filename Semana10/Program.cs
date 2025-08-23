using System;
using System.Collections.Generic;
using System.Linq;

public class CampanaVacunacion
{
    public static void Main(string[] args)
    {
        // --- 1. Creación de los conjuntos de datos ficticios ---
        // Se establecen variables en líneas separadas para evitar errores de sintaxis
        const int totalCiudadanos = 500;
        const int totalPfizer = 75;
        const int totalAstraZeneca = 75;
        const int ambos = 30; // Número de ciudadanos que se vacunaron con ambas dosis para crear la intersección

        // Conjunto universal: todos los ciudadanos
        var todosLosCiudadanos = new HashSet<string>();
        for (int i = 1; i <= totalCiudadanos; i++)
        {
            todosLosCiudadanos.Add($"Ciudadano_{i}");
        }

        // Conjunto de ciudadanos vacunados con Pfizer
        var pfizerVacunados = new HashSet<string>();
        for (int i = 1; i <= ambos; i++)
        {
            pfizerVacunados.Add($"Ciudadano_{i}");
        }
        for (int i = ambos + 1; i <= totalPfizer; i++)
        {
            pfizerVacunados.Add($"Ciudadano_{i}");
        }

        // Conjunto de ciudadanos vacunados con AstraZeneca
        var astraZenecaVacunados = new HashSet<string>();
        for (int i = 1; i <= ambos; i++)
        {
            astraZenecaVacunados.Add($"Ciudadano_{i}");
        }
        for (int i = totalPfizer + 1; i <= totalPfizer + (totalAstraZeneca - ambos); i++)
        {
            astraZenecaVacunados.Add($"Ciudadano_{i}");
        }
        
        Console.WriteLine("Datos iniciales generados:");
        Console.WriteLine($"- Total de ciudadanos: {todosLosCiudadanos.Count}");
        Console.WriteLine($"- Vacunados con Pfizer: {pfizerVacunados.Count}");
        Console.WriteLine($"- Vacunados con AstraZeneca: {astraZenecaVacunados.Count}");

        // --- 2. Aplicación de operaciones de teoría de conjuntos para obtener los listados ---
        
        Console.WriteLine("\n--- Resultados de la Campaña de Vacunación ---");

        // a. Ciudadanos que no se han vacunado.
        // Se obtiene la unión de los conjuntos de vacunados con Pfizer y AstraZeneca.
        var todosVacunados = new HashSet<string>(pfizerVacunados);
        todosVacunados.UnionWith(astraZenecaVacunados);

        // Se obtiene la diferencia entre el conjunto universal y el conjunto de todos los vacunados.
        var noVacunados = new HashSet<string>(todosLosCiudadanos);
        noVacunados.ExceptWith(todosVacunados);
        
        Console.WriteLine($"\n1. Ciudadanos que no se han vacunado ({noVacunados.Count}):");
        foreach (var ciudadano in noVacunados.Take(10)) 
        {
            Console.WriteLine(ciudadano);
        }
        Console.WriteLine("...");

        // b. Ciudadanos que han recibido ambas dosis.
        // Se obtiene la intersección entre los conjuntos de vacunados con Pfizer y AstraZeneca.
        var ambasDosis = new HashSet<string>(pfizerVacunados);
        ambasDosis.IntersectWith(astraZenecaVacunados);
        
        Console.WriteLine($"\n2. Ciudadanos que han recibido ambas dosis ({ambasDosis.Count}):");
        foreach (var ciudadano in ambasDosis)
        {
            Console.WriteLine(ciudadano);
        }
        
        // c. Ciudadanos que solo han recibido la vacuna de Pfizer.
        // Se obtiene la diferencia entre el conjunto de vacunados con Pfizer y el de AstraZeneca.
        var soloPfizer = new HashSet<string>(pfizerVacunados);
        soloPfizer.ExceptWith(astraZenecaVacunados);
        
        Console.WriteLine($"\n3. Ciudadanos que solo han recibido la vacuna de Pfizer ({soloPfizer.Count}):");
        foreach (var ciudadano in soloPfizer)
        {
            Console.WriteLine(ciudadano);
        }
        
        // d. Ciudadanos que solo han recibido la vacuna de AstraZeneca.
        // Se obtiene la diferencia entre el conjunto de vacunados con AstraZeneca y el de Pfizer.
        var soloAstraZeneca = new HashSet<string>(astraZenecaVacunados);
        soloAstraZeneca.ExceptWith(pfizerVacunados);
        
        Console.WriteLine($"\n4. Ciudadanos que solo han recibido la vacuna de AstraZeneca ({soloAstraZeneca.Count}):");
        foreach (var ciudadano in soloAstraZeneca)
        {
            Console.WriteLine(ciudadano);
        }
    }
}