using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas
trabajadas en el mes de N empleados de una fábrica.

Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el
valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
descuentos.
Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
Nota: Utilizar estructuras repetitivas y selectivas.*/

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 8";

            int horas = 0;
            string nombre = "";
            int antiguedad = 0;
            float valorHora = 0;
            float bruto = 0;
            float neto = 0;
            float descuento = 0;
            string respuesta = "s";

            do
            {
                Console.WriteLine("Ingrese Nombre :");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Horas Trabajadas :");
                string input = Console.ReadLine();
                int.TryParse(input, out horas);
                Console.WriteLine("Ingrese Antiguedad :");
                string input1 = Console.ReadLine();
                int.TryParse(input1, out antiguedad);
                Console.WriteLine("Ingrese valor de la Hora :");
                string input2 = Console.ReadLine();
                float.TryParse(input2, out valorHora);

                bruto = (horas * valorHora) + (antiguedad * 150);
                descuento = (bruto * 13) / 100;
                neto = bruto - descuento;


                Console.WriteLine("--------------------\n" +
                                  "INGRESO DE EMPLEADOS\n" +
                                  "--------------------\n" +
                                  "Nombre : {0}\n" +
                                  "Antiguedad : {1}\n" +
                                  "Horas Trabajadas : {2}\n" +
                                  "Valor hora : {3}\n" +
                                  "Total Bruto: {4}\n" +
                                  "Descuento: {5}\n" +
                                  "Total neto:{6}\n" +
                                  "--------------------\n" +
                                  "--------------------\n", nombre, antiguedad, valorHora, horas, bruto, descuento, neto);
                Console.ReadKey();

                Console.WriteLine(" Desea continuar ingresando empleados? (s/n)");
                respuesta = Console.ReadLine();
            } while (respuesta == "s");

            Console.ReadKey();

        }
    }
}
