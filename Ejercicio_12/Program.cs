using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio12;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 12";

            int numero;
            int acum = 0;
            char respuesta;

            do
            {
                Console.Write("Ingrese un numero: ");
                int.TryParse(Console.ReadLine(), out numero);

                acum += numero;

                Console.Write("Desea continuar? (S/N): ");
                respuesta = char.Parse(Console.ReadLine());
                Console.Clear();
            } while (Ejercicio12.ValidarRespuesta.ValidarS_N(respuesta));

            Console.Write("La suma de los números ingresados es: {0}", acum);

            Console.ReadKey();
            
            /* Prueba toUpper
             * ----------------------
             char respuesta;
             string input;
             Console.WriteLine("ingrese s");
             input = Console.ReadLine();
             char.TryParse(input, out respuesta);
             Console.WriteLine( respuesta );
             respuesta = char.ToUpper(respuesta); 
             Console.WriteLine(respuesta);
             Console.ReadKey();*/


        }
    }
}
