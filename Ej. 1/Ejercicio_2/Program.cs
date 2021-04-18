using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.*/

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_2";

            int num;
            double cuadrado;
            double cubo;

            Console.WriteLine("Igrese un número :");
            String input = Console.ReadLine();
            if (int.TryParse(input, out num)) //intenta convertir string a int, devuelve un bool
            {
                if (num > 0)
                {
                    cuadrado = Math.Pow(num, 2);
                    cubo = Math.Pow(num, 3);
                    Console.Write("Cuadrado : {0} \nCubo : {1}", cuadrado, cubo);
                }
                else
                {
                    Console.WriteLine("El número debe ser mayor a 0.");//Fin del programa mi amigo. Otro día le doy otra chance. 
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            
            Console.ReadKey();
        }
    }
}
