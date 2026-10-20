namespace Tarea01.EjerciciosCsharp1.Loops
{
    public class PatronesEnConsola
    {
        public void MostrarPatron()
        {
            // Muestra un menú de patrones en consola y permitir al usuario elegir cuál mostrar.
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\n--- Menú de patrones ---");
                Console.WriteLine("1. Triángulo");
                Console.WriteLine("2. Triángulo invertido");
                Console.WriteLine("3. Rombo");
                Console.WriteLine("4. Cuadrado hueco");
                Console.WriteLine("5. Pirámide numérica");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");
                     // Lee la opción del usuario
                if (!int.TryParse(Console.ReadLine(), out int opción))
                {
                    Console.WriteLine("Ingresa una opción válida.");
                    continue;
                }

                if (opción == 0)
                {
                    continuar = false;
                    continue;
                }

                if (opción < 1 || opción > 5)
                {
                    Console.WriteLine("Opción no válida.");
                    continue;
                }

                Console.Write("Ingresa el tamaño del patrón: ");
                if (!int.TryParse(Console.ReadLine(), out int tamaño) || tamaño < 1)
                {
                    Console.WriteLine("Ingresa un tamaño válido mayor que cero.");
                    continue;
                }
                   // Muestra el patrón seleccionado según la opción del usuario
                switch (opción)
                {
                    case 1:
                        Triangulo(tamaño);
                        break;
                    case 2:
                        TrianguloInvertido(tamaño);
                        break;
                    case 3:
                        Rombo(tamaño);
                        break;
                    case 4:
                        CuadradoHueco(tamaño);
                        break;
                    case 5:
                        PirámideNumérica(tamaño);
                        break;
                }
            }
        }

        private static void Triangulo(int tamaño)
        {
            // Dibuja un triángulo de tamaño dado
            for (int fila = 1; fila <= tamaño; fila++)
            {
                Console.WriteLine(new string('*', fila));
            }
        }

        private static void TrianguloInvertido(int tamaño)
        {
            // Dibuja un triángulo invertido de tamaño dado
            for (int fila = tamaño; fila >= 1; fila--)
            {
                Console.WriteLine(new string('*', fila));
            }
        }

        private static void Rombo(int tamaño)
        {
            // Dibuja un rombo de tamaño dado
            for (int fila = 1; fila <= tamaño; fila++)
            {
                Console.Write(new string(' ', tamaño - fila));
                Console.WriteLine(new string('*', 2 * fila - 1));
            }

            for (int fila = tamaño - 1; fila >= 1; fila--)
            {
                Console.Write(new string(' ', tamaño - fila));
                Console.WriteLine(new string('*', 2 * fila - 1));
            }
        }

        private static void CuadradoHueco(int tamaño)
        {
            // Dibuja un cuadrado hueco de tamaño dado
            for (int fila = 1; fila <= tamaño; fila++)
            {
                for (int columna = 1; columna <= tamaño; columna++)
                {
                    if (fila == 1 || fila == tamaño ||
                        columna == 1 || columna == tamaño)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }

                Console.WriteLine();
            }
        }

        private static void PirámideNumérica(int tamaño)
        {
            // Dibuja una pirámide numérica de tamaño dado
            for (int fila = 1; fila <= tamaño; fila++)
            {
                Console.Write(new string(' ', tamaño - fila));

                for (int numero = 1; numero <= fila; numero++)
                {
                    Console.Write(numero);
                }

                Console.WriteLine();
            }
        }
    }
}