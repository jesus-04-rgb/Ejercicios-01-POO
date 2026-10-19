namespace Tarea01.EjerciciosCsharp1.Loops
{
    public class McdMcm
    {
        // Algoritmo de Euclides: mientras b != 0, reemplaza (a, b) por (b, a % b).
        public int CalcularMcd(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int resto = a % b;
                a = b;
                b = resto;
            }
            return a;
        }

        // MCM(a, b) = (a * b) / MCD(a, b)
        public long CalcularMcm(int a, int b)
        {
            int mcd = CalcularMcd(a, b);
            if (mcd == 0) return 0;   // ambos números son 0

            // Se divide primero para reducir el riesgo de desborde.
            return Math.Abs((long)a / mcd * b);
        }

        public void Ejecutar()
        {
            Console.Write("Ingrese el primer número: ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Valor inválido.");
                return;
            }

            Console.Write("Ingrese el segundo número: ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Valor inválido.");
                return;
            }

            Console.WriteLine($"MCD({a}, {b}) = {CalcularMcd(a, b)}");
            Console.WriteLine($"MCM({a}, {b}) = {CalcularMcm(a, b)}");
        }
    }
}