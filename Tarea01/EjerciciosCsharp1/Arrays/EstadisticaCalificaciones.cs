namespace Tarea01.EjerciciosCsharp1.Arrays
{
    public class EstadísticaCalificaciones
    {
        public static void CalcularEstadísticaCalificaciones()
        {
            // Nota mínima para aprobar 
            const double notaAprobación = 65;

            Console.Write("Cuántas calificaciones desea registrar? ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Ingrese un entero positivo: ");
            }

            double[] calificaciones = new double[n];
            // Registro de calificaciones por parte del usuario
            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.Write($"Calificación {i + 1}: ");
                double valor;
                while (!double.TryParse(Console.ReadLine(), out valor) || valor < 0 || valor > 100)
                {
                    Console.Write("Valor inválido, intente de nuevo del 1 al 100: ");
                }
                calificaciones[i] = valor;
            }

            // Aquí se hace el cálculo de la suma, el mayor, el menor, los aprobados y los reprobados
            double suma = 0;
            double mayor = calificaciones[0];
            double menor = calificaciones[0];
            int aprobados = 0;
            int reprobados = 0;

            foreach (double calificación in calificaciones)
            {
                suma += calificación;
                if (calificación > mayor) mayor = calificación;
                if (calificación < menor) menor = calificación;

                if (calificación >= notaAprobación)
                    aprobados++;
                else
                    reprobados++;
            }
            double promedio = suma / calificaciones.Length;

            // Aquí hacemos la segunda pasada para calcular la desviación estándar
            double sumaCuadrados = 0;
            foreach (double calificación in calificaciones)
            {
                double diferencia = calificación - promedio;
                sumaCuadrados += diferencia * diferencia;
            }
            //Math.Sqrt se utiliza para calcular la raíz cuadrada, necesaria para la desviación estándar
            double standardDeviation = Math.Sqrt(sumaCuadrados / calificaciones.Length); //qui va en ingles por que "desviación estándar" se traduce como "standard deviation"
                  // Mostramos los resultados en consola
            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Promedio: {promedio:F2}");
            Console.WriteLine($"Máxima: {mayor}");
            Console.WriteLine($"Mínima: {menor}");
            Console.WriteLine($"Aprobados: {aprobados}");
            Console.WriteLine($"Reprobados: {reprobados}");
            Console.WriteLine($"Desviación estándar: {standardDeviation:F2}");
        }
    }
}