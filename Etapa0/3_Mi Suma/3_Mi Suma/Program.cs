using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Mi_Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba un número: ");
            int número1 = int.Parse(Console.ReadLine());
            Console.Write("Escriba otro número para que sea sumado al anterior: ");
            int número2 = int.Parse(Console.ReadLine());
            Console.Write("El resultado de su suma es: ");
            Console.WriteLine(número1 + número2);
            Console.ReadKey();
        }
    }
}
