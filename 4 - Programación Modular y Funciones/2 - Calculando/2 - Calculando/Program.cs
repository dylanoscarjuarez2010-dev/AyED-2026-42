using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__Sumando2Numeros
{
    class Program
    {
        // 1. Declarás las 4 funciones dentro de la clase
        static int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        static int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        static int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        static double Dividir(double numero1, double numero2)
        {
            // Usamos double por si la división da con decimales
            return numero1 / numero2;
        }

        // 2. Un único Main donde ejecutas la lógica
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            // Llamás a cada función pasándole los mismos datos
            int totalSuma = Sumar(numero1, numero2);
            int totalResta = Restar(numero1, numero2);
            int totalMultiplicacion = Multiplicar(numero1, numero2);
            double totalDivision = Dividir(numero1, numero2);

            // Muestras todos los resultados juntos
            Console.WriteLine("El resultado de la suma es: " + totalSuma);
            Console.WriteLine("El resultado de la resta es: " + totalResta);
            Console.WriteLine("El resultado de la multiplicación es: " + totalMultiplicacion);
            Console.WriteLine("El resultado de la división es: " + totalDivision);

            Console.ReadKey();
        }
    }
}