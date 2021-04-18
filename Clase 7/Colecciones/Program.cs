using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/
            //LISTAS
            /* string[] nombre = new string[3];
             nombre[0]="Yo";
             nombre[1]="Tú";
             nombre[2]="Él";*/

            /* List<string> listaNombres = new List<string>();//podría hacer una lista de personas, si declaro primero la clase persona
             listaNombres.Add("Fede");
             listaNombres.Add("lola");
             listaNombres.Add("Pedro");


             foreach (string nombre in listaNombres)
             {//en una colección va elemento por elemento almacenando en la variable en este caso "nombre" para hacer con ese elemento lo que le pidas
                 Console.WriteLine(nombre);
             }

             listaNombres.Remove("lola");//compara el contenido de los dos strings

             for (int i = 0; i < listaNombres.Count; i++)//listaNombres.count se fija hasta que indice va la lista
             {
                 Console.WriteLine(listaNombres[i]);

             }

             listaNombres.RemoveAt(0);//remueve por índice, no existe add at, pero se puede acceder de esta manera:
             //remove all borra todo
             //sort para ordenarla(tiene un criterio por defecto pero le vamos a pasar otro) 
             Console.WriteLine(listaNombres[0]);

             Console.ReadKey();*/

            //*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*
            //DICCIONARIOS
            /*Dictionary<int, string> agenda = new Dictionary<int, string>();
            agenda.Add(12345678,"Juan Perez");
            agenda.Add(87654321, "Marcos");
            agenda.Add(123456789, "Griselda");//La clave no puede ser igual
            agenda.Add(1234567897, "Griselda");//El nombre si se puede repetir

            foreach (KeyValuePair<int,string> contacto in agenda )//contacto variable que cabo de crear para imprimir uno por uno de la clase agenda
            {
                Console.WriteLine($"La clave es {contacto.Key} y el valor es {contacto.Value}");
            }
            //La agenda no busca por pocisión, busca por KEY, NO SE PODRÍA HACER Console.writeLine(agenda[0])
            //Pero si se puede Console.writeLine(agenda[12345678]);

            if (agenda.ContainsKey(123456789))//para saber si existe una clave
            {
                Console.WriteLine(agenda[12345678]);
            }

            Console.ReadKey();
            */

            // */*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*
            //QUEUE
            //Son colecciones genéricas, vá por orden de llegada
            /*Queue<string> colaDeAtencion = new Queue<string>();

            colaDeAtencion.Enqueue("Maximiliano");
            colaDeAtencion.Enqueue("Pedro");
            colaDeAtencion.Enqueue("Luliberta");

            Console.WriteLine(colaDeAtencion.Dequeue());//DEQUEUE TOMA EL ELEMENTO, TE LO DEVUELVE Y LO ELIMINA
            //me mostró a Maxi y lo borró, ahora tengo 2 elementos
            Console.WriteLine(colaDeAtencion.Dequeue());//Hago 3 para que entren y salgan los 3
            //me mostró a Pedro, lo borró, ahora tengo 1 elementos
            Console.WriteLine(colaDeAtencion.Dequeue());
            //me mostró a Luliberta, lo borró, ahora tengo 0 elementos

            foreach (string cliente in colaDeAtencion)
            {
                Console.WriteLine(cliente);//muestra los clientes sin eliminarlos
            }

            //OTRA MANERA DE MOSTRAR SIN ELIMINAR 
            Console.WriteLine(colaDeAtencion.Peek());//Muestra a Maxi sin eliminarlo
            Console.WriteLine(colaDeAtencion.Peek());//Muestra a Pedro sin eliminarlo
            Console.WriteLine(colaDeAtencion.Peek());//Muestra a Luliberta sin eliminarla

            //colaDeAtencion. clear para limpiar toda la colección
            //colaDeAtencion. count para contar cuantas personas tiene la queue

            /*foreach (string cliente in colaDeAtencion)
            {
                Console.WriteLine(colaDeAtencion.Dequeue());
            }*///el foreach para eliminar elementos no se puede hacer porque no permite modificar el tamaño de la colección

            //PERO SI SE PUEDE HACER ... tener en cuenta que si bien usamos un i , las queues no están indexadas
            /* for (int i = 0; i < colaDeAtencion.count; i++)
             {
                 Console.WriteLine(colaDeAtencion.Dequeue());
             }*/
            //*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*
            //STACK -->Ultimo en entrar, Primero en salir ---- lo mismo que las queues pero al revés(FUERTEMENTE TIPADO TMB)

            //Se declara:
            /*Stack<char> letras = new Stack<char>();
            letras.Push('B');
            letras.Push('M');
            letras.Push('E');

            foreach (char letra in letras)
            {
                Console.WriteLine(letra);
            }

            Console.WriteLine(letras.Pop());//Lee del último al primero E Y LO ELIMINA
            Console.WriteLine(letras.Pop());//Lee del último al primero M Y LO ELIMINA
            Console.WriteLine(letras.Pop());//Lee del último al primero B Y LO ELIMINA*/
            //*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*
            //LISTA ORDENADA:(CREO QUE SORTED LIST)
            //No se ordena por un criterio por defecto, le podemos decir en que orden lo preferimos
            //Están indexados por claves igual que los diccionarios
            //TODAS LAS COLECCIONES NO GENERICAS --> ARRAYLIST (igual que la lista pero no tiene un tipo específico)
            //*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*
            //ARRAYLIST

            /*ArrayList lista = new ArrayList ();
            lista.Add("Griselda");
            lista.Add(1234);
            //lista.Add(new Persona());

            foreach (object item in lista)
            {
                Console.WriteLine(item.GetType().Name);//Con esto por lo que entiendo adivina de que tipo es para imprimirlo
            }*/
            //*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*
            //HASHTABLE 
            //parecido a un diccionario pero indexado con un código hash
            //en qué se diferencia una colección de una matriz?? Ni idea, hay que ver denuevo el PP
            //Va a pedir tmb diferencia entre colecciones GENÉRICAS Y NO GENÉRICAS, again al PP nos remitimos 

            //*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*

            //CREAMOS UNA LISTA DE PERSONAS ..... quee voy a printear porque no tengo creada la clase 

            //List<Personas-*----->, ver paint
            //SORT
            //ABAJO HICE EL METODO PARA EL CRITERIO 
            //y SE USARÍA 
            //persona.Sort(OrdenarPersonas);<-----------

            //Lo que estoy haciendo acá no es en s´+i ordenar síonó darle un criterio

            //METODO:

            /*private static int OrdenarPersonas( Persona elemento, Persona elementoSiguiente)
            {   
                int criterio = 0;//Significa que los elementos quye estoy comparando son iguales //

                if(elementoActual.Dni < elementoSiguiente.Dni)
                {
                    criterio = -1;
                }
                else if (elementoActual.Dni > elementoSiguiente.Dni)
                {
                    criterio= 1;
                 }
                return criterio;
            }
            */
            //*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*

            //SortedList<int,string> personasOrdenadas



            Console.ReadKey();


        }

        //Lo que estoy haciendo acá no es en s´+i ordenar síonó darle un criterio
        /*private static int OrdenarPersonas( Persona elemento, Persona elementoSiguiente)
        {   
            int criterio = 0;//Significa que los elementos quye estoy comparando son iguales //
             
            if(elementoActual.Dni < elementoSiguiente.Dni)
            {
                criterio = -1;
            }
            else if (elementoActual.Dni > elementoSiguiente.Dni)
            {
                criterio= 1;
             }
            return criterio;
        }
        */
    }
}
