using System;

class Jugador
{
    public int Id { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public string Equipo { get; set; }
    public string[] Telefonos { get; set; }

    public Jugador(int id, string nombres, string apellidos, string equipo, string[] telefonos)
    {
        Id = id;
        Nombres = nombres;
        Apellidos = apellidos;
        Equipo = equipo;
        Telefonos = telefonos;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombre Completo: {Nombres} {Apellidos}");
        Console.WriteLine($"Equipo: {Equipo}");
        Console.WriteLine("Teléfonos:");
        foreach (string tel in Telefonos)
        {
            Console.WriteLine($"- {tel}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        string[] telefonos = { "099111222", "098333444", "097555666" };
        Jugador jugador = new Jugador(10, "Lionel", "Messi", "Inter Miami", telefonos);
        jugador.MostrarInformacion();
    }
}
