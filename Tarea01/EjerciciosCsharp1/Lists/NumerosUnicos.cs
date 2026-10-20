namespace Tarea01.EjerciciosCsharp1.Lists
{
    public class NumerosÚnicos
    {
        public static void Ejecutar()
        {
            // Aquí guardamos solo los números que no se repiten
            List<int> numeros = new List<int>();
            int duplicados = 0;

            Console.WriteLine("===== Numeros Únicos  =====");
            Console.Write("Cuantos numeros desea ingresar? ");

            // Pedimos la cantidad hasta que escriba un número válido mayor que 0
            int cantidad;
            while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)
            {
                Console.Write("Escriba un número entero mayor que 0: ");
            }

            // Leemos los N números uno por uno
            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write("Número " + i + ": ");

                int numero;
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("Eso no es un entero, intente de nuevo: ");
                }

                if (numeros.Contains(numero))
                {
                    duplicados++;
                    Console.WriteLine("El " + numero + " ya estaba, se descarta.");
                }
                else
                {
                    numeros.Add(numero);
                }
            }

            // Mostramos los resultados
            Console.WriteLine();
            Console.WriteLine("Resultados");

            Console.Write("Lista sin repetidos: ");
            foreach (int numero in numeros)
            {
                Console.Write(numero + "  ");
            }
            Console.WriteLine();

            Console.WriteLine("Números únicos: " + numeros.Count);
            Console.WriteLine("Duplicados descartados: " + duplicados);
        }
    }
}