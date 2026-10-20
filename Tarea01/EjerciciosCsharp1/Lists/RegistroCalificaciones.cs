namespace Tarea01.EjerciciosCsharp1.Lists
{
    public class RegistroCalificaciones
    {
        public static void Ejecutar()
        {
            // Aquí guardamos todas las notas
            List<double> notas = new List<double>();
            string respuesta = "s";

            Console.WriteLine("===== Registro de calificaciones =====");

            // Pedimos notas hasta que el usuario diga que no quiere más
            while (respuesta == "s")
            {
                Console.Write("Escribe una nota (0 a 100): ");

                if (double.TryParse(Console.ReadLine(), out double nota))
                {
                    if (nota >= 0 && nota <= 100)
                    {
                        notas.Add(nota);
                        Console.WriteLine("Nota guardada.");
                    }
                    else
                    {
                        Console.WriteLine("La nota debe estar entre 0 y 100.");
                    }
                }
                else
                {
                    Console.WriteLine("Número no válido.");
                }

                Console.Write("Quiere agregar otra nota líder? (s/n): ");
                respuesta = (Console.ReadLine() ?? string.Empty).Trim().ToLower();
            }

            // Si no escribió ninguna nota, no hay nada que calcular
            if (notas.Count == 0)
            {
                Console.WriteLine("No registraste ninguna nota.");
                return;
            }

            // Resultados con todas las notas
            Console.WriteLine();
            Console.WriteLine("--- Resultados ---");
            MostrarNotas(notas);
            Console.WriteLine("Promedio: " + CalcularPromedio(notas).ToString("F2"));
            Console.WriteLine("Nota máxima: " + CalcularMaxima(notas));
            Console.WriteLine("Nota mínima: " + CalcularMinima(notas));

            // Eliminamos la nota más baja y recalcamos
            double notaMasBaja = CalcularMinima(notas);
            notas.Remove(notaMasBaja);

            Console.WriteLine();
            Console.WriteLine("--- Sin la nota más baja (" + notaMasBaja + ") ---");

            if (notas.Count == 0)
            {
                Console.WriteLine("Ya no quedan notas para calcular el promedio.");
            }
            else
            {
                MostrarNotas(notas);
                Console.WriteLine("Nuevo promedio: " + CalcularPromedio(notas).ToString("F2"));
            }
        }

        static void MostrarNotas(List<double> notas)
        {
            Console.Write("Notas: ");
            foreach (double nota in notas)
            {
                Console.Write(nota + "  ");
            }
            Console.WriteLine();
        }

        static double CalcularPromedio(List<double> notas)
        {
            double suma = 0;

            foreach (double nota in notas)
            {
                suma = suma + nota;
            }

            return suma / notas.Count;
        }

        static double CalcularMaxima(List<double> notas)
        {
            double maxima = notas[0];

            foreach (double nota in notas)
            {
                if (nota > maxima)
                {
                    maxima = nota;
                }
            }

            return maxima;
        }

        static double CalcularMinima(List<double> notas)
        {
            double minima = notas[0];

            foreach (double nota in notas)
            {
                if (nota < minima)
                {
                    minima = nota;
                }
            }

            return minima;
        }
    }
}