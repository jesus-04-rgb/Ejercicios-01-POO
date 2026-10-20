namespace Tarea01.EjerciciosCsharp1.Collections
{
    public class ListaDeCompras
    {
        public void Ejecutar()
        {
            List<string> compras = new(); // Lista para almacenar los productos de la compra
            int opcion = 0;
            
            // Variable para almacenar la opción del menú
            while (opcion != 5)
            {
                MostrarMenu();
                // Leer la opción del usuario
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Escriba solo números, sea serio.");
                    continue;
                }

                if (opcion == 1)
                    AgregarProducto(compras);
                else if (opcion == 2)
                    EliminarProducto(compras);
                else if (opcion == 3)
                    BuscarProducto(compras);
                else if (opcion == 4)
                    MostrarOrdenada(compras);
                else if (opcion == 5)
                    Console.WriteLine("¡Cheque Inge!");
                else
                    Console.WriteLine("Esa opción no existe.");
            }
        }

        private static void MostrarMenu()
        // Muestra el menú de opciones al usuario
        {
            Console.WriteLine();
            Console.WriteLine("===== Mi lista de Compras =====");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            Console.WriteLine("3. Buscar producto");
            Console.WriteLine("4. Mostrar lista ordenada");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opción: ");
        }

             // aquí lo que se hace es agregar un producto a la lista de compras
        private static void AgregarProducto(List<string> compras)
        {
            Console.Write("Qué producto quiere agregarle líder? ");
            string producto = (Console.ReadLine() ?? string.Empty).Trim();

            if (producto == "")
                Console.WriteLine("No escribió nada compa.");
            else if (compras.Contains(producto))
                Console.WriteLine("Ese producto ya está en la lista.");
            else
            {
                compras.Add(producto);
                Console.WriteLine("Producto agregado.");
            }
        }
          // aquí lo que se hace es eliminar un producto de la lista de compras
        private static void EliminarProducto(List<string> compras)
        {
            Console.Write("Qué producto quiere eliminar? ");
            string producto = (Console.ReadLine() ?? string.Empty).Trim();

            if (compras.Contains(producto))
            {
                compras.Remove(producto);
                Console.WriteLine("Producto eliminado.");
            }
            else
                Console.WriteLine("Ese producto no está en la lista.");
        }
        // aquí lo que se hace es buscar un producto en la lista de compras
        private static void BuscarProducto(List<string> compras)
        {
            Console.Write("Qué producto busca? ");
            string producto = (Console.ReadLine() ?? string.Empty).Trim();

            if (compras.Contains(producto))
                Console.WriteLine("Hey, ese producto está en la lista.");
            else
                Console.WriteLine("No, ese producto no está en la lista.");
        }
        // aquí lo que se hace es mostrar la lista de compras ordenada alfabéticamente
        private static void MostrarOrdenada(List<string> compras)
        {
            if (compras.Count == 0)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            compras.Sort(); // ordena la lista alfabéticamente

            Console.WriteLine();
            Console.WriteLine("Productos en orden alfabético");
            foreach (string producto in compras)
                Console.WriteLine("- " + producto);
        }
    }
}