namespace Tarea01.EjerciciosCsharp1.Loops
{
    public class SumaParesImpares
    {
        public void MostrarSumaParesImpares()
        {
            Console.WriteLine("======Suma de Pares e Impares====");
            Console.WriteLine("Ingrese un numero:");
            int numero = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("No se ingresó un número."));
            if (numero < 1)
            {
                Console.WriteLine("El número ingresado debe ser mayor o igual a 1");
                return;
            }
            int sumaPares = 0;
            int sumaImpares = 0;
            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 == 0)
                {
                    sumaPares += i;
                }
                else
                {
                    sumaImpares += i;
                }
            }
            Console.WriteLine($"Suma de números pares: {sumaPares}");
            Console.WriteLine($"Suma de números impares: {sumaImpares}");
        }
    }
}