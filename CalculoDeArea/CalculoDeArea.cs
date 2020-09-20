using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeArea
{
    public class CalculoDeArea
    {
        /// <summary>
        /// Calcula área cuadrado a partir del diámetro de uno de sus lados.
        /// </summary>
        /// <param name="lado"></param>
        /// <returns></returns> Devuelve área.
        public static double CalcularCuadrado(double lado)
        {
            double area = Math.Pow(lado, 2);
            return area;

        }
        /// <summary>
        /// Calcula área de un Triángulo a partír de su base y altura.
        /// </summary>
        /// <param name="piso"></param> Refiere a la base del triángulo, por ser "base" una palabra reservada.
        /// <param name="altura"></param>
        /// <returns></returns> Devuelve área.
        public static double CalcularTriangulo(double piso, double altura)
        {
            double area = (piso * altura) / 2;
            return area;

        }
        /// <summary>
        /// Calcula área de un triángulo a partir de su radio.
        /// </summary>
        /// <param name="radio"></param>
        /// <returns></returns> Devuelve área.
        public static double CalcularCirculo(double radio)
        {
            double area = (Math.Pow(radio, 2)) * Math.PI;
            return area;

        }
    }
}
