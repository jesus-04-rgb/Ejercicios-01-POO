namespace Tarea01.EjerciciosCsharp1.VariablesOperators
{
    public class DesgloseDeBilletes
    {
        public void CalcularDesglose(int cantidad)
        {
            int[] billetes = { 500, 200, 100, 50, 20, 10, 5 }; // Array de billetes disponibles
            foreach (int billete in billetes) //foreach sirve para iterar sobre cada elemento del array de billetes
            {
                int numBilletes = cantidad / billete; // Calcula cuántos billetes de este valor se necesitan
                cantidad %= billete; // Actualiza la cantidad restante después de usar estos billetes
                Console.WriteLine($"{billete}: {numBilletes}"); // Muestra cuántos billetes de este valor se necesitan
            }
        }
    }
}