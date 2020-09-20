using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_16";

            /*CON CONSTRUCTORES
            Alumno alumno1 = new Alumno("Maximiliano","Martinez",1001);
            Alumno alumno2 = new Alumno("María","Marta",1002);
            Alumno alumno3 = new Alumno("Lucido","Lopez",1003);*/

            //SIN CONSTRUCTORES
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            alumno1.nombre = "Lastima";
            alumno1.apellido = "Alalona";
            alumno1.legajo = 1004;

            alumno2.nombre = "Felicia";
            alumno2.apellido = "Falacia";
            alumno2.legajo = 1005;

            alumno3.nombre = "Carlos";
            alumno3.apellido = "Carisma";
            alumno3.legajo = 1006;

            alumno1.Estudiar(7, 10);
            alumno1.CalcularFinal();

            alumno2.Estudiar(2, 1);
            alumno2.CalcularFinal();

            alumno3.Estudiar(7, 6);
            alumno3.CalcularFinal();

            Console.WriteLine("Legajo      Nombre    Apellido    Nota Final");
            Console.WriteLine("*********************************************");
            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());

            Console.ReadKey();

        }
    }
}
