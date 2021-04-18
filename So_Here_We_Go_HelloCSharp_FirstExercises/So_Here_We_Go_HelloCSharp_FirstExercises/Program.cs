using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace So_Here_We_Go_HelloCSharp_FirstExercises
/*1) Crear 3 variables numéricas con el valor que tu quieras y en otra variable numérica
 * guardar el valor de la suma de las 3 anteriores. Mostrar por consola.*/
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ex_1";
            int var1 = 1;
            int var2 = 12;
            int var3 = -10;
            int suma = var1 + var2 + var3;

            Console.WriteLine("La suma da : {0}", suma);
            Console.ReadKey();


        }
    }
}
