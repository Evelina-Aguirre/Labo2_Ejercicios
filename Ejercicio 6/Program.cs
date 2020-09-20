﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 6";
            Console.WriteLine("AÑOS BISIESTOS \n -------------------\n");
            int anioUno;
            int anioDos;

            //Ingreso de datos
            Console.WriteLine("Ingrese el rando de años a calcular.");
            Console.ReadKey();
            Console.WriteLine("Año uno:");
            string input1 = Console.ReadLine();
            int.TryParse(input1, out anioUno);
            Console.WriteLine("Año uno:");
            string input2 = Console.ReadLine();
            int.TryParse(input2, out anioDos);
            
            //recorro el rango de años
            for (int i = anioUno; i <= anioDos; i++)
            {
                if((i % 100 == 0) &&(i % 400 != 0))
                {
                    //Si es multiplo de 100 NO ES bisiesto, pero si es mult. de 100 y de 400 a la vez, SI ..- 
                }
                else if(i % 4 == 0)//Si es multiplo de 4 es bisiesto..
                {
                    Console.WriteLine("El Año {0} es bisciesto", i);
                }    

            }
            Console.ReadKey();
        }
    }
}
