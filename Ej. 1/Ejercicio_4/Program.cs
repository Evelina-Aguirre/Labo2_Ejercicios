using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
(excluido el mismo) que son divisores del número.
El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
Escribir una aplicación que encuentre los 4 primeros números perfectos.
Nota: Utilizar estructuras repetitivas y selectivas.*/

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_4";//NOW 

            double perfecto;
            double length=500;
            

            Console.WriteLine("Bienvenidx!! Hee nada, tomá, números perfectos : ");


            for (int i = 0; i <= length; i++)
            {
                if (num > 1)
                {
                    for (int i = 1; i <= num; i++)
                    {
                        for (int j = 2; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                thisIsPrimo = false;
                                break;
                            }

                        }
                        if (thisIsPrimo)
                        {
                            Console.WriteLine(i + " es primo.");

                        }
                        thisIsPrimo = true;
                    }

                }
            Console.ReadKey();

            /* ///////////////////////////////////////////////Como lo hice la vez pasada///////////////////////////////////////////////
             * int acum; int num; int j;

             Console.Write("Determine hasta que numero desea realizar la busqueda de numeros perfectos: ");
             num = int.Parse(Console.ReadLine());

             for (int i = 1; i <= num; i++)
             {
                 acum = 0;

                 for (j = 1; j <= (i / 2); j++)//vá desde 1 hasta la mitad del número, porque google dice yyy funciona,FIN.
                 {
                     if (i % j == 0)
                     {
                         acum += j;
                     }
                 }
                 if (acum == i)
                     Console.WriteLine("El numero " + i + " es perfecto");


             }  
             Console.ReadKey();
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////*/
        }
    }
}
