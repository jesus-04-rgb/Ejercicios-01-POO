namespace Tarea01.EjerciciosCsharp1.Loops
{
    public class PromedioConCentinela
    {
        public void MostrarPromedioConCentinela()
        {
            Console.WriteLine("======Promedio con Centinela====");
            Console.WriteLine("Ingrese números");
            // Se utilizará -1 como centinela para finalizar la entrada de números
            int suma = 0;
            int contador = 0;
            // Bucle infinito para leer números hasta que se ingrese el centinela la cual es -1
            while (true)
            {
                int numero = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("No se ingresó un número."));
                if (numero == -1)
                {
                    break;
                }
                suma += numero;
                contador++;
            }
            // Se muestra el promedio solo si se ingresaron números
            if (contador == 0)
            {
                Console.WriteLine("No se ingresaron números.");
            }
            else
            {
                double promedio = (double)suma / contador; // Cálculo del promedio
                Console.WriteLine($"Promedio de los números ingresados: {promedio}");
            }
        }
    }
}