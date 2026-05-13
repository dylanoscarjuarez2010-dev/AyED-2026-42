using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de invitados: ");
            int invitado = int.Parse(Console.ReadLine());
            int[] invitados = new int[invitado];
            for ( int i = 0; i < invitados.Length; i++)
            {
                Console.WriteLine("¿Cuánta comida comes?: " + (i + 1));
                invitados[i] = int.Parse(Console.ReadLine());
            }
            int suma = 0;
            for (int i = 0; i < invitados.Length; i++)
            {
                suma += invitados[i];
            }
            double promedio = (double)suma / invitados.Length;
            Console.WriteLine("El promedio de comida por invitado es: " + promedio);
            Console.ReadKey();
        }
    }
}