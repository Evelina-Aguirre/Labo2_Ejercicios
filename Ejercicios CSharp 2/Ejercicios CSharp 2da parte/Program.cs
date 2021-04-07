using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_CSharp_2da_parte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 7";

            int horas=0;
            string nombre="";
            int antiguedad=0;
            float valorHora=0;
            float bruto=0;
            float neto=0;
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

                bruto = (horas * valorHora)+(antiguedad*150);
                descuento = (bruto * 13)/100;
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
                                  "--------------------\n", nombre,antiguedad,valorHora,horas,bruto,descuento,neto);
                Console.ReadKey();

                Console.WriteLine(" Desea continuar ingresando empleados? (s/n)");
                respuesta = Console.ReadLine();
            } while (respuesta == "s");

            

        }
    }
}
