using System;
using System.Collections.Generic;

namespace HistorialNavegacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> historial = new Stack<string>(); // Pila para páginas visitadas
            Queue<string> paginasEnEspera = new Queue<string>(); // Cola para páginas por visitar

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n--- Menú Navegador ---");
                Console.WriteLine("1. Visitar nueva página");
                Console.WriteLine("2. Ir hacia atrás (Historial)");
                Console.WriteLine("3. Agregar página en espera");
                Console.WriteLine("4. Visitar siguiente página en espera");
                Console.WriteLine("5. Mostrar historial");
                Console.WriteLine("6. Mostrar páginas en espera");
                Console.WriteLine("7. Salir");
                Console.Write("Opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese la URL de la página: ");
                        string pagina = Console.ReadLine();
                        historial.Push(pagina);
                        Console.WriteLine($"Visitando: {pagina}");
                        break;

                    case 2:
                        if (historial.Count > 0)
                        {
                            string ultima = historial.Pop();
                            Console.WriteLine($"Retrocediendo desde {ultima}");
                        }
                        else
                        {
                            Console.WriteLine("No hay historial para retroceder.");
                        }
                        break;

                    case 3:
                        Console.Write("Ingrese la URL de la página en espera: ");
                        string espera = Console.ReadLine();
                        paginasEnEspera.Enqueue(espera);
                        Console.WriteLine($"Página agregada en espera: {espera}");
                        break;

                    case 4:
                        if (paginasEnEspera.Count > 0)
                        {
                            string siguiente = paginasEnEspera.Dequeue();
                            historial.Push(siguiente);
                            Console.WriteLine($"Visitando desde espera: {siguiente}");
                        }
                        else
                        {
                            Console.WriteLine("No hay páginas en espera.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Historial de navegación:");
                        foreach (var h in historial)
                            Console.WriteLine(h);
                        break;

                    case 6:
                        Console.WriteLine("Páginas en espera:");
                        foreach (var e in paginasEnEspera)
                            Console.WriteLine(e);
                        break;

                    case 7:
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}
