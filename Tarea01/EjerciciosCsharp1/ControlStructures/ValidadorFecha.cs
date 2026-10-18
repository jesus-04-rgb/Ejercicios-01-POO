namespace Tarea01.EjerciciosCsharp1.ControlStructures
{
    public class ValidadorFecha
    {
        public void ValidarFecha()
        {
            Console.WriteLine("Ingrese una fecha (formato: yyyy-MM-dd):");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime fecha)) // Valida que la entrada sea una fecha válida
            {
                Console.WriteLine("Entrada no válida");
                return;
            }
            Console.WriteLine($"La fecha ingresada es: {fecha.ToShortDateString()}"); // Muestra la fecha ingresada por el usuario //ToShortDateString() muestra la fecha en formato corto (dd/MM/yyyy)
            Console.WriteLine($"El año de la fecha ingresada es bisiesto: {(DateTime.IsLeapYear(fecha.Year) ? "Sí" : "No")}"); //IsLeapYear verifica si el año es bisiesto
            Console.WriteLine($"El mes de la fecha ingresada es bisiesto: {(DateTime.IsLeapYear(fecha.Year) ? "Sí" : "No")}"); //IsLeapYear verifica si el año es bisiesto
            Console.WriteLine($"El día de la fecha ingresada es bisiesto: {(DateTime.IsLeapYear(fecha.Year) ? "Sí" : "No")}");  //IsLeapYear verifica si el año es bisiesto


        }  
      
    }
}