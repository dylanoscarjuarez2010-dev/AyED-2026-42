using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0___HolaNombre
{
    class Program
    {
        static void Saludar(String nombre)
        {
            Console.WriteLine("Hola " + nombre);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Saludar(nombre);
             
            Console.ReadKey();
        }
    }
}
