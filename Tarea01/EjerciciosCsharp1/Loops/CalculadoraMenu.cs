namespace Tarea01.EjerciciosCsharp1.Loops
{
    public class CalculadoraMenu
    {
        public void MostrarMenu()
        {
            double resultado = 0;   // aquí guardamos el último resultado
            int opción = -1;

            while (opción != 0)
            {
                Console.Clear();
                Console.WriteLine("===== Calculadora =====");
                Console.WriteLine("Último resultado: " + resultado);
                Console.WriteLine();
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Potencia");
                Console.WriteLine("6. Raíz cuadrada");
                Console.WriteLine("7. Porcentaje");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opción))
                {
                    Console.WriteLine("Eso no es un número, intenta de nuevo.");
                    opción = -1;
                    Console.ReadKey();
                    continue;
                }

                if (opción == 0)
                {
                    Console.WriteLine("¡Cheque!");
                    break;
                }

                if (opción < 1 || opción > 7)
                {
                    Console.WriteLine("Esa opción no existe.");
                    Console.ReadKey();
                    continue;
                }

                // Pedimos el primer número (con "r" usamos el último resultado)
                double a = PedirNumero("Primer número (o escribe r para usar el resultado anterior): ", resultado);

                if (opción == 6)
                {
                    if (a < 0)
                    {
                        Console.WriteLine("No se puede sacar raíz de un número negativo.");
                    }
                    else
                    {
                        resultado = Math.Sqrt(a);
                        Console.WriteLine("Resultado: " + resultado);
                    }
                }
                else
                {
                    double b = PedirNumero("Segundo número: ", resultado);

                    if (opción == 1)
                    {
                        resultado = a + b;
                        Console.WriteLine("Resultado: " + resultado);
                    }
                    else if (opción == 2)
                    {
                        resultado = a - b;
                        Console.WriteLine("Resultado: " + resultado);
                    }
                    else if (opción == 3)
                    {
                        resultado = a * b;
                        Console.WriteLine("Resultado: " + resultado);
                    }
                    else if (opción == 4)
                    {
                        if (b == 0)
                        {
                            Console.WriteLine("No se puede dividir entre cero.");
                        }
                        else
                        {
                            resultado = a / b;
                            Console.WriteLine("Resultado: " + resultado);
                        }
                    }
                    else if (opción == 5)
                    {
                        resultado = Math.Pow(a, b);
                        Console.WriteLine("Resultado: " + resultado);
                    }
                    else if (opción == 7)
                    {
                        // b es el porcentaje: por ejemplo, 15% de 200 = 30
                        resultado = a * b / 100;
                        Console.WriteLine(b + "% de " + a + " es: " + resultado);
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Presiona cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

        // Pide un número hasta que el usuario escriba uno válido
        private double PedirNumero(string mensaje, double ultimoResultado)
        {
            while (true)
            {
                Console.Write(mensaje);
                string? texto = Console.ReadLine();

                if (texto == "r" || texto == "R")
                {
                    return ultimoResultado;
                }

                if (double.TryParse(texto, out double numero))
                {
                    return numero;
                }

                Console.WriteLine("Ese no es un número válido.");
            }
        }
    }
}