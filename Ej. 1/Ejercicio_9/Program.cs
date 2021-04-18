using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Escribir un programa que imprima por pantalla una pirámide como
la siguiente:
*
***
*****
*******
**********/

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 09";

            int altura;
            string asterisco = "*";

            Console.WriteLine("Ingrese altura :");
            string input = Console.ReadLine();
            int.TryParse(input, out altura);

            for (int i = 1; i <= altura; i++)
            {
                if (altura == 1)
                {
                    Console.WriteLine(asterisco);

                }
                else
                {
                    asterisco = asterisco + "**";
                    Console.WriteLine(asterisco);
                }
            }
            Console.ReadKey();

        }
    }
}
