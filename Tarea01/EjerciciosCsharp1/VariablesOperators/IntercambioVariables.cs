namespace Tarea01.EjerciciosCsharp1.VariablesOperators
{
    public class IntercambioVariables
    {
        public void IntercambioDeVariables()
        {
            Console.WriteLine("Ingrese el valor de la primera variable:"); // Solicitar al usuario el valor de la primera variable
            int a = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32 se utiliza para convertir la entrada del usuario a un entero

            Console.WriteLine("Ingrese el valor de la segunda variable:"); // Solicitar al usuario el valor de la segunda variable
            int b = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32 se utiliza para convertir la entrada del usuario a un entero

            // Intercambio de valores
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Valor de la primera variable después del intercambio: {a}");
            Console.WriteLine($"Valor de la segunda variable después del intercambio: {b}");
            Console.WriteLine("Intercambio completado.");       
            // Intercambio sin variable temporal usando operaciones aritméticas
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Sin variable temporal  valor de la primera variable después del intercambio: {a}");
            Console.WriteLine($"Sin variable temporal  valor de la segunda variable después del intercambio: {b}");
            Console.WriteLine("Intercambio sin variable temporal completado.");
            

        }
   }
}