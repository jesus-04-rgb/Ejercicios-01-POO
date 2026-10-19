namespace Tarea01.EjerciciosCsharp1.Loops
{
    public class SerieFibonacci
    {
        public void MostrarSerieFibonacci(int cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor que cero.");
                return;
            }
            // inicializa los primeros dos números de la serie y la suma acumulada
            long a = 0, b = 1;
            long suma = 0;

            Console.WriteLine("Serie de Fibonacci:");
            // imprime cada número de la serie y acumula la suma
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(a);
                suma += a;          // acumula mientras se imprime

                long temp = a;
                a = b;
                b = temp + b;
            }
            // muestra la suma total de los números de la serie
            Console.WriteLine($"Suma total de la serie: {suma}");

            double promedio = (double)suma / cantidad;
            Console.WriteLine($"Promedio de la serie: {promedio}");
        }
    }
}