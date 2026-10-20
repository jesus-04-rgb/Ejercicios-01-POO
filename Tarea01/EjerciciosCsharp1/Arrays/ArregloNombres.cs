namespace Tarea01.EjerciciosCsharp1.Arrays
{
    public class ArregloNombres
    {
        public void Ejecutar()
        {
            string[] nombres = new string[5];

            //  Pedir los 5 nombres al usuario
            Console.WriteLine("Vamos a registrar 5 nombres.");
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write($"Escriba el nombre #{i + 1}: ");
                string entrada = Console.ReadLine() ?? string.Empty;

                // Si lo deja vacío, se lo pedimos otra vez
                while (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.Write("No puede estar vacío, intente de nuevo: ");
                    entrada = Console.ReadLine() ?? string.Empty;
                }

                nombres[i] = entrada.Trim();
            }

            //  Mostrar los nombres en orden inverso
            Console.WriteLine("\nNombres en orden inverso:");
            for (int i = nombres.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"- {nombres[i]}");
            }

            //  Encontrar el nombre más largo
            string nombreMasLargo = nombres[0];
            foreach (string nombre in nombres)
            {
                if (nombre.Length > nombreMasLargo.Length)
                {
                    nombreMasLargo = nombre;
                }
            }
            Console.WriteLine($"\nEl nombre más largo es: {nombreMasLargo} ({nombreMasLargo.Length} letras)");

            //  Buscar un nombre que escriba el usuario
            Console.Write("\nQue nombre busca usted? ");
            string buscado = Console.ReadLine()?.Trim() ?? string.Empty;

            bool encontrado = false;
            for (int i = 0; i < nombres.Length; i++)
            {
                // Comparamos sin importar mayúsculas o minúsculas
                if (nombres[i].Equals(buscado, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"\"{nombres[i]}\" está en la posición {i + 1}.");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"Hey ese nombre \"{buscado}\" no está en la lista.");
            }
        }
    }
}