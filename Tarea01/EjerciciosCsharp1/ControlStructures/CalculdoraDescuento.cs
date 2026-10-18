namespace Tarea01.EjerciciosCsharp1.ControlStructures
{
    public class CalculadoraDescuento
    {
        public void CalcularDescuento()
        {
           Console.WriteLine("Ingrese el precio:");
           if(!decimal.TryParse(Console.ReadLine(), out decimal compra)) // Intenta convertir la entrada a un número decimal
            {
                Console.WriteLine("Entrada no válida");
                return;
            }
           if(compra > 2499)
            {
                decimal descuento = compra * 0.15m; // Aplica un 15% de descuento
                decimal precioFinal = compra - descuento;
                Console.WriteLine($"Precio original: {compra}");
                Console.WriteLine($"Descuento: {descuento}");
                Console.WriteLine($"Precio final: {precioFinal}");
            }
            else if(compra > 999)
            {
                decimal descuento = compra * 0.10m; // Aplica un 10% de descuento
                decimal precioFinal = compra - descuento;
                Console.WriteLine($"Precio original: {compra}");
                Console.WriteLine($"Descuento: {descuento}");
                Console.WriteLine($"Precio final: {precioFinal}");
            }
            else if(compra > 500)
            {
                decimal descuento = compra * 0.05m; // Aplica un 5% de descuento
                decimal precioFinal = compra - descuento;
                Console.WriteLine($"Precio original: {compra}");
                Console.WriteLine($"Descuento: {descuento}");
                Console.WriteLine($"Precio final: {precioFinal}");
            }
            else 
            {
                Console.WriteLine($"Precio original: {compra}");
                Console.WriteLine("No aplica descuento");
                Console.WriteLine($"Precio final: {compra}");
            }
    }
}
}