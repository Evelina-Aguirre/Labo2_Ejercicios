using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int cuadrado;
            int cubo;
            Console.WriteLine("Ingrese un número =");
            string a = Console.ReadLine();
            int.TryParse(a, out num);
            cuadrado = num * num;
            cubo = num * num * num;

            Console.WriteLine("Numero ingresado: {0}", num);
            Console.WriteLine("Cuadrado: {0}", cuadrado);
            Console.WriteLine("Cubo: {0}", cubo);

            Console.ReadKey();

        }
    }
}
/*Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea

0mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.*/