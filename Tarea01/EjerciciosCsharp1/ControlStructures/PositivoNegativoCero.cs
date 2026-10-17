namespace Tarea01.EjerciciosCsharp1.ControlStructures
{
    public class PositivoNegativoCero
    {
       public void EvaluarNumero(int numero) //declaramos un método para evaluar si un numero es positivo, negativo o cero
       {
           if (numero > 0) // si el número es mayor que cero, es positivo
           {
               Console.WriteLine("Positivo");
           }
           else if (numero < 0) // si el número es menor que cero, es negativo
           {
               Console.WriteLine("Negativo");
           }
           else // si el número no es mayor ni menor que cero, es cero
           {
               Console.WriteLine("Cero");
           }
       }
    }
}