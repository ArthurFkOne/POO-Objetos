using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_de_mayo.Services
{
     public class ofertas
    {

        public void off(int valor)
        {

            double off = 0;
            int el = 0;

            if (valor >= 10000) {

                Console.WriteLine("Elija si desea 1.- 6 meses sin intereses o 2.- 12 meses sin intereses");
                el=int.Parse(Console.ReadLine());
                
                switch (el)
                {

                    case 1:

                        Console.WriteLine("Disfrute de sus pagos a 6 meses sin interes!");
                        off = valor/6;
                        
                        Console.WriteLine("Su monto previo era: "+valor+" Su monto final a pagar mensualmente por 6 meses es: "+off);

                        break;
                    case 2:



                        Console.WriteLine("Disfrute de sus pagos a 12 meses sin interes!");
                        off = valor/12;
                        Console.WriteLine("Su monto previo era: " + valor + " Su monto final a pagar mensual por 12 meses es: " + off);


                        break;



                }

            
            } else if (valor >= 8000)
            {

                Console.WriteLine("Disfruta de 3 meses sin intereses!");
                
                off= valor/3;
                Console.WriteLine("Su monto previo era: " + valor + " Su monto final a pagar por 3 meses es: " + off);


            }
            else if (valor >= 5000)
            {


                Console.WriteLine("Disfruta un descuento del 10%!");
                off = valor-(valor*0.10);
                Console.WriteLine("Su monto previo era: " + valor + " Su monto final con desccuento de 10% es: " + off);
            }
            else
            {


                Console.WriteLine("No has podido acceder a ninguna de las ofertas :c");
               
                Console.WriteLine("Tu monto final a pagar es de: " + valor);


            }



        }






    }
}
