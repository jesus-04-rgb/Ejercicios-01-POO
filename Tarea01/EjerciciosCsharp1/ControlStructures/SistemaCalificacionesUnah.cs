 namespace Tarea01.EjerciciosCsharp1.ControlStructures
{
    public class SistemaCalificacionesUNAH
    {
        public void EvaluarCalificación(int calificación) // Método para evaluar la calificación ingresada
        {
            Console.WriteLine("Ingrese la calificación:");
            int.TryParse(Console.ReadLine(), out calificación); // Intentar convertir la entrada a un número entero
            Console.WriteLine($"Calificación ingresada: {calificación}"); // Mostrar la calificación ingresada
            Console.WriteLine("Evaluando calificación...");
            if (calificación >= 90) //imprime calificación A
            {
                Console.WriteLine("A");
                Console.WriteLine("Felicidades:).");
            }
            else if (calificación >= 80) //imprime calificación B
            {
                Console.WriteLine("B");
                Console.WriteLine("Buen Trabajo:).");
            }
            else if (calificación >= 70) //imprime calificación C
            {
                Console.WriteLine("C");
                Console.WriteLine("Paso a raspas :).");
            }
            else if (calificación >= 60) //imprime calificación D
            {
                Console.WriteLine("D");
                Console.WriteLine("Tenes chance para pasar:).");
            }
            else //imprime calificación F
            {
                Console.WriteLine("F");
                Console.WriteLine("AplazadoS:(.");
            }
        }

    }
}