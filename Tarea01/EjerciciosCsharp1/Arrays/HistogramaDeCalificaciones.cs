namespace Tarea01.EjerciciosCsharp1.Arrays
{
    public class HistogramaDeCalificaciones
    {
       public void MostrarHistogramaDeCalificaciones()
       {
         Console.Write("¿Cuántas calificaciones va a registrar? ");
         int total = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("No se proporcionó una cantidad."));   

         // aquí lo que se hizo fue crear un arreglo de contadores para cada rango de calificaciones
         int[] contadores = new int[5];

         for (int i = 1; i <= total; i++)
         {
            Console.WriteLine("Calificación " + i + " (0-100): ");
             int nota = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("No se proporcionó una calificación."));
                 // validamos que la calificación esté en el rango de 0 a 100
             while (nota < 0 || nota > 100)
             {
                 Console.Write("Debe estar entre 0 y 100, intente de nuevo: ");
                 nota = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("No se proporcionó una calificación."));
             }

             if (nota <= 59)
             {
                 contadores[0]++;
             }
             else if (nota <= 69)
             {
                 contadores[1]++;
             }
             else if (nota <= 79)
             {
                 contadores[2]++;
             }
             else if (nota <= 89)
             {
                 contadores[3]++;
             }
             else
             {
                 contadores[4]++;
             }
         }
           // mostramos el histograma de calificaciones
         string[] nombres = { "0-59", "60-69", "70-79", "80-89", "90-100" };

         Console.WriteLine();
         Console.WriteLine("HISTOGRAMA DE CALIFICACIONES");
         Console.WriteLine();
               // recorremos cada rango de calificaciones y mostramos la barra correspondiente
         for (int i = 0; i < 5; i++)
         {
             string barra = new string('*', contadores[i]);
             Console.WriteLine(nombres[i] + " | " + barra + " (" + contadores[i] + ")");
         }
       }

    }
}