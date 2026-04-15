using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Vuelto
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
            Console.Write("¿Cuánto sale su compra?: ");
            int compra = int.Parse(Console.ReadLine());
            Console.Write("¿Cuánto dinero pagaste?: ");
            int pago = int.Parse(Console.ReadLine());
            while (compra <= 0 || pago < compra)
            {
                Console.WriteLine("Monto o dinero inválidos. Intento de nuevo.");
                Console.Write("¿Cuánto sale su compra?: ");
                compra = int.Parse(Console.ReadLine());
                Console.Write("¿Cuánto dinero pagaste?: ");
                pago = int.Parse(Console.ReadLine());
            }
            int vuelto = pago - compra;
            Console.WriteLine("Tu vuelto es de " + vuelto + " pesos.");
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
            Console.WriteLine("En billetes eso seria:");
            Console.WriteLine(diezmil + " billetes de 10000");
            Console.WriteLine(dosmil + " billetes de 2000");
            Console.WriteLine(mil + " billetes de 1000");
            Console.WriteLine(quinientos + " billetes de 500");
            Console.WriteLine(doscientos + " billetes de 200");
            Console.WriteLine(cien + " billetes de 100");
            Console.WriteLine(cincuenta + " billetes de 50");
            Console.WriteLine(veinte + " billetes de 20");
            Console.WriteLine(diez + " billetes de 10");
            Console.WriteLine(uno + " billetes de 1");
            Console.ReadKey();
            
        }
    }
}
