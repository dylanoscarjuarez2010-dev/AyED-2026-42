using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MiResto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe un número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Escribe su segundo número para ser divdido con el anterior: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.Write("El resto de su division es: ");
            Console.WriteLine(numero1 % numero2);
            Console.ReadKey();
        }
    }
}
