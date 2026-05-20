using System;

namespace _0_cagandoedades
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio = 0;
            double PrecioMayor = 0;
            double PrecioMenor = 0;

            Console.WriteLine("Ingrese la cantidad de productos vendidos: ");
            int CantidadProductos = int.Parse(Console.ReadLine());

            for (int i = 0; i < CantidadProductos; i++)
            {
                Console.WriteLine("Ingrese el precio del producto: " + (i + 1));
                precio = double.Parse(Console.ReadLine());

                if (i == 0)
                {
                    PrecioMayor = precio;
                    PrecioMenor = precio;
                }
                else
                {
                    if (precio > PrecioMayor)
                    {
                        PrecioMayor = precio;
                    }

                    if (precio < PrecioMenor)
                    {
                        PrecioMenor = precio;
                    }
                }
            }

            Console.WriteLine("El precio mayor es: " + PrecioMayor);
            Console.WriteLine("El precio menor es: " + PrecioMenor);

            Console.ReadKey();
        }
    }
}