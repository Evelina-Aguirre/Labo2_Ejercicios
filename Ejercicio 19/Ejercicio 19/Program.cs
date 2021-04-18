using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_19";

            int a = 0;
            int b = 0;

            Sumador s1 = new Sumador(5);
            Sumador s2 = new Sumador();

            Console.WriteLine(s1.Sumar(10,15));
            Console.WriteLine(s2.Sumar("No estaría", "Entendiendo, me lo fumo el finde"));

            a = (int)s1;
            b = (int)s2;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine(s1+s2);
            Console.WriteLine(s1 | s2);

            Console.ReadKey();

        }
    }
}

/*19. Realizar una aplicación de consola. Agregar la clase Sumador.

a. Crear dos constructores:
i. Sumador(int) inicializa cantidadSumas en el valor recibido por parámetros.
ii. Sumador() inicializa cantidadSumas en 0. Reutilizará al primer constructor.
b. El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la
siguiente lógica:
i. En el caso de Sumar(long, long) sumará los valores numéricos
ii. En el de Sumar(string, string) concatenará las cadenas de texto.
Antes de continuar, agregar un objeto del tipo Sumador en el Main y probar el código.
c. Generar una conversión explícita que retorne cantidadSumas.
d. Sobrecargar el operador + (suma) para que puedan sumar cantidadSumas y retornen un long
con dicho valor.
e. Sobrecargar el operador | (pipe) para que retorne True si ambos sumadores tienen igual
cantidadSumas.
Agregar un segundo objeto del tipo Sumador en el Main y probar el código.*/

