using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba el ancho de su rectangulo: ");
            double ancho = double.Parse(Console.ReadLine());
            Console.Write("Escriba el largo de su rectangulo: ");
            double largo = double.Parse(Console.ReadLine());
            double perimetro = 2 * (ancho + largo);
            double area = largo * ancho;
            double diagonal = Math.Sqrt(Math.Pow(2, largo + ancho));
            Console.WriteLine("El perimetro del rectangulo es: " + perimetro);
            Console.WriteLine("El area del rectangulo es: " + area);
            Console.WriteLine("La diagonal del rectangulo es: " + diagonal);
            Console.ReadKey();
        }
    }
}
