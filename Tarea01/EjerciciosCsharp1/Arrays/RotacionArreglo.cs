namespace Tarea01.EjerciciosCsharp1.Arrays
{
    public class RotaciónArreglo
    {
        private int opcion;

        //aquí lo que hacemos es permitir al usuario rotar un arreglo de enteros a la izquierda o derecha, invertirlo y mostrarlo.
        public void Ejecutar()
        {
            int n = LeerEntero("¿Cuántos elementos tendrá el arreglo? ", 1);
            int[] arreglo = new int[n];
              // Pedimos al usuario que ingrese cada elemento del arreglo
            for (int i = 0; i < n; i++)
            {
                arreglo[i] = LeerEntero($"Elemento [{i}]: ");
            }
            // Mostramos el menú y ejecutamos la opción elegida por el usuario
            do
            {
                Console.WriteLine("\nArreglo actual: " + Mostrar(arreglo));
                Console.WriteLine("1. Rotar K posiciones a la izquierda");
                Console.WriteLine("2. Rotar K posiciones a la derecha");
                Console.WriteLine("3. Invertir el arreglo");
                Console.WriteLine("4. Salir");
                opcion = LeerEntero("Elija una opción: ");
                  
                  // Ejecutamos la opción elegida por el usuario
                switch (opcion)
                {
                    case 1:
                        int kIzq = LeerEntero("Cuántas posiciones ? ", 0);
                        RotaciónDeArreglo(arreglo, -kIzq); // aquí se realiza la rotación a la izquierda
                        break;
                    case 2:
                        int kDer = LeerEntero("Cuántas posiciones ? ", 0);
                        RotaciónDeArreglo(arreglo, kDer);  // aquí se realiza la rotación a la derecha
                        break;
                    case 3:
                        Invertir(arreglo);
                        break;
                    case 4:
                        Console.WriteLine("¡Adios!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo.");
                        break;
                }
            } while (opcion != 4);
        }

        // imprimimos posiciones de rotación y actualizamos el arreglo
        public void RotaciónDeArreglo(int[] arreglo, int posiciones)
        {
            int longitud = arreglo.Length;
            posiciones = posiciones % longitud;
            if (posiciones < 0) posiciones += longitud;

            int[] temp = new int[longitud];
            for (int i = 0; i < longitud; i++)
            {
                temp[(i + posiciones) % longitud] = arreglo[i];
            }
            for (int i = 0; i < longitud; i++)
            {
                arreglo[i] = temp[i];
            }
        }

        // Intercambia el primero con el último, el segundo con el penúltimo, y así sucesivamente
        public void Invertir(int[] arreglo)
        {
            int inicio = 0;
            int fin = arreglo.Length - 1;

            while (inicio < fin)
            {
                int auxiliar = arreglo[inicio];
                arreglo[inicio] = arreglo[fin];
                arreglo[fin] = auxiliar;
                inicio++;
                fin--;
            }
        }

        public string Mostrar(int[] arreglo)
        {
            return "[" + string.Join(", ", arreglo) + "]"; // mostramos el arreglo como cadena
        }

        // Repite la pregunta hasta que el usuario escriba un entero válido (y mayor o igual al mínimo)
        private int LeerEntero(string mensaje, int mínimo = int.MinValue)
        {
            int valor;
            Console.Write(mensaje);
            while (!int.TryParse(Console.ReadLine(), out valor) || valor < mínimo)
            {
                Console.Write("Valor no válido, intente de nuevo: ");
            }
            return valor;
        }
    }
}