namespace Tarea01.EjerciciosCsharp1
{
    public class CalculadoraPréstamoSimple
    {
        public void PréstamoSimple(float capital, float tasaInterés, int tiempo) // Método para calcular el préstamo simple
       {
           Console.WriteLine($"Capital: {capital}"); // Muestra el capital del préstamo
           Console.WriteLine($"Tasa de interés: {tasaInterés}"); // Muestra la tasa de interés del préstamo
           Console.WriteLine($"Tiempo: {tiempo}"); // Muestra el tiempo del préstamo

           float interés = capital * tasaInterés * tiempo; // Calcula el interés del préstamo
           float montoTotal = capital + interés; // Calcula el monto total a pagar
           Console.WriteLine($"Interés: {interés}"); // Muestra el interés calculado
           Console.WriteLine($"Monto total a pagar: {montoTotal}"); // Muestra el monto total a pagar
       }

       
       }

    }