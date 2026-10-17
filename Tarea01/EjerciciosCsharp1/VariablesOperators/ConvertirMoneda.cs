namespace Tarea01.EjerciciosCsharp1.VariablesOperators
{
    public class ConvertirMoneda
    {
        public void MonedaConvertir()
        {
            Console.WriteLine("Ingrese una cantidad en lempiras:"); // Solicitar al usuario la cantidad en lempiras
            double lempiras = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la tasa del dolar (lempiras por 1 dolar):"); // Solicitar al usuario la tasa de conversión del dólar
            double tasaDolar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la tasa del euro (lempiras por 1 euro):"); // Solicitar al usuario la tasa de conversión del euro
            double tasaEuro = Convert.ToDouble(Console.ReadLine());

            // Conversión
            double dolares = lempiras / tasaDolar;
            double euros = lempiras / tasaEuro;
         
            // Mostrar resultados
            Console.WriteLine($"Cantidad en dolares: {dolares:F2}"); // Muestra la cantidad convertida a dólares
            Console.WriteLine($"Cantidad en euros: {euros:F2}"); // Muestra la cantidad convertida a euros
        }
    }
}
