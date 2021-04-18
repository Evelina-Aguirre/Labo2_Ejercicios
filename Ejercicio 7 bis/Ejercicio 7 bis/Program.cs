
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
            int dia, mes, anio, teQueda;
            DateTime ahora = DateTime.Now;

            //Título dia
            Console.Write("Ingrese su fecha de nacimiento \n" +
                          "****************************** \n" +
                          "\nDía :");
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
            DateTime promedio = new DateTime(1940, 01, 01);

            //Uso método p/ calcular diferencia entre fechas, devuelve cantidad de días
            int resultado = CalculateDays(fechaNac, ahora);
            int resultadoPromedio = CalculateDays(promedio, ahora);

            //Y obviamente calculo cuanto le queda de vida si no lo atropella un caballo o algo
            teQueda = resultadoPromedio - resultado;

            Console.WriteLine("\nEstas vivo hace {0} días. \n", resultado);
            Console.Write("******************************\n");
            Console.WriteLine("" +
                "\nPromedio de vida esperado" +
                "\npara un humano: {0} días.\n" +
                "\n..so, te quedan unos {1}, días" +
                "\nmachu pichu.- " +
                "\n\nNada mal..ponele.. still :D "+
                "\n\n" +
                "\nHAPPY FUCKING WHATEVER!!!\n" +
                "", resultadoPromedio, teQueda);
            Console.Write("******************************");

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
