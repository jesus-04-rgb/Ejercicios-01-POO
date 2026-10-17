namespace Tarea01.EjerciciosCsharp1.VariablesOperators
{
    public class CalculoSalarioSemanal
    {
        public void CalcularSalarioSemanal(int horasTrabajadas, float salarioPorHora)
        {
            float salarioSemanal = horasTrabajadas * salarioPorHora; // Calcula el salario semanal sin horas extra
            Console.WriteLine($"Salario semanal: {salarioSemanal}");

            if (horasTrabajadas > 44)
            {
                float horasExtra = horasTrabajadas - 44;
                float pagoExtra = horasExtra * salarioPorHora * 1.5f;
                salarioSemanal += pagoExtra; // Suma el pago extra al salario semanal
            }
            Console.WriteLine($"Salario semanal con horas extra: {salarioSemanal}"); // Muestra el salario semanal incluyendo horas extra
        }
    }
}