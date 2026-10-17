namespace Tarea01.EjerciciosCsharp1.ControlStructures
{
    public class DiaDeLaSemana
    {
        public void DiaSemana()
        {
           Console.WriteLine("Ingrese un número del 1 al 7:");
           if (!int.TryParse(Console.ReadLine(), out int dia)) //aquí validamos si el número ingresado es un entero
           {
               Console.WriteLine("Número inválido"); // si el número ingresado no es un entero, mostramos un mensaje de error
               return;
           }
           switch (dia) // evaluamos el número ingresado para determinar el día de la semana correspondiente
           {
               case 1:
                   Console.WriteLine("Lunes");
                   break;
               case 2:
                   Console.WriteLine("Martes");
                   break;
               case 3:
                   Console.WriteLine("Miércoles");
                   break;
               case 4:
                   Console.WriteLine("Jueves");
                   break;
               case 5:
                   Console.WriteLine("Viernes");
                   break;
               case 6:
                   Console.WriteLine("Sábado");
                   break;
               case 7:
                   Console.WriteLine("Domingo");
                   break;
               default:
                   Console.WriteLine("Número inválido");
                   break;
           }
        }
    }
}