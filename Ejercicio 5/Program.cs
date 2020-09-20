using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.Title = "Ejercicio 5";
             double aumento=1,
                num,
                i,
                j,
                sumaAtras,
                sumaAdelante;

             Console.WriteLine("Ingrese Numero :");
             String input = Console.ReadLine();
             double.TryParse(input, out num);

             while (aumento < num)
             {
                 aumento++;
                 sumaAtras = 0;
                 sumaAdelante = 0;

                 for (i = aumento; i >= 1; i++)
                 {
                     sumaAtras += i;
                 }
                 for(j=aumento+1;j<=sumaAtras;j++)
                 {
                     sumaAdelante += j;
                 }
                 // Mostrando en pantalla
                 if (sumaAtras == sumaAdelante)
                     Console.WriteLine("Es centro numerico: {0}", aumento);
             }*/

            // Mensaje
            Console.Title = "Ejercicio 05";
            Console.WriteLine("Calculo centro numerico\n" +
                              "-----------------------");
            // Variables
            double aumento = 1,
                numero,
                i,
                j,
                sumaAtras,
                sumaAdelante;

            // Ingreso de datos
            Console.Write("Ingrese un numero (ejemplo: 10000): ");
            numero = double.Parse(Console.ReadLine());

            // Comienzo del programa
            while (aumento < numero)
            {

                aumento++;
                sumaAtras = 0;
                sumaAdelante = 0;

                // Calculo para atrás..(en la vida en general)
                for (i = 1; i < aumento; i++)
                {
                    sumaAtras = sumaAtras + i;
                }
                //calculo para adelante(sometimes)
                for (j = aumento + 1; j <= sumaAtras; j++)
                {
                    if ((sumaAdelante == sumaAtras) || (sumaAdelante > sumaAtras))
                        break;
                    sumaAdelante = sumaAdelante + j;
                }

                // Mostrando en pantalla
                if (sumaAtras == sumaAdelante)
                    Console.WriteLine("Es centro numerico: {0}", aumento);
            }
            Console.ReadLine();
            //tasa tasa..
        }
    }
}
