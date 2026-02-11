using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int cantidad = 0;

        // Pedir cuántas personas
        while (true)
        {
            Console.Write("¿Cuántas personas va a registrar?: ");
            string entrada = Console.ReadLine();

            try
            {
                cantidad = int.Parse(entrada);

                if (cantidad > 0)
                    break;
                else
                    Console.WriteLine("Debe ser mayor a 0.\n");
            }
            catch
            {
                Console.WriteLine("Solo números.\n");
            }
        }

        List<string> nombres = new List<string>();
        List<int> edades = new List<int>();

        // Registrar personas
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("\nNombre de la persona #" + (i + 1) + ": ");
            nombres.Add(Console.ReadLine());

            while (true)
            {
                Console.Write("Edad: ");
                try
                {
                    edades.Add(int.Parse(Console.ReadLine()));
                    break;
                }
                catch
                {
                    Console.WriteLine("Edad incorrecta.");
                }
            }
        }

        Console.WriteLine("\n--- TODAS LAS PERSONAS ---");
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine(nombres[i] + " - " + edades[i] + " años");
        }

        Console.WriteLine("\n--- MAYORES DE EDAD ---");
        for (int i = 0; i < cantidad; i++)
        {
            if (edades[i] >= 18)
                Console.WriteLine(nombres[i]);
        }

        Console.WriteLine("\n--- MENORES DE EDAD ---");
        for (int i = 0; i < cantidad; i++)
        {
            if (edades[i] < 18)
                Console.WriteLine(nombres[i]);
        }
    }
}


