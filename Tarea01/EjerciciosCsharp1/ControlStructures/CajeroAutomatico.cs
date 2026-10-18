namespace Tarea01.EjerciciosCsharp1.ControlStructures
{
    public class CajeroAutomatico
    {
        public void RetirarEfectivo()
        {
            decimal saldo = 5000m; // Saldo inicial de la cuenta
            int[] denominaciones = { 500, 100, 50, 20 };

            Console.WriteLine("====Cajero Automático====");
            Console.WriteLine($"Saldo disponible: L{saldo}");
            Console.WriteLine("Ingrese el monto a retirar:");

            if (!int.TryParse(Console.ReadLine(), out int monto) || monto <= 0) // Verifica que el monto sea un número entero positivo
            {
                Console.WriteLine("Monto no válido. Debe ser un número entero positivo.");
                return;
            }
            // Verifica que el monto sea múltiplo de 20
            if (monto % 20 != 0)
            {
                Console.WriteLine("El monto debe ser múltiplo de 20.");
                return;
            }

            if (monto > saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
                return;
            }

            saldo -= monto;
            int restante = monto;

            // Calcula el desglose de billetes a entregar
            Console.WriteLine("Desglose de billetes entregados:");
            foreach (int denominacion in denominaciones)
            {
                int cantidad = restante / denominacion;
                if (cantidad > 0)
                {
                    Console.WriteLine($"  {cantidad} billete(s) de L{denominacion}"); // Muestra la cantidad de billetes de cada denominación entregados
                    restante %= denominacion; // Actualiza el monto restante a entregar
                }
            }

            Console.WriteLine($"Nuevo saldo: L{saldo}");
        }
    }
}