namespace Tarea01.EjerciciosCsharp1.VariablesOperators
{
    public class TiempoTranscurrido
    {
        public void CalcularTiempoEntreHoras(int horaInicio, int minutoInicio, int segundoInicio, int horaFin, int minutoFin, int segundoFin)
        {
            // date time es para representar las horas de inicio y fin del mismo día
            DateTime inicio = new DateTime(2026, 10, 16, horaInicio, minutoInicio, segundoInicio); 
            DateTime fin = new DateTime(2026, 10, 16, horaFin, minutoFin, segundoFin);

            // Calcula diferencia de tiempo entre inicio y fin
            TimeSpan diferencia = fin - inicio; //timeSpan representa la diferencia entre dos fechas

            // Muestra resultados
            Console.WriteLine($"Tiempo transcurrido: {diferencia.Hours} horas, {diferencia.Minutes} minutos, {diferencia.Seconds} segundos");
        }
    }
}
