using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Title="Ejercicio 2";
           
            int num;
            double cuadrado;
            double cubo;
            int succes=0;

            do{
                Console.WriteLine("Ingrese un número mayor a 0.");
                string input=Console.ReadLine();
                int.TryParse(input, out num);

             if(num<=0)
                {
                Console.WriteLine("ERROR, Ingrese nuevamente un numero.");
                 cuadrado=0;
                 cubo=0;
                }
                else
                {
                cuadrado=Math.Pow(num,2);
                cubo=Math.Pow(num,3);
                succes=1;  
                }

            }while(succes==0);

            Console.WriteLine("El numero ingresado {0}",num);
            Console.WriteLine("Al cuadrado {0}",cuadrado);
            Console.WriteLine("Al cubo {0}",cubo);
            Console.ReadKey();

        }   
    }
}
