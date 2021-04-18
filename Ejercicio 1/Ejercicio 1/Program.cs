using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el
valor máximo, el valor mínimo y el promedio.*/

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°1"; //lo hago simplesongo.. (And I love flags)

        
            int numero, i;
            int minimo; 
            int maximo; 
            int acumulador = 0;
            int contador = 0;
            float promedio;
            int flag = 0;
            
            //Pregunta la primera vez fuera del for para asignarle un valor a las variables mínimo / máximo.
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            minimo = numero;
            maximo = numero;

            //Toma los 4 valores restantes, las guarda en la variable "número" y las compara con las ingresadas posteriormente..
            for (i = 0; i < 4; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                acumulador += numero;
                contador++;

                //Si es la primera vez q itera o si "número" es mayor al cual se compara, máximo se sobreescribe.                
                if (flag == 0 || numero > maximo)
                {
                    maximo = numero;
                }
                //Si es la primera vez q itera o si "número" es menor al cual se compara, mínimo se sobreescribe.
                if (flag == 0 || numero < minimo)
                {
                    minimo = numero;
                }
                //cambia valor a 1 al finalizar la vuelta, para avisar en la prox. iteración q no es la 1ra vz q entra.
                flag = 1;
            }

            promedio = (float)(acumulador / contador);

            Console.WriteLine("Mínimo: {0}, Máximo: {1}, Promedio: {2}", minimo, maximo, promedio);
            Console.ReadLine(); 

        }

        //**Hola yo futuro, copate y ponele validaciones y hacete las diferentes versiones 
        //de código para esto porq antes no lo hiciste y yo llegué acá no acordándome un cuerno.. 
        //Hee comentá, comentá como si fuese el fin del mundo.
    }
}
