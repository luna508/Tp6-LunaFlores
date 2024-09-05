using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crear una función llamada “Login”, que recibe un nombre de usuario y una contraseña y que devuelve 
Verdadero si el nombre de usuario es “usuario1” y si la contraseña es “epet5”. Además, la función 
calculara el número de intentos que se ha usado para loguearse, tenemos solo 3 intentos, si nos 
quedamos sin intentos la función devolverá Falso.*/

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            string clave;

            Console.WriteLine("INGRESE EL USUARIO ");
            usuario = Console.ReadLine();
            Console.WriteLine("INGRESE LA CONTRASEÑA ");
            clave= Console.ReadLine();
            Login(usuario,clave);
            Console.ReadKey();
        }
        private static int intentos = 3;

        public static bool Login(string usuario, string clave)
        {
            if (intentos<=0)
            {
                Console.WriteLine("No hay intentos. ");
                return false;
                
            }
            if (usuario == "usuario1" && clave== "epet5")
            {
                Console.WriteLine("Correcto ");
                return true;
            }
            else
            {
                intentos--;
                Console.WriteLine("Fallido, intentos: {0} ",intentos);
                return false;
            }

        }



    }
}
