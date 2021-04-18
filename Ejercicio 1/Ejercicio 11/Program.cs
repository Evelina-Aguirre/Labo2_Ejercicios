using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validacion;

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
            string value;
            int num;
            int min = int.MaxValue;
            int max = int.MaxValue;
            int acum=0;
            int contador = 0;

           
            
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Ingrese un números:  ");
                    value = Console.ReadLine();
                    if (int.TryParse(value, out num))
                    {
                        if (true != Class1.Validar(num, -100, 100))
                        {
                            Console.WriteLine("{0} --> Está fuera de rango, no se contabilizará", num);
                        }
                        else
                        {
                            acum += acum;
                            contador++;

                            if (num > max)
                            {
                                max = num;
                            }

                            if (num < min)
                            {
                                min = num;
                            }
                        }
                    }
                }
            float promedio = acum / contador;

            Console.WriteLine(" Min: {0}\n" +
                              "max: {1}\n" +
                              "Promedio:{2}\n", min,max,promedio);

            Console.ReadKey();
            //****REVISAR MAX QUEDA CON UN NÚMERO DE 5 CÍFRAS Y PROMEDIO DA 0.****
            
        }
    }    
 }
