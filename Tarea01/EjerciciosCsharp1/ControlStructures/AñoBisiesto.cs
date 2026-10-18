namespace Tarea01.EjerciciosCsharp1.ControlStructures
{
    public class AñoBisiesto
    {
        public void EvaluarAñoBisiesto()
        {
            Console.WriteLine("Ingrese un año:");
            if (!int.TryParse(Console.ReadLine(), out int año)) // Valida que la entrada sea un número entero
            {
                Console.WriteLine("Entrada no válida");
                return;
            }
            Console.WriteLine($"Ingrese un mes:"); // Solicita al usuario el mes del año
            if (!int.TryParse(Console.ReadLine(), out int mes)) // Validar que la entrada sea un número entero
            {
                Console.WriteLine("Entrada no válida");
                return;
            }
            if (mes < 1 || mes > 12) // Valida que el mes esté en el rango de 1 a 12
            {
                Console.WriteLine("Mes no válido");
                return;
            }
            Console.WriteLine($"El mes ingresado tiene {DateTime.DaysInMonth(año, mes)} días"); // Mostrar el mes ingresado por el usuario
            

            if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0)) // Verifica si el año es bisiesto
            {
                Console.WriteLine($"El año {año} es bisiesto.");
            }
            else
            {
                Console.WriteLine($"El año {año} no es bisiesto.");
            }
        }
    }
}