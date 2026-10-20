namespace Tarea01.EjerciciosCsharp1.Lists
{
    public class ListasTareasPendientes
    {
        private readonly List<string> tareas = new(); // Lista para almacenar las tareas pendientes

        public void MostrarTareas()
        {
            // Bucle principal la cual muestra el menú y maneja las opciones del usuario
            while (true)
            {
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Mostrar tareas");
                Console.WriteLine("3. Eliminar tarea por número");
                Console.WriteLine("4. Mostrar total de tareas pendientes");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                  // Lee la opción del usuario y validarla como número entero
                if (!int.TryParse(Console.ReadLine(), out int opcion))
                {
                    Console.WriteLine("Ingrese un número válido.");
                    continue;
                }
                  // Maneja la opción seleccionada por el usuario
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese la tarea: ");
                        string nuevaTarea = Console.ReadLine() ?? string.Empty;
                        tareas.Add(nuevaTarea);
                        Console.WriteLine("Tarea agregada.");
                        break;

                    case 2:
                        Console.WriteLine("Tareas pendientes:");
                        if (tareas.Count == 0)
                        {
                            Console.WriteLine("No hay tareas pendientes.");
                            break;
                        }
                       // Muestra la lista de tareas pendientes
                        for (int i = 0; i < tareas.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tareas[i]}");
                        }
                        break;

                    case 3:
                        Console.Write("Ingrese el número de la tarea a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int numero) &&
                            numero >= 1 && numero <= tareas.Count)
                        {
                            tareas.RemoveAt(numero - 1);
                            Console.WriteLine("Tarea eliminada.");
                        }
                        else
                        {
                            Console.WriteLine("Número de tarea no válido.");
                        }
                        break;

                    case 4:
                        Console.WriteLine($"Total de tareas pendientes: {tareas.Count}");
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}