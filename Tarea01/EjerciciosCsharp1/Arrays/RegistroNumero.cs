namespace Tarea01.EjerciciosCsharp1.Arrays
{
    public class RegistroNumero
    {
        public void Ejecutar()
        {
            Console.Write("Cuantos números desea registrar? ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Ingrese un entero positivo: ");
            }

            int[] números = new int[n];

            // Aquí hacemos el llenado del arreglo con los números ingresados por el usuario
            for (int i = 0; i < números.Length; i++)
            {
                Console.Write($"Número {i + 1}: ");
                int valor;
                while (!int.TryParse(Console.ReadLine(), out valor))
                {
                    Console.Write("Valor inválido, intente de nuevo: ");
                }
                números[i] = valor;
            }

            // Aquí hacemos el recorrido con for para calcular suma, mayor y menor
            int sumaFor = 0;
            int mayorFor = números[0];
            int menorFor = números[0];

            for (int i = 0; i < números.Length; i++)
            {
                sumaFor += números[i];
                if (números[i] > mayorFor) mayorFor = números[i];
                if (números[i] < menorFor) menorFor = números[i];
            }
            double promedioFor = (double)sumaFor / números.Length;

            // Aquí hacemos el recorrido con foreach para calcular suma, mayor y menor
            int sumaForeach = 0;
            int mayorForeach = números[0];
            int menorForeach = números[0];

            foreach (int item in números)
            {
                sumaForeach += item;
                if (item > mayorForeach) mayorForeach = item;
                if (item < menorForeach) menorForeach = item;
            }
            double promedioForeach = (double)sumaForeach / números.Length;

            // Aquí mostramos los resultados calculados con for y foreach
            Console.WriteLine("Resultados con for usando índice");
            Console.WriteLine($"Suma: {sumaFor}");
            Console.WriteLine($"Promedio: {promedioFor:F2}");
            Console.WriteLine($"Mayor: {mayorFor}");
            Console.WriteLine($"Menor: {menorFor}");

            Console.WriteLine("Resultados de números ingresados");
            Console.WriteLine($"Suma: {sumaForeach}");
            Console.WriteLine($"Promedio: {promedioForeach:F2}");
            Console.WriteLine($"Mayor: {mayorForeach}");
            Console.WriteLine($"Menor: {menorForeach}");
        }
    }
}