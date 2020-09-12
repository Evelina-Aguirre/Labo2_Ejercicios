using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int num;
            double cuadrado=0;
            double cubo=0;
            bool salida = false;

            do
            {
                Console.Write("Ingrese un num:");
                String a = Console.ReadLine();
                int.TryParse(a, out num);

                if (num <= 0)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    cuadrado = Math.Pow(num, 2);
                    cubo = Math.Pow(num, 3);
                    salida = true;
                }
            } while (salida == false);

            Console.WriteLine("Num Ingresado {0}", num);
            Console.WriteLine("Cuadrado {0}", cuadrado);
            Console.WriteLine("Cubo {0}", cubo);
            Console.ReadKey();*/

            int max = int.MinValue;
            int min = int.MaxValue;
            int numero; 
            int acumulador=0,contador=0;
            double promedio;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese número {0} : ",i);
                string input = Console.ReadLine();
                int.TryParse(input,out numero);
                if(numero>max)
                {
                    max = numero;
                }

                if (numero < min)
                {
                    min = numero;
                }
                contador++;
                acumulador = +numero;
               
            }
            promedio=(double)acumulador/contador;
            Console.WriteLine("Valor máximo: {0}",max);
            Console.WriteLine("Valor mínimo: {0}",min);
            Console.WriteLine("Valor promedio: {0}",promedio);
            Console.ReadKey();

            //Pero excelente 



        }
    }
}
