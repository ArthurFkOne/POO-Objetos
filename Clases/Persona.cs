using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_de_mayo.Clases
{
    //clases es una plantilla 
    //que contiene metodos y objetos

     public class Persona
    {

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public double Salario { get; set; }




        public void ImprimirDatos()
        {

            Console.WriteLine("Tu nombre es : "+this.Nombre);
            Console.WriteLine("Tu apellido es : " + this.Apellidos);
            Console.WriteLine("Tu edad es : " + this.Edad);
            Console.WriteLine("Tu salario es : " + this.Salario);
        }


    }
}
