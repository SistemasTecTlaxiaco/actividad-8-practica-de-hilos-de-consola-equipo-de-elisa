using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Simulación de puertas del Metro CDMX...\n");

        // Crear hilos para dos puertas del metro 
        Thread puertaDelantera = new Thread(() => SimularPuerta("Delantera"));
        Thread puertaTrasera = new Thread(() => SimularPuerta("Trasera"));

        puertaDelantera.Start();//
        puertaTrasera.Start();
        puertaDelantera.Join();
        puertaTrasera.Join();

        Console.WriteLine("\nSimulación finalizada. Presiona cualquier tecla para salir.");
        Console.ReadKey();
    }

    static void SimularPuerta(string nombrePuerta)//
    {
        for (int i = 1; i <= 5; i++) // 5 ciclos de abrir/cerrar
        {
            Console.WriteLine($"[{nombrePuerta}] Ciclo {i}: Abriendo puerta...");
            Thread.Sleep(1000); // 1 segundo simulando apertura

            Console.WriteLine($"[{nombrePuerta}] Puerta abierta. Pasajeros entrando/saliendo...");
            Thread.Sleep(3000); // 3 segundos abierta

            Console.WriteLine($"[{nombrePuerta}] Cerrando puerta...");
            Thread.Sleep(1000); // 1 segundo cerrando

            Console.WriteLine($"[{nombrePuerta}] Puerta cerrada.\n");
            Thread.Sleep(1000); // Espera antes del siguiente ciclo
        }

        Console.WriteLine($"[{nombrePuerta}] Terminó el ciclo de simulación.\n");
    }
}
