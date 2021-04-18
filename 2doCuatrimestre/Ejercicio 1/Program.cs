using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doCuatrimestre
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int numero;
            int max=int.MinValue;
            int min=int.MaxValue;
            int promedio;
            int acumulador=0;

           

            for(i=0;i<5;i++)
            {

                Console.Write("Ingreso un número = ");
                string a= Console.ReadLine();
               
                int.TryParse(a, out numero);
                if(max<numero)
                {
                    max = numero;
                }
                if(numero<min)
                {
                    min = numero;
                }
                acumulador = numero + acumulador;

            }

            promedio = acumulador / 5;
            Console.WriteLine("Mayor: {0}", max);
            Console.WriteLine("Menor: {0}", min);
            Console.WriteLine("Promedio: {0}", promedio);

            Console.ReadKey();


        }

    }
}
