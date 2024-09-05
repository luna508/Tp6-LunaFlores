using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Diseñar un procedimiento que reciba una frase, y el programa remueva todas las vocales . Al final el 
procedimiento mostrará la frase final.
 Por ejemplo:
 Entrada: “Habia una vez un barco”
 Salida: “Hb n vz n brc"*/

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            Console.WriteLine("Ingrese una frase ");
            frase = Console.ReadLine();
            DarVuelta(frase);
            Console.ReadKey();
        }


        public static void DarVuelta(string frase)
        {
            string Vocales = "aeiouAEIUO";
            string SinVocales = "";
            foreach (char c in frase)
            {
                if (!Vocales.Contains(c))
                {
                    SinVocales += c;
                }
            }
            Console.WriteLine(SinVocales);
        }
    }
}
