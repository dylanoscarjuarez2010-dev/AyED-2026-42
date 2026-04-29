using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_MiPrimerMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al menú: ");
            Console.WriteLine("1. bienvenidos al himalaya");
            Console.WriteLine("2. Aguante boca");
            Console.WriteLine("3. 8 * 8");
            Console.WriteLine("4. Salir del programa");
            int opcion = int.Parse(Console.ReadLine());
            while (opcion != 4)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("bienvenidos al himalaya");
                        break;
                    case 2:
                        Console.WriteLine("Aguante boca");
                        break;
                    case 3:
                        Console.WriteLine("La multiplicación de 8 * 8 = 64");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                opcion = int.Parse(Console.ReadLine());
            }
        }
    }
}
