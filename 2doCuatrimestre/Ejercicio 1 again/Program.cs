using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_again
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i;
            int num;

            for(i=0;i>5;i++)
            {
                Console.WriteLine("Ingrese un num: ");
                string a=Console.ReadLine();
                int.TryParse(a, out num);


            }

        }
    }
}
