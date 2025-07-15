using System;
using System.Collections.Generic;

namespace AgendaFutbol
{
    // Clase que representa un contacto (jugador)
    class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Contacto(string nombre, string telefono, string email)
        {
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Teléfono: {Telefono}, Email: {Email}";
        }
    }

    // Clase que maneja la agenda de jugadores
    class Agenda
    {
        private List<Contacto> contactos;

        public Agenda()
        {
            contactos = new List<Contacto>();
        }

        public void AgregarContacto(Contacto contacto)
        {
            contactos.Add(contacto);
            Console.WriteLine($"Contacto agregado: {contacto.Nombre}");
        }

        public void MostrarContactos()
        {
            Console.WriteLine("\n--- Lista de Jugadores ---");
            foreach (Contacto c in contactos)
            {
                Console.WriteLine(c);
            }
        }

        public void BuscarContacto(string criterio)
        {
            Console.WriteLine($"\nBuscando contactos con el término: '{criterio}'");
            bool encontrado = false;
            foreach (Contacto c in contactos)
            {
                if (c.Nombre.ToLower().Contains(criterio.ToLower()))
                {
                    Console.WriteLine(c);
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("No se encontró ningún contacto que coincida.");
            }
        }
    }

    // Clase principal del programa
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

            // Agregar algunos contactos de ejemplo con nombres de jugadores de fútbol
            agenda.AgregarContacto(new Contacto("Lionel Messi", "1122334455", "messi@hotmail.com"));
            agenda.AgregarContacto(new Contacto("Cristiano Ronaldo", "2233445566", "cristiano@gmail.com"));
            agenda.AgregarContacto(new Contacto("Neymar Jr.", "3344556677", "neymar@outlook.com"));

            // Mostrar todos los contactos
            agenda.MostrarContactos();

            // Realizar una búsqueda en la agenda
            agenda.BuscarContacto("Messi");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
