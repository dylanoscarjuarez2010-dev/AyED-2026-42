using System;

namespace _4_PixelDreams
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;

            Console.Write("Ingrese la cantidad de participantes: ");
            cantidad = int.Parse(Console.ReadLine());

            int[] puntajes = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese el puntaje del participante " + (i + 1) + ": ");
                puntajes[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = 0; j < cantidad - 1; j++)
                {
                    if (puntajes[j] < puntajes[j + 1])
                    {
                        int auxiliar = puntajes[j];
                        puntajes[j] = puntajes[j + 1];
                        puntajes[j + 1] = auxiliar;
                    }
                }
            }

            Console.WriteLine("\nPuntajes ordenados de mayor a menor:");

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(puntajes[i]);
            }

            Console.WriteLine("\nPrimer lugar: " + puntajes[0]);
            Console.WriteLine("Último lugar: " + puntajes[cantidad - 1]);

            Console.ReadKey();
        }
    }
}