namespace Unidad_2_practica_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace RegistroUsuariosApp
    {
        // Se usa una estructura para agrupar los datos, cambiando el estilo de listas paralelas
        struct Persona
        {
            public string Nombre;
            public int Edad;
        }

        class Gestionador
        {
            static void Main(string[] args)
            {
                bool continuar = true;

                while (continuar)
                {
                    Console.Clear();
                    Console.WriteLine("===== SISTEMA DE REGISTRO =====");

                    int cantidad = LeerEntero("¿Cuántos registros desea ingresar?: ", 1);
                    var listaPersonas = new List<Persona>();

                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine($"\nRegistro #{i + 1}");
                        Console.Write("Nombre completo: ");
                        string nombreInput = Console.ReadLine();

                        int edadInput = LeerEntero($"Ingrese la edad de {nombreInput}: ", 0);

                        listaPersonas.Add(new Persona { Nombre = nombreInput, Edad = edadInput });
                    }

                    // Filtrado de datos usando una lógica de separación clara
                    MostrarResultados(listaPersonas);

                    Console.Write("\n¿Desea realizar un nuevo análisis? (s/n): ");
                    string input = Console.ReadLine().ToLower();
                    continuar = (input == "s" || input == "si");
                }
            }

            // Método auxiliar para limpiar el Main y manejar errores de entrada
            static int LeerEntero(string mensaje, int min)
            {
                int valor;
                Console.Write(mensaje);
                while (!int.TryParse(Console.ReadLine(), out valor) || valor < min)
                {
                    Console.WriteLine($"ERROR: Por favor ingrese un número válido (mínimo {min}).");
                    Console.Write(mensaje);
                }
                return valor;
            }

            static void ShowHeader(string titulo)
            {
                Console.WriteLine($"\n>> {titulo.ToUpper()} <<");
            }

            static void MostrarResultados(List<Persona> personas)
            {
                ShowHeader("Listado de Adultos");
                foreach (var p in personas)
                {
                    if (p.Edad >= 18)
                        Console.WriteLine($"- {p.Nombre} ({p.Edad} años)");
                }

                ShowHeader("Listado de Menores");
                foreach (var p in personas)
                {
                    if (p.Edad < 18)
                        Console.WriteLine($"- {p.Nombre} ({p.Edad} años)");
                }
            }
        }
    }|+

