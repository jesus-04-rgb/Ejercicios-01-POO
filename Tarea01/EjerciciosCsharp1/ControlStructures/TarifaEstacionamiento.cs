namespace Tarea01.EjerciciosCsharp1.ControlStructures
{
    public class TarifaEstacionamiento
    {
        public void CalcularTarifa()
        {
            const decimal TarifaPrimeraHora = 20m; // Tarifa de la primera hora
            const decimal TarifaHoraAdicional = 10m; 
            const decimal TopeDiario = 100m;

            Console.WriteLine("====Paqueo Santa Rosa===");
            Console.WriteLine("Ingrese la cantidad de horas estacionado:");

            if (!int.TryParse(Console.ReadLine(), out int horas) || horas <= 0) // Valida la entrada del usuario // out es para almacenar el valor convertido en la variable horas
            {
                Console.WriteLine("Entrada no válida. Las horas deben ser un número entero positivo.");
                return;
            }

            decimal tarifa = TarifaPrimeraHora + (horas - 1) * TarifaHoraAdicional; // Calculamos la tarifa total

            if (tarifa > TopeDiario)
            {
                tarifa = TopeDiario;
            }

            Console.WriteLine($"Total a pagar: L{tarifa}");
        }
    }
}