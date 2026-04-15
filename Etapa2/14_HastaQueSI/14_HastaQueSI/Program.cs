using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_HastaQueSI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe 'SI' para salir del programa: ");
            string palabra = Console.ReadLine();
            while(palabra != "SI")
            {
                Console.Write("incorrecto. Intente de nuevo: ");
                palabra = Console.ReadLine();
            }
        }
    }
}
