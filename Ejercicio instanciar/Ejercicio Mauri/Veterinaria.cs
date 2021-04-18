using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Instanciar los siguientes objetos (hardcodeado, no pedir datos por consola):
Un cliente con un perro sin vacunar.
Un cliente con un gato con la vacuna "Triple Felina".
Un cliente con un gato sin vacunas y un perro con la vacuna contra la rabia.
5. Mostrar por consola todos los datos de los clientes instanciados y sus mascotas.*/

namespace veterinaria
{
    class Veterinaria
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Pablo", "Milan","Av. Pericles",52641545,);
            cliente.CambiarNombre("María");


            //string nombreCompleto = cliente.ObtenerNombreComp();
            //System.Console.WriteLine(nombreCompleto);

        }
    }
}
