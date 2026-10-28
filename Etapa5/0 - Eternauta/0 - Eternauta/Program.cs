using System;

namespace RefugiosEternauta
{
    // 1. Crear la clase Refugio
    class Refugio
    {
        // Atributos
        public int Codigo { get; set; }
        public int CapacidadMaxima { get; set; }
        public int PersonasAlojadas { get; set; }

        // Constructor para inicializar el refugio
        public Refugio(int codigo, int capacidadMaxima, int personasAlojadas)
        {
            Codigo = codigo;
            CapacidadMaxima = capacidadMaxima;
            PersonasAlojadas = personasAlojadas;
        }

        // Método: Calcular cuántas personas más pueden ingresar
        public int CalcularDisponibles()
        {
            return CapacidadMaxima - PersonasAlojadas;
        }

        // Método: Mostrar todos los datos del refugio, incluyendo los lugares disponibles
        public void MostrarInformacion()
        {
            Console.WriteLine($"Refugio {Codigo}");
            Console.WriteLine($"Capacidad: {CapacidadMaxima}");
            Console.WriteLine($"Alojados: {PersonasAlojadas}");
            Console.WriteLine($"Disponibles: {CalcularDisponibles()}");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 2. Crear tres objetos individualmente (sin vectores ni listas)
            Refugio refugio101 = new Refugio(101, 20, 12);
            Refugio refugio102 = new Refugio(102, 15, 10);
            Refugio refugio103 = new Refugio(103, 30, 25);

            Console.WriteLine("=== SISTEMA DE REFUGIOS ===");
            Console.WriteLine();

            // 3.1. Mostrar la información de los tres refugios usando sus métodos
            refugio101.MostrarInformacion();
            refugio102.MostrarInformacion();
            refugio103.MostrarInformacion();

            // 3.2. Calcular cuántas personas hay alojadas en total
            int totalAlojados = refugio101.PersonasAlojadas + refugio102.PersonasAlojadas + refugio103.PersonasAlojadas;

            // 3.3. Calcular cuántos lugares disponibles quedan entre los tres refugios (usando el método)
            int totalDisponibles = refugio101.CalcularDisponibles() + refugio102.CalcularDisponibles() + refugio103.CalcularDisponibles();

            // 3.4. Indicar cuál de los tres refugios tiene mayor capacidad máxima
            int mayorCapacidad = refugio101.CapacidadMaxima;
            int codigoMayor = refugio101.Codigo;

            if (refugio102.CapacidadMaxima > mayorCapacidad)
            {
                mayorCapacidad = refugio102.CapacidadMaxima;
                codigoMayor = refugio102.Codigo;
            }

            if (refugio103.CapacidadMaxima > mayorCapacidad)
            {
                mayorCapacidad = refugio103.CapacidadMaxima;
                codigoMayor = refugio103.Codigo;
            }

            // 5. Salida esperada
            Console.WriteLine("=== RESUMEN ===");
            Console.WriteLine();
            Console.WriteLine($"Personas alojadas: {totalAlojados}");
            Console.WriteLine($"Lugares disponibles: {totalDisponibles}");
            Console.WriteLine($"Refugio de mayor capacidad: {codigoMayor}");

            // Pausa para que la consola no se cierre inmediatamente en Visual Studio
            Console.WriteLine();
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}