namespace Tarea01.EjerciciosCsharp1.Loops
{
    public class DecimalBinario
    {
        public void ConvertirDecimalABinario()
        {
            Console.Write("Ingrese un número decimal: ");

              // Valida que el número ingresado sea un entero no negativo.
            if (!int.TryParse(Console.ReadLine(), out int numero) || numero < 0)
            {
                Console.WriteLine("Ingrese un número entero válido, mayor o igual a 0.");
                return;
            }
              // Si el número es 0, se muestra directamente el resultado.
            if (numero == 0)
            {
                Console.WriteLine("Número binario: 0");
                return;
            }
            // Convierte el número decimal a binario.
            string binario = "";
            while (numero > 0)
            {
                binario = $"{numero % 2}{binario}"; // Agrega el residuo al inicio de la cadena binaria
                numero /= 2;
            }

            Console.WriteLine($"Número binario: {binario}");
        }
    }
}