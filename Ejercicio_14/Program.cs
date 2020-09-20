using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculoDeArea;
using Validaciones;
using Ejercicio12;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            char respuesta;
            int opcion;
            double ladoCuadrado,baseTriangulo,alturaTriangulo, radioCirculo;
            double areaCuadrado, areaTriangulo, areaCirculo;

            do
            {
                Console.Write("----------------------------\n" +
                                  "    CALCULADORA DE ÁREAS \n" +
                                  "----------------------------\n" +
                                  "1- CUADRADO\n" +
                                  "2- TRIÁNGULO\n" +
                                  "3- CÍRCULO\n" +
                                  "----------------------------\n" +
                                  "Opción-> ");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("CALCULO AREA CUADRADO:\n" +
                                 "-----------------------");
                        Console.Write("LADO :");
                        while (double.TryParse(Console.ReadLine(), out ladoCuadrado) == false || ladoCuadrado < 0)
                        {
                            Console.Write("ERROR! ");
                            Console.Write("Reingrese valor del lado: ");
                        }
                        areaCuadrado = CalculoDeArea.CalculoDeArea.CalcularCuadrado(ladoCuadrado);
                        Console.WriteLine("\nEl área del cuadrado es: {0} \n", areaCuadrado);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("CALCULO AREA TRIÁNGULO:\n" +
                                           "-----------------------");
                        Console.Write("BASE :");
                        while (double.TryParse(Console.ReadLine(), out baseTriangulo) == false || baseTriangulo < 0)
                        {
                            Console.Write("ERROR! ");
                            Console.Write("Reingrese valor del base: ");
                        }
                        Console.Write("ALTURA :");
                        while (double.TryParse(Console.ReadLine(), out alturaTriangulo) == false || alturaTriangulo < 0)
                        {
                            Console.Write("ERROR! ");
                            Console.Write("Reingrese valor de la altura: ");
                        }
                        areaTriangulo = CalculoDeArea.CalculoDeArea.CalcularTriangulo(baseTriangulo, alturaTriangulo);
                        Console.WriteLine("\nEl área del Triángulo es: {0} \n", areaTriangulo);
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("CALCULO AREA CÍRCULO:\n" +
                                 "-----------------------");
                        Console.Write("RADIO :");
                        while (double.TryParse(Console.ReadLine(), out radioCirculo) == false || radioCirculo < 0)
                        {
                            Console.Write("ERROR! ");
                            Console.Write("Reingrese valor del radio: ");
                        }
                        areaCirculo = CalculoDeArea.CalculoDeArea.CalcularCirculo(radioCirculo);
                        Console.WriteLine("\nEl área del Círculo es: {0} \n", areaCirculo);
                        break;

                    default:

                        Console.WriteLine("*La opción ingresada no es válida.*\n");
                        break;
            }
                Console.WriteLine("Desea continuar? (S/N)");
                char.TryParse( Console.ReadLine(), out respuesta);
                Console.Clear();

            } while (Ejercicio12.ValidarRespuesta.ValidarS_N(respuesta));
         

        }
    }
}
