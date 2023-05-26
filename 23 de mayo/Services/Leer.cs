using _23_de_mayo.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_de_mayo.Services
{
    public class Leer
    {

        Cliente cliente = new Cliente();
        Menu menu;

        public void Pedir()
        {
            Console.WriteLine("Bienvenido usuario!");

            Console.WriteLine("Por favor escribe tu nombre");
            cliente.Nombre = Console.ReadLine();

            Console.WriteLine("Ahora escribe tu numero de telefono");
            cliente.Numero = Console.ReadLine();


            Console.WriteLine("Por favor escribe tu correo");
            cliente.Correo = Console.ReadLine();


            new Menu();

        }

        public void imprimir()
        {


            Console.WriteLine("Nombre del cliente: "+cliente.Nombre);
            Console.WriteLine("Numero del cliente: " + cliente.Numero);
            Console.WriteLine("Correo del cliente: " + cliente.Correo);
        }







    }
}
