using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ejercicio:
Un cliente nos contrató para que desarrollemos una aplicación donde pueda consultar su lista de clientes y sus mascotas. 
De los clientes le interesa conocer el domicilio, el nombre y apellido y un teléfono. A un cliente se le pueden 
asociar una o más mascotas. 
De las mascotas necesita conocer su especie, su nombre, su fecha de nacimiento y su historial de vacunación.  Los primeros tres datos son obligatorios para dar de alta una mascota, mientras que el último arrancará vacío y se podrá ir agregando vacunas. De las vacunas sólo interesa conocer el nombre. 
Crear una aplicación de consola.
Modelar y declarar las clases necesarias para resolver la necesidad del cliente. Hacerlo en un proyecto de biblioteca de clases.
Las clases deberán tener los métodos necesarios, incluyendo uno que devuelva toda la información del objeto en formato string.
Instanciar los siguientes objetos (hardcodeado, no pedir datos por consola):
Un cliente con un perro sin vacunar.
Un cliente con un gato con la vacuna "Triple Felina".
Un cliente con un gato sin vacunas y un perro con la vacuna contra la rabia.
5. Mostrar por consola todos los datos de los clientes instanciados y sus mascotas.*/

/* DECLARAR UN ARRAY :
 string[] args = new string[20];
 args[0] = "hola";
 args[1] = "array";*/

/*Instanciar fecha
 new DateTime(2012,05,25)
 Mascota perro1 = new Mascota("firulais", "perro", new DateTime(2012,05,25));
 DateTime fecha = new DateTime(2012, 05, 25));
 Mascota perro1 = new Mascota("firulais", "perro", fecha);*/

namespace Biblioteca
{
    public class Cliente
    {
        //CLIENTES - domicilio, el nombre y apellido y un teléfono.

        //ATRIBUTOS
        private string nombre;
        private string apellido;
        private string domicilio;
        private int telefono;
        private Mascota[] mascota;
        

        //CONSTRUCTOR
        public Cliente(string nombre, string apellido, string domicilio, int telefono, Mascota mascota)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.mascota = mascota[10];
        }

        //SETTER
        public void CambiarNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void CambiarApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public void CambiarDomicilio(string domicilio)
        {
            this.domicilio = domicilio;
        }
        public void CambiarTelefono(int telefono)
        {
            this.telefono = telefono;
        }


        //GETTERS
        public string ObtenerNombreComp()
        {
            
            return $"{this.nombre} {this.apellido}";
        }
        public string ObtenerDomicilio()
        {
            
            return $"{this.domicilio}";
        }

        public string ObtenerTelefono()
        {
            
            return $"{this.telefono}";
        }
    }
}
