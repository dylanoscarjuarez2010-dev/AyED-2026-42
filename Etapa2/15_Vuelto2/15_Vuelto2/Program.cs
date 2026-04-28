using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Vuelto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int diezmil = 0;
            int dosmil = 0;
            int mil = 0;
            int quinientos = 0;
            int doscientos = 0;
            int cien = 0;
            int cincuenta = 0;
            int veinte = 0;
            int diez = 0;
            int uno = 0;
            Console.Write("Ingrese el monto de su compra: ");
            int compra = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la plata entregada: ");
            int plata = int.Parse(Console.ReadLine());
            while(compra <= 0 || compra > plata)
            {
                Console.Write("Dinero insuficiente. Intente denuevo: ");
                Console.Write("Ingrese el monto de su compra: ");
                compra = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la plata entregada: ");
                plata = int.Parse(Console.ReadLine());
            }
            int vuelto = plata - compra;
            Console.WriteLine("Su vuelto es: " + vuelto + " pesos");
            while (vuelto != 0)
            {
                if (vuelto >= 10000)
                {
                    diezmil = (int)vuelto / 10000;
                    vuelto -= diezmil * 10000;
                }
                else if (vuelto >= 2000)
                {
                    dosmil = (int)vuelto / 2000;
                    vuelto -= dosmil * 2000;
                }
                else if (vuelto >= 1000)
                {
                    mil = (int)vuelto / 1000;
                    vuelto -= mil * 1000;
                }
                else if (vuelto >= 500)
                {
                    quinientos = (int)vuelto / 500;
                    vuelto -= quinientos * 500;
                }
                else if (vuelto >= 200)
                {
                    doscientos = (int)vuelto / 200;
                    vuelto -= doscientos * 200;
                }
                else if (vuelto >= 100)
                {
                    cien = (int)vuelto / 100;
                    vuelto -= cien * 100;
                }
                else if (vuelto >= 50)
                {
                    cincuenta = (int)vuelto / 50;
                    vuelto -= cincuenta * 50;
                }
                else if (vuelto >= 20)
                {
                    veinte = (int)vuelto / 20;
                    vuelto -= veinte * 20;
                }
                else if (vuelto >= 10)
                {
                    diez = (int)vuelto / 10;
                    vuelto -= diez * 10;
                }
                else
                {
                    uno = (int)vuelto / 1;
                    vuelto -= uno;
                }
            }
            Console.WriteLine("Su vuelto en billetes es: ");
            Console.WriteLine(diezmil + " Billetes de diezmil.");
            Console.WriteLine(dosmil + " Billetes de dosmil.");
            Console.WriteLine(mil + " Billetes de mil.");
            Console.WriteLine(quinientos + " Billetes de quinientos.");
            Console.WriteLine(doscientos + " Billetes de doscientos.");
            Console.WriteLine(cien + " Billetes de cien.");
            Console.WriteLine(cincuenta + " Billetes de cincuenta.");
            Console.WriteLine(veinte + " Billetes de veinte.");
            Console.WriteLine(diez + " Billetes de diez.");
            Console.WriteLine(uno + " Billetes de uno.");
            Console.ReadKey();
        }

    }
}
