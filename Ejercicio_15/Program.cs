using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora;
using Ejercicio12;


namespace Ejercicio_15
{
    class Program
    {//Calculadora simple, se hace según se pide la guía, sería más eficiente si en el método calcular, se devolviera resultado por 
        //parámetro y true/false en el return para los casos en que el operador no sea correcto o se intente dividir por 0. 
        static void Main(string[] args)
        {
            char respuesta;
            double resultado;
            string operacion;
            double numUno, numDos;

            do
            {
                Console.Write("----------------------------\n" +
                              "    CALCULADORA  \n" +
                              "----------------------------\n" +
                              "Ingrese 1er operando: ");
                while (double.TryParse(Console.ReadLine(), out numUno) == false)
                {
                    Console.WriteLine("ERROR. Reingrese 1er operando");
                }
                Console.Write("Igrese 2do operando: ");
                while (double.TryParse(Console.ReadLine(), out numDos) == false)
                {
                    Console.WriteLine("ERROR. Reingrese 1er operando: ");
                }

                Console.WriteLine("----------------------------\n");
                Console.WriteLine("Operación a realizar (+,-,*,/): ");
                operacion = Console.ReadLine();

                while (operacion != "+" && operacion != "-" && operacion != "*" && operacion != "/")
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("ERROR.El operador ingresado es inválido.");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Operación a realizar (+,-,*,/): ");
                    operacion = Console.ReadLine();
                }
                resultado = Calculadora.Calculadora.calcular(numUno, numDos, operacion);
                Console.WriteLine("{0} {1} {2} = {3}", numUno, operacion, numDos, resultado);
              
                Console.WriteLine("\nDesea continuar? (S/N)");
                char.TryParse(Console.ReadLine(), out respuesta);
                Console.Clear();

            } while (Ejercicio12.ValidarRespuesta.ValidarS_N(respuesta));
           

        }
    }
}
