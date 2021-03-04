using System;

namespace Alumnos
{
    class Persona1
    {
        public string nombre;
        public string apellido;

        public string nombrecompleto;

    {
      //  saludo,

      //  Nombre,
        
      //  apellido

        get => this.nombre + " " + this.apellido
    }
        public void Presentarse()
        {
            
            var nombre = "Pikachu";
            var apellido = "Gonzalez";

             Console.WriteLine("hola! " + nombre + " " + apellido + " es mi nombre completo.");
        }
    }
}