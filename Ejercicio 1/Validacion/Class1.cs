using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Validacion
{
    public static class Class1
    {
        public static bool Validar(int valor, int min, int max)
        {
            if ((valor >= min) && (valor <= max))
            {
                return true;
            }
                return false;
        }

        public static bool ValidarS_N(char c)
        {

            c = char.ToUpper(c);

            if (c == 'S')
            {
                return true;
            }
            return false;
        }
    }

    
}
