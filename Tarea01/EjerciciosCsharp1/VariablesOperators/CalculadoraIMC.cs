namespace Tarea01.EjerciciosCsharp1.VariablesOperators
{
    public class CalculadoraIMC
    {
        public void CalcularIMC()
        {
            Console.WriteLine("Ingrese su peso en kilogramos:"); // Solicitar al usuario su peso
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese su altura en metros:"); // Solicitar al usuario su altura
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);// Calcular el índice de masa corporal (IMC)
            Console.WriteLine($"Su IMC es: {imc:F2}"); //f2 sirve para mostrar el resultado con 2 decimales
        }
    }
}
