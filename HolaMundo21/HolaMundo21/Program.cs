using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo21
{
    class Program    //Pedir un string y contar cuantas letras a tiene//
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Ingrese texto");
            string texto = Console.ReadLine();
            Console.WriteLine("Ingrese letra");
            char letra = Console.ReadKey().KeyChar;

            int cantidad = contarLetras(texto, letra);
            Console.WriteLine("La cantidad ingresada es: {0}",cantidad);

        }

        //dentro de la clase fueras del metodos mmain
        static int contarLetras(string texto, char letra)
        {
            int aux=0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto.ToCharArray()[i] == letra) ;//tochararray convierte es texto a cadena de caracteres, los metodos van con ()
                { 
                 aux = aux + 1;
                }
            }   
            
            return aux;
        }

        static int contarLetras2(string texto, char letra)
        {
            int aux=0;
            int cont = 0;
            //int i = 0;
            /*do
            {
                
                if (texto.ToCharArray()[i] == letra) ;
                {
                    aux = aux + 1;
                }
            } while (i < texto.Length);*/


                //con while - do while
                /*while(i <texto.Length)
                {
                    if (texto.ToCharArray()[i] == letra);
                    {
                        aux = aux + 1;
                    }
                }*/


                //con foreach (solo para recorrer no se puede modificar nada)..
                foreach(char item in texto.ToCharArray()) //recorre de forma ascendente y va guardando en item la pocisión del array
                {
                    if (char.ToUpper(item) == Char.ToUpper(letra)) ; //con el for each no podemos modificar el array
                    {
                        aux = aux + 1;
                    }
                }

                //con for..
                /* for(int i = 0; i < texto.Length; i++)
                {
                    if (char.ToUpper(texto.ToCharArray()[i]) == Char.ToUpper(letra)) ;//to upper para q no importe si es myu o min
                    {
                        aux = aux + 1;
                    }
                }*/

                return aux;
        }
    }
}
