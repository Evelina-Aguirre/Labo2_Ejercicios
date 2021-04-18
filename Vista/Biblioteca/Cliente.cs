using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Biblioteca
{
    public class Cliente //poner public adelante 
    {
        //ATRIBUTOS
        private string nombre;//si no se pone nada x defecto es privado // los atributos siempre privados
        private string apellido;//pero lo ponemos para q queda más claro

        //CONSTRICTORES
        public Cliente(string nombre, string apellido) // constructor se llama igual q la clase
        {
            this.nombre = nombre;//le pingo el this para aclarar q es un atributo del objeto
            this.apellido = apellido;
        }

        //setter
        public void CambiarNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void CambiarApellido(string apellido)
        {
            this.apellido = apellido;
        }
        //getter
        public string ObtenerNombreComp()
        {
            //return nombre + "" + apellido;
            return $"{this.nombre} {this.apellido}";//-->esto se llama template string q es una forma de poner variables dentro del txt
            //el this. hace referencia a algo q e de un objeto de esta clase.
            //estático, nombre de la clase.


        }
    }
}
