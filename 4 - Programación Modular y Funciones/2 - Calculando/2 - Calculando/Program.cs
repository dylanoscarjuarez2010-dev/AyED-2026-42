using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Calculando
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            int opcion = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Resultado = " + Sumar(numero1, numero2));
                    break;

                case 2:
                    Console.WriteLine("Resultado = " + Restar(numero1, numero2));
                    break;

                case 3:
                    Console.WriteLine("Resultado = " + Multiplicar(numero2, numero2));
                    break;

                case 4:
                    Console.WriteLine("Resultado = " + Dividir(numero1, numero2));
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.ReadKey();

        }

        static void MostrarMenu()
        {
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");

        }

        static int Sumar(int a, int b)
        {
            return a + b;
        }

        static int Restar(int a, int b)
        {
            return a - b;
        }

        static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        static double Dividir(int a, int b)
        {
            return a / b;
        }

    }
}
