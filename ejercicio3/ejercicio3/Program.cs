using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Realizar un programa que pida al usuario una frase y una letra a buscar en esa frase. La función debe
devolver la cantidad de veces que encontró la letra. Nota: recordar el uso de la función Subcadena().*/

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            char letra;
            int Contador;
            Console.WriteLine("Ingrese una frase ");
            frase = Console.ReadLine();
            Console.WriteLine("Ingrese la letra a buscar ");
            letra = char.Parse(Console.ReadLine());
            Contador = ContadorLetras(frase, letra);
            


            Console.WriteLine("La Letra {0} aparece {1} veces en la frase",letra,Contador);
             

            Console.ReadKey();
        }

        public static int ContadorLetras(string frase, char letra)
        {
            int contador = 0;
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase.Substring(i,1 )[0] == letra)
                {
                    contador++;
                }   
            }
            return contador;
        }
    }
}
