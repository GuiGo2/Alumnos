using System;

namespace Alumnos
{
    class Persona
    {
        enum Metodo
    {
        saludo,

        Nombre,
        
        apellido
    }
        static void Main(string[] args)
        {
            
            var nombre = "Pikachu";
            var apellido = "Gonzalez";

            saludo = Console.WriteLine("hola! " + nombre + " " + apellido + " es mi nombre completo.");
        }
    }
}
