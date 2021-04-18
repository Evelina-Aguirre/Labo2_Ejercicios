using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
por consola.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).*/

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool thisIsPrimo= true;
            Console.WriteLine("Ingrese un número mayor a 1.");
            string input = Console.ReadLine();
            if(int.TryParse(input, out num))
            {
                if(num>1)
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
                else
                {
                    Console.WriteLine("Error.");
                }
            }
            else
            {
                Console.WriteLine("Error.");
            }

            Console.ReadKey();
        }
    }
}
