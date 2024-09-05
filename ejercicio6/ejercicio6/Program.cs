using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crear un programa que dibuje una escalera de números, donde cada línea de números comience en uno 
y termine en el número de la línea. Solicitar la altura de la escalera al usuario al comenzar. Ejemplo: si se 
ingresa el número 3:
 1
 12
 123*/

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            Console.WriteLine("PIRAMIDE DE NUMEROS");
            Console.WriteLine("Ingrese la altura de la piramide de numeros ");
            altura = int.Parse(Console.ReadLine());
            Escalera(altura);
            Console.ReadKey();
        }

        public static void Escalera(int altura)
        {
            for (int i  = 1; i <= altura; i ++)
            {
                for (int a = 1; a <= i ; a++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();  
            }
 
        }
    
   }

}
