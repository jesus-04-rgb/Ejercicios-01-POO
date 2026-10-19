namespace Tarea01.EjerciciosCsharp1.Loops
{
    public class InversionDeNumero
    {
        public void InvertirNumero()
        {
            // Solicita al usuario un número para invertirlo.
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("No se recibió el número."));
            int numeroInvertido = 0;
            // Realiza la inversión del número utilizando un ciclo.
            while (numero != 0)
            {
                int dígito = numero % 10;
                numeroInvertido = numeroInvertido * 10 + dígito;
                numero /= 10;
            }
            Console.WriteLine($"Número invertido: {numeroInvertido}");
        }
        //indicar si el numero es palindromo
        public void EsPalindromo()
        {
            Console.Write("Ingrese un número: ");
            // Lee el número ingresado por el usuario.
            int numero = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("No se recibió el número."));
            int numeroOriginal = numero;
            int numeroInvertido = 0;
            // Invierte el número utilizando un ciclo.
            while (numero != 0)
            {
                int dígito = numero % 10;
                numeroInvertido = numeroInvertido * 10 + dígito;
                numero /= 10;
            }
            if (numeroOriginal == numeroInvertido) // Verifica si el número original es igual al número invertido.
            {
                Console.WriteLine("El número es palindromo.");
            }
            else
            {
                Console.WriteLine("El número no es palindromo.");
            }
        }
    }
}