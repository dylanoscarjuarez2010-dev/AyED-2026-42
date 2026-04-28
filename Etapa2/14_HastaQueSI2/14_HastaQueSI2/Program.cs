using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_HastaQueSI2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Deseas terminar el programa?: ");
            string respuesta = Console.ReadLine();
            while (respuesta != "SI")
            {
                Console.Write("Respuesta incorrecta. Intente de nuevo: ");
                respuesta = Console.ReadLine();
            }
        }
    }
}
