using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public void CalcularFinal()
        {
            if(nota1>=4 && nota2>=4)
            {
                Random final = new Random();//Noo tiene mucho sentido pero el ejercicio pide que bajo estas condiciones se le asigne una notaFinal random.
                this.notaFinal = final.Next(1, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
            string cadena = this.legajo.ToString() + "      " + this.nombre + "       " + this.apellido + "      ";

            if (notaFinal != -1)
            {
                cadena += this.notaFinal.ToString();
            }
            else cadena += "Desaprobad@";
            return cadena;
        }


    }
}
