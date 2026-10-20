namespace Tarea01.EjerciciosCsharp1.Arrays
{
    public class BúsquedaYOrdenamiento
    {
        public void BúsquedaOrdenamiento()
        {
            int[] numeros = new int[10];

            // aquí se llena el arreglo
            LlenarArreglo(numeros);
            Console.WriteLine("\nArreglo original:");
            MostrarArreglo(numeros);

            // aquí se realiza la búsqueda lineal
            Console.Write("\Qué número desea buscar? ");
            int buscado;
            while (!int.TryParse(Console.ReadLine(), out buscado))
            {
                Console.Write("Valor inválido, intente de nuevo: ");
            }
            BusquedaLineal(numeros, buscado);

            // aquí se busca el segundo mayor
            SegundoMayor(numeros);

            // aquí se ordena con burbuja (de menor a mayor)
            OrdenarBurbuja(numeros);
            Console.WriteLine("\nArreglo ordenado de forma ascendente:");
            MostrarArreglo(numeros);

            // aquí se muestran los elementos en posiciones pares
            MostrarPosicionesPares(numeros);
        }

        private void LlenarArreglo(int[] numeros)
        {
            // Solicitamos al usuario que ingrese los números para llenar el arreglo.
            Console.WriteLine("Ingrese 10 números enteros.");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Número {i + 1}: ");
                int valor;
                while (!int.TryParse(Console.ReadLine(), out valor))
                {
                    Console.Write("Valor inválido, intente de nuevo: ");
                }
                numeros[i] = valor;
            }
        }

        private void BusquedaLineal(int[] numeros, int buscado)
        {
            // Revisamos casilla por casilla hasta encontrarlo
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == buscado)
                {
                    Console.WriteLine($"El número {buscado} está en la posición {i + 1} (índice {i}).");
                    return;
                }
            }
            Console.WriteLine($"El número {buscado} no está en el arreglo.");
        }

        private void SegundoMayor(int[] numeros)
        {
            int mayor = numeros[0];
            int segundo = 0;
            bool haySegundo = false;

            for (int i = 1; i < numeros.Length; i++)
            {
                int actual = numeros[i];

                if (actual > mayor)
                {
                    // El mayor de antes pasa a ser el segundo
                    segundo = mayor;
                    haySegundo = true;
                    mayor = actual;
                }
                else if (actual < mayor && (!haySegundo || actual > segundo))
                {
                    segundo = actual;
                    haySegundo = true;
                }
             
            }

            if (haySegundo)
                Console.WriteLine($"\nEl mayor es {mayor} y el segundo mayor es {segundo}.");
            else
                Console.WriteLine("\nTodos los números son iguales, no hay segundo mayor.");
        }

        private void OrdenarBurbuja(int[] numeros)
        {
            // En cada pasada, el número más grande "sube" hasta el final
            for (int pasada = 0; pasada < numeros.Length - 1; pasada++)
            {
                for (int j = 0; j < numeros.Length - 1 - pasada; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        // Intercambiamos los dos vecinos
                        int temporal = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temporal;
                    }
                }
            }
        }

        private void MostrarPosicionesPares(int[] numeros)
        {
            Console.WriteLine("Elementos en posiciones pares (índices 0, 2, 4, 6, 8):");
            for (int i = 0; i < numeros.Length; i += 2)
            {
                Console.WriteLine($"Posición {i}: {numeros[i]}");
            }
        }

        private void MostrarArreglo(int[] numeros)
        {
            Console.WriteLine(string.Join(", ", numeros)); //string.Join une los elementos del arreglo en una sola cadena, separados por ", ".
        }
    }
}