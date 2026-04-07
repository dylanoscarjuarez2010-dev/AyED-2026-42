using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CelsiusFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            double grados = double.Parse(Console.ReadLine());
            double farenheit = grados * 9 / 5 + 32;
            double kelvin = grados + 237.15;
            Console.WriteLine("Los grados en farenheit son: " + farenheit);
            Console.WriteLine("Los grados en kelvin son: " + kelvin);
            Console.ReadKey();
        }
    }
}
