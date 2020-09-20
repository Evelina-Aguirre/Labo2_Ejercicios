using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidBinario;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 13";

            double numeroDecimal;
            string numeroBinario;
            double numeroEnDecimal;
            string numeroEnBinario;


            Console.Write("Ingrese el número decimal a convertir: ");
            numeroDecimal = double.Parse(Console.ReadLine());

            numeroEnBinario = Conversor.DecimalBinario(numeroDecimal);

            Console.WriteLine("El numero ingresado en Binario: {0}", numeroEnBinario);

            Console.WriteLine("");

            Console.Write("Ingrese numero binario a convertir: ");

            numeroBinario = Console.ReadLine();

            numeroEnDecimal = Conversor.BinarioDecimal(numeroBinario);

            Console.WriteLine("El numero binario en decimal es: {0}", numeroEnDecimal);
            Console.ReadKey();


        }
    }
}
