using _23_de_mayo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_de_mayo.Services
{
    internal class Menu
    {
        Articulos articulos = new Articulos();

        public Menu() {
            int Cont;
            int Resul=0;

            int []arreglo= new int[5];
            Console.WriteLine("-----Articulos en venta----- ");
            Console.WriteLine("1.- PlayStation 5:  $"+articulos.PS5);
            Console.WriteLine("2.- Switch Oled:  $" + articulos.Switch_Oled);
            Console.WriteLine("3.-Rolex:  $" + articulos.Reloj_Rolex);
            Console.WriteLine("4.- Teclado Razer :  $" + articulos.Teclado);
            Console.WriteLine("5.- Monitor Asus:  $" + articulos.TV);


            do
            {
                Console.WriteLine("Cuantos productos desea llevar: ");
                Cont = int.Parse(Console.ReadLine());

            }while(Cont>5 || Cont<1);


            for(int i=0; i<Cont; i++) {

                Console.WriteLine("Elije el numero del articulo a llevar "+(i+1)+" de "+Cont);
                arreglo[i]= int.Parse(Console.ReadLine());  

            }

            for (int i = 0; i < Cont; i++)
            {

                switch (arreglo[i])
                {

                    case 1: Resul = Resul + articulos.PS5; break;
                    case 2: Resul = Resul + articulos.Switch_Oled; break;
                    case 3: Resul = Resul + articulos.Reloj_Rolex; break;
                    case 4: Resul = Resul + articulos.Teclado; break;
                    case 5: Resul = Resul + articulos.TV; break;
                }

            }


            ofertas of= new ofertas();

            of.off(Resul);


        }





    }
}
