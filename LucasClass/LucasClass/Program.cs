using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int max;
            int min;
            int flag = 0;


            for (int i = 0; i < 5 ; i++)
            {
                Console.WriteLine("Ingrese un número : ");
                numero = int.Parse(Console.ReadLine());

                if(flag==0 || numero>max)
                {
                    max = numero;
                    
                }
                if (flag == 0 || numero > min)
                {
                    min = numero;
                    flag = 1;
                }

            }

        }
    }
}
