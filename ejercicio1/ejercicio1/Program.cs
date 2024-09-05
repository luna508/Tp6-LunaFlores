using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crear una función que calcule la suma de dos números. En el programa principal, solicitaremos al
usuario que ingrese los dos números para luego pasarlos como argumentos a la función. La función
realizará el cálculo de la suma y devolverá el resultado, que será mostrado para su visualización.*/


namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;

            Console.WriteLine("Ingrese dos numeros ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            suma(n1, n2);
            Console.ReadKey();
        }
         
        public static void suma(int n1, int n2)
        {
            int suma = 0;
            suma = (n1 + n2);
            Console.WriteLine("La suma de {0} y {1} es: {2} ", n1, n2 , suma);
        }

        
    }
}
