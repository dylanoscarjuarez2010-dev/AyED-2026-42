using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MonedasDelNivel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántas monedas doradas conseguiste? ");
            int dorada = int.Parse(Console.ReadLine());
            Console.Write("¿Cuántas monedas plateadas conseguiste? ");
            int plateada = int.Parse(Console.ReadLine());
            dorada = dorada * 10;
            plateada = plateada * 2;
            int puntaje = dorada + plateada;
            Console.WriteLine("Tu puntaje final es " + puntaje + " puntos.");
            if (puntaje < 50)
            {
                Console.WriteLine("Nivel insuficiente.");
            }
            if (puntaje > 99)
            {
                Console.WriteLine("¡Nivel completado con bonus!");
            }
            if (puntaje > 49 && puntaje < 100)
            {
                Console.WriteLine("¡Nivel completado!");
            }
            Console.ReadKey();
        }
    }
}
