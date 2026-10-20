namespace Tarea01.EjerciciosCsharp1.Lists
{
    public class SepararNumeros
    {
       public void SepararParesImpares(List<int> numeros)
       {
        // Separamos los números en pares e impares
           List<int> pares = new List<int>();
           List<int> impares = new List<int>();
            
            // Recorremos la lista de números y los clasificamos en pares e impares
           foreach (int numero in numeros)
           {
               if (numero % 2 == 0)
               {
                   pares.Add(numero);
               }
               else
               {
                   impares.Add(numero);
               }
           }
            // Mostramos los resultados por consola
           Console.WriteLine("Números pares: " + string.Join(", ", pares));
           Console.WriteLine("Números impares: " + string.Join(", ", impares));
       }
    }
}