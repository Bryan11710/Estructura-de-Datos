using System;  // Importa el espacio de nombres para manejar la entrada y salida en consola

// Definición de la clase Jugador
class Jugador
{
    // Propiedades del jugador (datos personales)
    public int Id { get; set; } // Identificador único del jugador
    public string Nombres { get; set; } // Nombre del jugador
    public string Apellidos { get; set; } // Apellidos del jugador
    public string Equipo { get; set; } // Nombre del equipo donde juega
    public string[] Telefonos { get; set; } // Lista de tres números de teléfono

    // Constructor de la clase Jugador
    public Jugador(int id, string nombres, string apellidos, string equipo, string[] telefonos)
    {
        Id = id;  // Asigna el ID
        Nombres = nombres;  // Asigna el nombre
        Apellidos = apellidos;  // Asigna el apellido
        Equipo = equipo;  // Asigna el equipo
        Telefonos = telefonos;  // Asigna el array de teléfonos
    }

    // Método para mostrar la información del jugador
    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombre Completo: {Nombres} {Apellidos}");
        Console.WriteLine($"Equipo: {Equipo}");
        Console.WriteLine("Teléfonos de contacto:");
        
        // Recorre la lista de teléfonos y los imprime uno por uno
        foreach (string tel in Telefonos)
        {
            Console.WriteLine($"- {tel}");
        }
    }
}

// Clase principal que ejecuta el programa
class Program
{
    static void Main(string[] args)
    {
        // Definición de un arreglo con tres números de teléfono
        string[] telefonos = { "099111222", "098333444", "097555666" };

        // Creación de un objeto Jugador con datos de un futbolista
        Jugador jugador = new Jugador(10, "Lionel", "Messi", "Inter Miami", telefonos);

        // Llamada al método para mostrar la información en consola
        jugador.MostrarInformacion();
    }
}

