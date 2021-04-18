using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        /*static void Main(string[] args)
        {
            mensajeEnPantalla();
        }

        static void mensajeEnPantalla()//Si acá arriba dice una referencia es que se está llamando en le main, 0 que no.
        {
            Console.WriteLine("Yo imprimo esto en consola si me llamas y si soy static, sino un cuerno");
        }*/

        /*static void Main(string[] args)
        {
            sumaNumeros(10, 20);
        }
        static void sumaNumeros(int num1, int num2)
        {
            Console.WriteLine("La suma de los numeros es "+( num1 + num2));
        }*/
        static void Main(string[] args)//PARA GENERAR RANDOM, JUEGO PARA ADIVINARLO
        {
            int intentos = 5;
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, 100);
            Console.WriteLine("BIENVENIDO, tenés 5 oportunidades para adivinar ún número del 1 al 100 \n\n");
            Console.WriteLine("\nNUM GENERADO POR EL SISTEMA :" + numeroAleatorio+"\n");
            int numIngresado;
            do {
                try//IMPORTÁNTÍSIMO : ESTOY VALIDANDO QUE LO QUE SE INGRESE SEA UN NUM ENTRE 0 Y 100
                {
                    Console.WriteLine("Ingrese un número: ");
                    numIngresado = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)//INCLUSIVE NO HACE FALTA ESCRIBIR ESTE PARÉNTESIS EL SIS ENTIENDE QUE VA A SE "EXCEPCION" si no se escribe naa//NAA ES RECOMENDABLE    
                {
                    Console.WriteLine("El valor ingresado debe ser un número entre 0 y 100");
                    numIngresado = 0;//CUALQUIER OTRA COSA TORA ERROR Y SETEA LA VARIABLE EN 0
                    //Bueno,casi, verifica que la variable ingresada mno sea ni letras ni muy larga...creeeo qye tampoco tenga coma
                    //OJO QUE AL USUARIO NO SE LE AVISA Q SU VARIBLE PASÓ A 0
                }
                 
                if (numIngresado == numeroAleatorio)
                {
                    Console.WriteLine("Aleluya hermano!!! YOU WIN");
                    break;
                }
                else if (numIngresado > numeroAleatorio)
                {
                    Console.WriteLine("Te pasaste...");
                }
                else
                {
                    Console.WriteLine("Faltó un poco");
                }
                intentos--;
            } while (intentos >= 0);
            
            Console.WriteLine("Y eso fue todo amigos");
            Console.ReadKey();//Ahora creo juego para intentar adivinar el número


        }
       /* static void Main(string[] args)
        {
            mensajeEnPantalla();
        }*/
    }



}

