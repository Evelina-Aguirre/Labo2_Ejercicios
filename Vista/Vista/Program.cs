using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;


namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Pablo", "Mmeme");
            //Ctrl + . para que te de la opción de "using biblioteca"  
            //Estoy creando una variable, todas las clases son por referencia. 
            //Parallel llamarlo con punto la clase tiene q tener la palabra static

            cliente.CambiarApellido("Pedraza");
            cliente.CambiarNombre("Lolo");
            string nombreCompleto = cliente.ObtenerNombreComp();
            System.Console.WriteLine(nombreCompleto);
        }
    }
}
