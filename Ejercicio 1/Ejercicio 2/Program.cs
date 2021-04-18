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

            Console.Write("Igrese un número: ");
            int numero = int.Parse(Console.ReadLine()); //Sigo sin entender el Parse lo pongo because fuck you that´s why

            if(numero <=0)
            {
                Console.WriteLine("\nERROR. ¡Reingresar número!");
                numero = int.Parse(Console.ReadLine());
            }

            //Resumiendo POW viene adrentro de Math y es específicamente para esto (cuadrado, cubo)
            double cuadrado = Math.Pow(numero,2);
            double cubo = Math.Pow(numero,3);
            
            
            Console.WriteLine("\nCuadrado: {0} \nCubo {1}",cuadrado,cubo);
            Console.ReadLine();


        }
    }
}
