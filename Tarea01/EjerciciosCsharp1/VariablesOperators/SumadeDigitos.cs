namespace Tarea01.EjerciciosCsharp1.VariablesOperators
{
    public class SumaDeDígitos
    {
        public void CalcularSumaDeDígitos(int numero)
        {
            // se extrae cada dígito
            int centenas = numero / 100;          // Primer dígito
            int decenas = (numero / 10) % 10;     // Segundo dígito
            int unidades = numero % 10;           // Tercer dígito

            // Calcula la suma
            int suma = centenas + decenas + unidades;

            // Muestra resultado
            Console.WriteLine($"Número: {numero}");
            Console.WriteLine($"Suma de sus dígitos: {suma}");
        }
    }
}
