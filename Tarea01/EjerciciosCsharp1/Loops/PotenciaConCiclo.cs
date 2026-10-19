using System;

namespace Tarea01.EjerciciosCsharp1.Loops
{
    public class Potencia
    {
        public void CalcularPotencia()
        {
            // Solicita al usuario la base y el exponente para calcular la potencia.
            Console.Write("Ingrese la base: ");
            double baseNum = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException("No se recibió la base."));
            // Lee la base ingresada por el usuario.
            // Solicita al usuario el exponente.
            Console.Write("Ingrese el exponente: ");
            int exponente = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("No se recibió el exponente."));
            // Verifica si la base es 0 y el exponente es negativo, lo cual no está permitido.
            if (baseNum == 0 && exponente < 0)
            {
                Console.WriteLine("No se puede elevar 0 a una potencia negativa.");
                return;
            }
            // Inicializa el resultado y determina cuántas veces se multiplicará la base.
            double resultado = 1;
            int veces = exponente < 0 ? -exponente : exponente;
            // Realiza la multiplicación repetida según el exponente.
            for (int i = 0; i < veces; i++)
            {
                resultado *= baseNum;
            }

            // Si el exponente es negativo, invierte el resultado.
            if (exponente < 0)
            {
                resultado = 1 / resultado;
            }

            Console.WriteLine($"{baseNum} elevado a {exponente} = {resultado}");
        }
    }
}