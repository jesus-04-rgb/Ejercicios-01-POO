namespace Tarea01.EjerciciosCsharp1.ControlStructures
{
    public class ClasificaciónDeTriángulos
    {
        public void ClasificarTriangulo()
        {
            Console.WriteLine("Ingrese el primer lado del triángulo:"); // Solicita al usuario el primer lado del triángulo
            if (!double.TryParse(Console.ReadLine(), out double lado1)) 
            {
                Console.WriteLine("Entrada no válida");
                return;
            }

            Console.WriteLine("Ingrese el segundo lado del triángulo:"); // Solicita al usuario el segundo lado del triángulo
            if (!double.TryParse(Console.ReadLine(), out double lado2))
            {
                Console.WriteLine("Entrada no válida");
                return;
            }

            Console.WriteLine("Ingrese el tercer lado del triángulo:"); // Solicita al usuario el tercer lado del triángulo
            if (!double.TryParse(Console.ReadLine(), out double lado3))
            {
                Console.WriteLine("Entrada no válida");
                return;
            }

            if (lado1 == lado2 && lado2 == lado3) // Si los tres lados son iguales, el triángulo es equilátero
            {
                Console.WriteLine("El triángulo es equilátero.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3) // Si al menos dos lados son iguales, el triángulo es isósceles
            {
                Console.WriteLine("El triángulo es isósceles.");
            }
            else // Si todos los lados son diferentes, el triángulo es escaleno
            {
                Console.WriteLine("El triángulo es escaleno.");
            }
        }
    }
}