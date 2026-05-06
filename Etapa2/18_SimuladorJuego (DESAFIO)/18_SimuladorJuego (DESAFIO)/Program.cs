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
            int vida = 10;
            int hambre = 10;
            int dia = 1;
            int comida_cruda = 0;
            int comida_cocinada = 0;
            bool refugio = false;
            bool fogata = false;
            int opciones = 0;
            while (opciones != 8)
            {
                Console.WriteLine("Tienes " + vida + " de vida");
                Console.WriteLine("Tienes " + hambre + " de hambre");
                Console.WriteLine("Estas en el dia " + dia);
                Console.WriteLine("Tienes " + comida_cruda + " de comida cruda");
                Console.WriteLine("Tienes " + comida_cocinada + " de comida cocinada");
                Console.WriteLine("Tu refugio es " + refugio);
                Console.WriteLine("Tu fogata es " + fogata);
                Console.WriteLine("");
                Console.WriteLine("1. Buscar comida");
                Console.WriteLine("2. Explorar la isla");
                Console.WriteLine("3. Construir refugio");
                Console.WriteLine("4. Encender fogata");
                Console.WriteLine("5. Cocinar comida");
                Console.WriteLine("6. Comer comida cocida");
                Console.WriteLine("7. Descansar");
                Console.WriteLine("8. Salir del programa");
                opciones = int.Parse(Console.ReadLine());
                Console.Clear();
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
                        }
                        vida--;
                        dia++;
                        if (hambre < 0)
                        {
                            vida -= 2;
                        }
                        else
                        {
                            hambre -= 2;
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
                        dia++;
                        hambre -= 2;
                        break;
                    case 3:
                        Console.WriteLine("Construir refugio");
                        if (refugio == false)
                        {
                            refugio = true;
                            Console.WriteLine("Construiste un refugio");
                        }
                        else
                        {
                            Console.WriteLine("Ya tienes un refugio");
                        }
                        dia++;
                        hambre -= 2;
                        break;
                    case 4:
                        Console.WriteLine("Encender fogata");
                        if (refugio == true)
                        {
                            if (fogata == false)
                            {
                                fogata = true;
                                Console.WriteLine("Encendiste una fogata.");
                            }
                            else
                            {
                                Console.WriteLine("Ya hay una fogata encendida.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Necesitas un refugio para construir una fogata.");
                        }
                        dia++;
                        hambre -= 2;
                        break;
                    case 5:
                        Console.WriteLine("Cocinar comida");
                        if (comida_cruda > 0 && fogata == true)
                        {
                            comida_cruda--;
                            comida_cocinada++;
                            Console.WriteLine("Cocinaste comida.");
                        }
                        else
                        {
                            Console.WriteLine("No podes cocinar. Te falta comida cruda o fogata");
                        }
                        dia++;
                        hambre -= 2;
                        break;
                    case 6:
                        Console.WriteLine("Comer comida cocida");
                        if (comida_cocinada > 0)
                        {
                            comida_cocinada--;
                            hambre += 4;
                            if (hambre > 10)
                            {
                                hambre = 10;
                            }
                            Console.WriteLine("Comiste comida cocinada.");
                        }
                        else
                        {
                            Console.WriteLine("No tenes comida cocinada.");
                        }
                        dia++;
                        hambre -= 2;
                        break;
                    case 7:
                        Console.WriteLine("Descansar");
                        if (refugio == true)
                        {
                            vida += 3;
                            Console.WriteLine("Descansaste bien.");
                        }
                        else
                        {
                            vida++;
                            Console.WriteLine("Descansaste incomodo.");
                        }
                        if (vida > 10)
                        {
                            vida = 10;
                        }
                        dia++;
                        hambre -= 2;
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
                if (vida > 10)
                {
                    vida = 10;
                }
                if (hambre > 10)
                {
                    hambre = 10;
                }
                if (vida < 0)
                {
                    vida = 0;
                }
                if (hambre < 0)
                {
                    hambre = 0;
                }
                if (hambre == 0)
                {
                    vida -= 2;
                }
                if (vida == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Moriste.");
                    opciones = 8;
                }
                if (dia == 10)
                {
                    Console.WriteLine("Ganaste.");
                    opciones = 8;
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Gracias por jugar.");
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();

        }
    }
}
