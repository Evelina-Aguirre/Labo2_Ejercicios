using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_2
{
    class Program
    {
        static void Main(string[] args)
        {

            const double PI = 3.1416;
            Console.WriteLine("Introduce Radio :");
            double radio = double.Parse(Console.ReadLine());
            double area = Math.Pow(radio,2) * PI;
            Console.WriteLine($"El area es: {area} ");
            Console.ReadKey();

        }
    }
}
