using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Ejuercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num=10000;
            int acum=0;

            for (int i = 1; i < num; i++)
			{
                if(num % i==0)
                { 
                    acum+=num;

                    if(acum==num)
                    {
                        Console.WriteLine("{0} Es un número perfecto",i);
                    }
                }

			}
            Console.ReadKey();*/
             int acum; int num; int j;
               
                Console.Write("Determine hasta que numero desea realizar la busqueda de numeros perfectos: ");
                num = int.Parse(Console.ReadLine());

                for (int i = 1; i <= num; i++)
                {
                    acum= 0;

                    for (j = 1; j <= (i / 2); j++)//vá desde 1 hasta la mitad del número, porque google dice yyy funciona,FIN.
                    {
                        if (i % j == 0)
                        {
                            acum += j;             
                        }
                    }
                    if (acum == i)
                        Console.WriteLine("El numero " + i + " es perfecto" );
                   
                 
                }
                Console.ReadKey();
            

        }
    }
}
