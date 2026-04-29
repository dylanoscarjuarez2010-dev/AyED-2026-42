using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_SimuladorJuego__DESAFIO_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. Buscar comida");
            Console.WriteLine("2. Explorar la isla");
            Console.WriteLine("3. Construir refugio");
            Console.WriteLine("4. Encender fogata");
            Console.WriteLine("5. Cocinar comida");
            Console.WriteLine("6. Comer comida cocida");
            Console.WriteLine("7. Descansar");
            Console.WriteLine("8. Salir del programa");
            int opciones = int.Parse(Console.ReadLine());
            int vida = 10;
            int hambre = 10;
            int dia_inicial = 1;
            int comida_cruda = 0;
            int comida_cocinada = 0;
            bool refugio = false;
            bool fogata = false;
            while (opciones != 8)
            {
                switch (opciones)
                {
                    case 1:
                        Console.WriteLine("Buscar comida");
                        Random comida = new Random();
                        int buscar_comida = comida.Next(0, 100);
                        if (comida_cruda < 61)
                        {
                            Console.WriteLine("Has encontrado 2 unidades de comida");
                            comida_cruda += 2;
                        }
                        else
                        {
                            Console.WriteLine("Nos has encontrado nada de comida");
                            vida -= 1;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Explorar la isla");
                        Random busca_recursos = new Random();
                        int algo_util = busca_recursos.Next(0, 100);
                        if (algo_util < 51)
                        {
                            Console.WriteLine("Has encontrado algo útil");
                        }
                        else if (algo_util < 81)
                        {
                            Console.WriteLine("No has encontrado nada");
                        }
                        else
                        {
                            Console.WriteLine("Has sufrido un accidente");
                            vida -= 2;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Construir refugio");
                        break;
                    case 4:
                        Console.WriteLine("Encender fogata");
                        break;
                    case 5:
                        Console.WriteLine("Cocinar comida");
                        break;
                    case 6:
                        Console.WriteLine("Comer comida cocida");
                        break;
                    case 7:
                        Console.WriteLine("Descansar");
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
                opciones = int.Parse(Console.ReadLine());
            }
        }
    }
}
