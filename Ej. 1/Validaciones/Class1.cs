using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validaciones
{
    public class Class1
    {
        public class Validacion
        {
            //*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*//
            /// <summary>
            /// Verifica que un valor entero esté dentro del rango que determinemos.
            /// </summary>
            /// <param name="valor"></param> Dato a validar
            /// <param name="min"></param> valor mínimo
            /// <param name="max"></param> valor máximo
            /// <returns></returns> (True)si está dentro de rango//(False)si no lo está.
            public static bool Validar(int valor, int min, int max)
            {
                if ((valor >= min) && (valor <= max))
                {
                    return true;
                }
                return false;

            }
            //*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*//
            /// <summary> 
            /// PRUEBA MAS DE UN MÉTODO EN UNA CLASE
            /// Valida que el carácter ingresado sea "s" y lo pasa a Mayúscula.
            /// </summary>
            /// <param name="respuesta"></param> Carácter ingresado.
            /// <returns></returns> (True) si el valor ingresado es "s", (False) si recibe un char diferente.
            public static bool ValidarS_N(char respuesta)
            {
                respuesta = char.ToUpper(respuesta);//MAYUS.

                if (respuesta != 'S')
                {
                    return false;

                }
                return true;
            }
            //*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*//



        }
    }
}
