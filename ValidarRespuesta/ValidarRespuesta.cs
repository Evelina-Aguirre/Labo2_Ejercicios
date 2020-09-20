using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    public static class ValidarRespuesta
    {
        //*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*//
        /// <summary>
        /// Valida que el carácter ingresado sea "s" y lo pasa a Mayúscula.
        /// </summary>
        /// <param name="respuesta"></param>
        /// <returns></returns> True si el valor ingresado es "s", False si recibe un char diferente.
        public static bool ValidarS_N(char c)
        {
            
            c = char.ToUpper(c);

            if (c == 'S')
            {
                return true;
            }
            return false;
        }
        //*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*//


    }
}
