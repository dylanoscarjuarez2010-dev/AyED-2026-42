
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Ingrese la cantidad de horas trabajadas");

            int horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor por hora");

            int valor = int.Parse(Console.ReadLine());

            int calculo = horas * valor; 


            Console.WriteLine(horas + " equivale a " + calculo  + " pesos a  pagar " );

            Console.ReadKey();
        }
    }
}




