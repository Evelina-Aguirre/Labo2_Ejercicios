using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;

/*11. Realizar una clase llamada Validacion que posea un método estático llamado Validar, que posea la
siguiente firma: bool Validar(int valor, int min, int max):
a. valor: dato a validar
b. min y max: rango en el cual deberá estar la variable valor.
Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
anteriormente que esten dentro del rango -100 y 100.
Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
Nota: Utilizar variables escalares, NO utilizar vectores.*/

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_11";

            int i = 1;
            int numero;
            int max = int.MinValue;
            int min = int.MaxValue;
            float promedio = 0;
            int acum = 0;

            do
            {
                Console.WriteLine("Ingrese {0}° valor (-100/100): ", i);
                string input = Console.ReadLine();
                if ((int.TryParse(input, out numero) == true) && (Class1.Validacion.Validar(numero, -100, 100) == true))
                {//Si el valor no es entero o si llegase estar fuera del rango solicitado.
                    if (numero > max)
                    {
                        max = numero;
                    }
                    if (numero < min)
                    {
                        min = numero;
                    }
                    acum += numero;
                    i++;//Incrementa el número de iteración hasta llegar a 10.
                }
                else
                {
                    Console.WriteLine("El numero ingresado no es válido ");
                    i--;//En caso de que el número tenga decimales o esté fuera de rango, resta  vuelta y lo solicita nuevamente.
                }

                //Validar(int numero, int -100, int 100)


            } while (i < 11);

            promedio = (float)acum / 10;
            Console.WriteLine("El valor Máximo ingresado: {0}", max);
            Console.WriteLine("El valor mínimo ingresado: {0}", min);
            Console.WriteLine("Promedio: {0}", promedio);
            Console.WriteLine("**Cool, a seguir con la vida**");
            Console.ReadKey();
        }
    }
}
