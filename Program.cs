using System;

namespace Alumnos
{
    class Persona
    {
        public string nombre;
        public string apellido;

        public string NombreCompleto
        {
             get => this.nombre + " " + this.apellido;
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

         public void Presentarse()
        {

             Console.WriteLine("hola! " + this.nombre + " " + this.apellido + " es mi nombre completo.");
        }

    
       
    }
}
