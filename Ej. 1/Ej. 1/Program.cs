using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1. Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el
valor máximo, el valor mínimo y el promedio.*/

namespace Ej._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Ejercicio Nro 01";

            int numero;
            int max = int.MinValue;//al máximo le asigno el menor valor q puede tomar así lo q venga la primera vz siempre es el máx.
            int min = int.MaxValue;//Lo mismo al revés.
            int acumulador=0;

            Console.WriteLine("Ingrese 5 números: ");
          

            for (int i = 0; i < 5; i++)
            {
                string auxTomaTeclado = Console.ReadLine();
                int.TryParse(auxTomaTeclado, out numero);
                if( numero > max)
                {
                    max = numero;
                }

                if (numero < min)
                {
                    min = numero;
                }
                
                acumulador += numero;
                
            }
            
            float promedio = acumulador / 5;
            Console.WriteLine("Máximo : {0}" +
                "\nMínimo : {1}" +
                "\nPromedio : {2}", max, min, promedio);
            Console.ReadKey();

        }
    }
}
