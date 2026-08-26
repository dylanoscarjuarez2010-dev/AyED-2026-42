using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___Sumando2Numeros
{
    class Program
    {
        static int Sumar (int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su primer número a ser sumado con el segundo: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            int total = Sumar(numero1, numero2);
            Console.WriteLine("El resultado de su suma es: " + total);

            Console.ReadKey();
        }
    }
}
