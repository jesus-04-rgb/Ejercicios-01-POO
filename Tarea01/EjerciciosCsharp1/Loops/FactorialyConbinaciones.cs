namespace Tarea01.EjerciciosCsharp1.Loops
{
    public class FactorialCombinaciones
    {
        // Calcula n! con un bucle for.
        public long Factorial(int n)
        {
            long resultado = 1;
            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        // Calcula C(n, r) = n! / (r! * (n - r)!)
        public long Combinaciones(int n, int r)
        {
            return Factorial(n) / (Factorial(r) * Factorial(n - r));
        }

        public void Ejecutar()
        {    // Método para ejecutar la interacción con el usuario.
            Console.Write("Ingrese n: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
            {
                Console.WriteLine("n debe ser un entero mayor o igual que 0.");
                return;
            }
             // Método para leer r desde la consola.
            Console.Write("Ingrese r: ");
            if (!int.TryParse(Console.ReadLine(), out int r) || r < 0 || r > n) // Validación de r
            {
                Console.WriteLine("r debe ser un entero entre 0 y n.");
                return;
            }

            if (n > 20)
            {
                Console.WriteLine("n es demasiado grande: n! se desborda con long a partir de 21.");
                return;
            }

            Console.WriteLine($"{n}! = {Factorial(n)}");  // Muestra el factorial de n
            Console.WriteLine($"C({n},{r}) = {Combinaciones(n, r)}");  // Muestra el número de combinaciones de n elementos tomados de r en r
        }
    }
}