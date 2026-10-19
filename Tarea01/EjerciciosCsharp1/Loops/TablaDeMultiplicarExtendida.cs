namespace Tarea01.EjerciciosCsharp1.Loops
{
    public class TablaDeMultiplicarExtendida
    {
        public void MostrarTablaDeMultiplicarExtendida()
        {
            Console.WriteLine("======Tabla de Multiplicar Extendida====");
            Console.WriteLine("Ingrese un numero:");
           
            // InvalidoOperationException es para manejar el caso en que no se ingrese un número.
            int numero = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("No se ingresó un número.")); 
             if (numero < 1)
            {
                Console.WriteLine("El número ingresado debe ser mayor o igual a 1");
                return; 
            }
            for (int i = 1; i <= numero ; i++) // Itera del 1 al número ingresado para mostrar la tabla extendida
            {
                for (int j = 1; j <= 12; j++) 
                {
                    Console.WriteLine($"{i} x {j} = {i * j}"); // Muestra la multiplicación del número ingresado por j
                }
            
            }
           
        }
    }
}