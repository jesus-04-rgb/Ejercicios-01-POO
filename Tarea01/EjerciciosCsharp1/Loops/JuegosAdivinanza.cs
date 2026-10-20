namespace Tarea01.EjerciciosCsharp1.Loops
{
    public class JuegosAdivinanza
    {
        public void Jugar()
        {  // Inicio del juego de adivinanza
            int numeroSecreto = new Random().Next(1, 101);
            int intento = 0;
            int intentosRestantes = 7;
            int intentosRealizados = 0;
               
               // Bucle principal del juego
            while (intentosRestantes > 0 && intento != numeroSecreto) 
            {
                Console.Write("Adivina el número (1-100): ");

                if (!int.TryParse(Console.ReadLine(), out intento) || intento < 1 || intento > 100) // Validación de entrada
                {
                    Console.WriteLine("Ingresa un número válido entre 1 y 100.");
                    continue;
                }
                // Aquí se actualizan los contadores de intentos
                intentosRestantes--;
                intentosRealizados++;

                if (intento < numeroSecreto)
                    Console.WriteLine("Demasiado bajo.");
                else if (intento > numeroSecreto)
                    Console.WriteLine("Demasiado alto.");
            }
            // Fin del bucle principal del juego
            if (intento == numeroSecreto)
                Console.WriteLine("¡Felicidades! Adivinaste el número.");
            else
                Console.WriteLine($"Se acabaron los intentos. El número secreto era {numeroSecreto}.");

            Console.WriteLine($"Intentos realizados: {intentosRealizados}");
        }
    }
}
