using _16_de_mayo.Clases;
using System;

namespace _16_de_mayo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Persona persona = new Persona();

            persona.Nombre = "Raziel";
            persona.Apellidos = "Martinez";
            persona.Edad = 19;
            persona.Salario= 20.00;
            persona.ImprimirDatos();
            Console.WriteLine(persona.Nombre);

            persona.Nombre = "Carlos";
            persona.Apellidos = "Jimenez";
            persona.Edad = 19;
            persona.Salario = 1400.00;
            persona.ImprimirDatos();
            Console.WriteLine(persona.Nombre);

        }
    }
}
