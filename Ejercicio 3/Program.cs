using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, num;
            int contador;
            
            Console.Write("Ingrese un número : ");
            String a = Console.ReadLine();
            int.TryParse(a, out num);
 
            for(i=1; i<=num;i++)
            {
                contador=0;
                for (int j = 1; j <= i; j++)
			    {  
                     if (i % j == 0)
                    {
                        contador++;
                        if(contador ==3)//Si el contador encuentra más de 2 restos 0, el núm deja de ser mi Primo. Ahora es un tio o algo así.
                        {
                            break;
                        }
                    }
                }   
                if (contador<=2)
                 {
                        Console.WriteLine(" {0} Es primo", i);                        
                 }
                
			}
                Console.ReadKey();    
 
       }
    }
}
