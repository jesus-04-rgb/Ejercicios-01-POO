namespace Tarea01.EjerciciosCsharp1.ControlStructures
{
    public class CalculadoraSwitch
    {
       public void Calcular()
       {
           Console.WriteLine("Ingrese el primer número:");
           if (!double.TryParse(Console.ReadLine(), out double numero1)) // aquí validamos si el número ingresado es un número válido
           {
               Console.WriteLine("Número inválido");
               return;
           }
           Console.WriteLine("Ingrese el segundo número:");   
           if (!double.TryParse(Console.ReadLine(), out double numero2))
           {
               Console.WriteLine("Número inválido");
               return;
           }
           Console.WriteLine("Ingrese la operación (+, -, *, /):"); //aquí solicitamos la operación al usuario
           string? operación = Console.ReadLine();
           switch (operación) // evaluamos la operación ingresada por el usuario
           {
               case "+":
                   Console.WriteLine($"Resultado: {numero1 + numero2}");
                   break;
               case "-":
                   Console.WriteLine($"Resultado: {numero1 - numero2}");
                   break;
               case "*":
                   Console.WriteLine($"Resultado: {numero1 * numero2}");
                   break;
               case "/":
                   if (numero2 == 0) // verificamos si el segundo número es cero antes de dividir
                   {
                       Console.WriteLine("Error: División por cero");
                   }
                   else
                   {
                       Console.WriteLine($"Resultado: {numero1 / numero2}"); // mostramos el resultado de la división
                   }
                   break;
               default:
                   Console.WriteLine("Operación inválida"); // mostramos un mensaje si la operación ingresada no es válida  
                   break;
           }
       }
    }
}