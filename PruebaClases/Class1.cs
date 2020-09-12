using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace PruebaClases
{
    public class Class1
    {
        static void Main(string[]args)
        {
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

                if (numero > min)
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
        }
    }
}
