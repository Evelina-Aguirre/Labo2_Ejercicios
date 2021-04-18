using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, anio;
            DateTime ahora = DateTime.Now;

            //Título dia
            Console.Write("Ingrese Su fecha de nacimiento \n" +
                          "****************************** \nDía :");
            string input = Console.ReadLine();
            int.TryParse(input, out dia);
            //mes
            Console.Write("Mes :");
            string input2 = Console.ReadLine();
            int.TryParse(input2, out mes);
            //Año
            Console.Write("Año :");
            string input3 = Console.ReadLine();
            int.TryParse(input3, out anio);

            //Asigno los valores obtenidos a formato fecha 
            DateTime fechaNac = new DateTime(anio, mes, dia);
            DateTime promedio = new DateTime(1920, 01, 01);

            //Uso método p/ calcular diferencia entre fechas, devuelve cantidad de días
            int resultado = CalculateDays(fechaNac, ahora);
            int resultadoPromedio = CalculateDays(promedio, ahora);

            Console.WriteLine("Estás viv@ hace {0} días.", resultado);
            Console.WriteLine("Promedio de vida esperado para un humano: {0} días." +
                "\n...O podés morir esta noche, adivino no soy.", resultadoPromedio);

            Console.ReadKey();

        }
        public static int CalculateDays(DateTime oldDate, DateTime newDate)
        {
            // Diferencia de fechas
            TimeSpan ts = newDate - oldDate;

            // Diferencia de días
            return ts.Days;
        }
    }
    }
}
