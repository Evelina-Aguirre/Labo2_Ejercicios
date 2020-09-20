using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {/// <summary>
    /// Recibe dos operandos y un operador, realiza el cálculo pedido y retorna el resultado.
    /// </summary>
    /// <param name="operadorUno"></param> Número 1 
    /// <param name="operadorDos"></param> Número 2
    /// <param name="operador"></param> +,-,*,/.
    /// <returns></returns> Resultado de la operación o mensaje de error en caso de que el operando no sea correcto
    /// o se intente dividir por 0.
        public static double calcular(double operadorUno,double operadorDos, string operador)
        {
            double resultado=0;
            switch (operador)
            {
                case "+":
                    resultado = operadorUno + operadorDos;
                    break;

                case "-":
                    resultado = operadorUno - operadorDos;
                    break;

                case "*":
                    resultado = operadorUno * operadorDos;
                    break;

                case "/":
                    if (validar(operadorDos) == false)
                    {
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("No es posible dividir por 0. ");
                        Console.WriteLine("Por favor reingrese los datos.\n");
                        Console.WriteLine("--------------------------------------------------");
                    }
                    else                       
                    resultado = operadorUno / operadorDos;
                    break;
                default:
                  
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("ERROR.El operador ingresado es inválido.");
                        Console.WriteLine("Se retorna 0, por favor reingrese los datos.\n");
                        Console.WriteLine("--------------------------------------------------");
                    
                    break;
            }
            return resultado;
        }
        /// <summary>
        /// Valida que un número se diferente de 0.
        /// </summary>
        /// <param name="numero2"></param>
        /// <returns></returns> (False) si es igual a 0, (True) si es diferente de 0.
        private static bool validar(double numero2)
        {
            if(numero2==0)
            {
                return false;
            }
            return true;
        }
    }
}
