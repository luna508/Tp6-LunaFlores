using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crea un procedimiento “convertirEspaciado”, que reciba como argumento un texto y muestra una cadena con un espacio adicional tras cada letra.
 * Por ejemplo, “Hola, epet5” devolverá “H o l a , e p e t 5 “. Crea un programa principal donde se use dicho procedimiento.*/

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;

            Console.WriteLine("Ingrese un texto ");
            texto = Console.ReadLine();
            ConvertirEspaciado(texto);
            Console.ReadKey();
        }

        static void ConvertirEspaciado(string texto)
        {
            string resultado = "";
            foreach (char c in texto)
            {
                resultado += c + " ";               
            }
            Console.WriteLine(resultado);
        }
    }
}
