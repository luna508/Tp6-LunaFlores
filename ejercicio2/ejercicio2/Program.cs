using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Realizar una función que valide si un número es impar o no. Si es impar la función debe devolver un
verdadero, si no es impar debe devolver falso. Nota: la función no debe tener mensajes que digan si es
par o no.*/

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Ingrese un numero ");
            n1 = int.Parse(Console.ReadLine());
            numero_impar(n1);

            Console.ReadKey();

        }
        public static void numero_impar(int n1)
        {
            if (n1 %2 == 1)
            {
                Console.WriteLine(true);
                
            }
            else
            {
                Console.WriteLine(false);
                


            }


        }
    }
}
