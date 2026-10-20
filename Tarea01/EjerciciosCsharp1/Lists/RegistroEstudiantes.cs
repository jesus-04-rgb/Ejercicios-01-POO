namespace Tarea01.EjerciciosCsharp1.Lists
{
    public class RegistroEstudiantes
    {
        private static int posiciónMejor;

        public static void Ejecutar()
        {
         //aquí hacemos el registro de estudiantes usando listas paralelas nombres y promedios
            List<string> nombres = new List<string>();
            List<double> promedios = new List<double>();
            int opcion = 0;

            while (opcion != 5)
            {
                MostrarMenu();

                // Si escribe algo que no es número, volvemos a mostrar el menú
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Escriba solo números, por favor.");
                    continue;
                }
                      // Aquí manejamos la opción ingresada por el usuario
                if (opcion == 1)
                {
                    AgregarEstudiante(nombres, promedios);
                }
                else if (opcion == 2)
                {
                    BuscarEstudiante(nombres, promedios);
                }
                else if (opcion == 3)
                {
                    MostrarMejorPromedio(nombres, promedios);
                }
                else if (opcion == 4)
                {
                    MostrarListado(nombres, promedios);
                }
                else if (opcion == 5)
                {
                    Console.WriteLine("Cheque");
                }
                else
                {
                    Console.WriteLine("Esa opción no existe.");
                }
            }
        }

        static void MostrarMenu()
        {
            // Mostramos el menú de opciones para el registro de estudiantes
            Console.WriteLine();
            Console.WriteLine("==Registro Estudiantes==");
            Console.WriteLine("1. Agregar estudiante");
            Console.WriteLine("2. Buscar por nombre");
            Console.WriteLine("3. Mostrar mejor promedio");
            Console.WriteLine("4. Listado general");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opción: ");
        }

        static void AgregarEstudiante(List<string> nombres, List<double> promedios) // Agrega un estudiante a las listas paralelas
        {
            Console.Write("Nombre del estudiante: ");
            string nombre = (Console.ReadLine() ?? string.Empty).Trim(); // Leemos el nombre del estudiante y eliminamos espacios al inicio y al final

            if (nombre == "")
            {
                Console.WriteLine("No escribiste ningún nombre.");
                return;
            }

            Console.Write("Promedio (0 a 100): "); // Leemos el promedio del estudiante

            if (!double.TryParse(Console.ReadLine(), out double promedio))
            {
                Console.WriteLine("Eso no es un número válido.");
                return;
            }

            if (promedio < 0 || promedio > 100)
            {
                Console.WriteLine("El promedio debe estar entre 0 y 100.");
                return;
            }

            // Guardamos cada dato en su lista, siempre en el mismo orden
            nombres.Add(nombre);
            promedios.Add(promedio);
            Console.WriteLine("Estudiante agregado.");
        }

        static void BuscarEstudiante(List<string> nombres, List<double> promedios)
        {
            Console.Write("Qué estudiante busca líder? ");
            string buscado = (Console.ReadLine() ?? string.Empty).Trim().ToLower();

            bool encontrado = false;

            // Recorremos las posiciones de la lista
            for (int i = 0; i < nombres.Count; i++)
            {
                if (nombres[i].ToLower() == buscado)
                {
                    Console.WriteLine("Encontrado: " + nombres[i] + " - Promedio: " + promedios[i]);
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No hay ningún estudiante con ese nombre.");
            }
        }

        static void MostrarMejorPromedio(List<string> nombres, List<double> promedios)
        {
            if (nombres.Count == 0)
            {
                Console.WriteLine("Todavía no hay estudiantes registrados.");
                return;
            }

            int posiciónMejor = 0;

            for (int i = 1; i < promedios.Count; i++)
            {
                if (promedios[i] > promedios[posiciónMejor])
                {
                    posiciónMejor = i;
                }
            }

            Console.WriteLine("Mejor promedio: " + nombres[posiciónMejor] + " con " + promedios[posiciónMejor]);
        }
                 // Muestra el listado completo de estudiantes con sus promedios
        static void MostrarListado(List<string> nombres, List<double> promedios)
        {
            if (nombres.Count == 0)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Listado general");

            for (int i = 0; i < nombres.Count; i++)  // Recorremos todas las posiciones de la lista para mostrar cada estudiante y su promedio
            {
                Console.WriteLine((i + 1) + ". " + nombres[i] + " - Promedio: " + promedios[i]);
            }
        }
    }
}