namespace Tarea01.EjerciciosCsharp1.Loops
{
    public class PrimosEnRango
    {
        // Un número es primo si es mayor que 1 y solo es divisible entre 1 y él mismo.
        public bool EsPrimo(int numero)
        {
            if (numero < 2) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;

            // aquí se hace la verificación de los divisores impares hasta la raíz cuadrada del número.
            for (int i = 3; i * i <= numero; i += 2)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }

        public void MostrarPrimosEnRango(int inicio, int fin)
        {   // Verifica que el rango sea válido.
            if (inicio > fin)
            {
                Console.WriteLine("El inicio no puede ser mayor que el fin.");
                return;
            }
              // Inicializa el contador de números primos.
            int contador = 0;
            Console.WriteLine($"Números primos entre {inicio} y {fin}:");

            for (int n = inicio; n <= fin; n++)
            {
                if (EsPrimo(n))
                {
                    Console.Write(n + " ");
                    contador++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Cantidad de números primos: {contador}");
        }

        public void Ejecutar()
        {   // Solicita al usuario el inicio del rango.
            Console.Write("Ingrese el inicio del rango: ");
            if (!int.TryParse(Console.ReadLine(), out int inicio))
            {
                Console.WriteLine("Valor inválido.");
                return;
            }

            // Solicita al usuario el fin del rango.
            Console.Write("Ingrese el fin del rango: ");
            if (!int.TryParse(Console.ReadLine(), out int fin))
            {
                Console.WriteLine("Valor inválido.");
                return;
            }

            MostrarPrimosEnRango(inicio, fin);
        }
    }
}