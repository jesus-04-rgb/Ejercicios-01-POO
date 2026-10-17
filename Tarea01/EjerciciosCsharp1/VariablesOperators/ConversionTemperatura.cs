namespace Tarea01.EjerciciosCsharp1.VariablesOperators
{
    public class ConversionTemperatura
    {
        public void ConvertirTemperatura(float Celsius)
        {
            //aquí convierte de Celsius a Fahrenheit
            float Fahrenheit = (Celsius * 9 / 5) + 32;   //formula
            Console.WriteLine($"Temperatura en Fahrenheit: {Fahrenheit}");
        }
        public void ConvertirAFahrenheit(float Fahrenheit)
        {
            //aquí convierte de Fahrenheit a Celsius
            float Celsius = (Fahrenheit - 32) * 5 / 9;   //formula
            Console.WriteLine($"Temperatura en Celsius: {Celsius}");
        }
        public void ConvertirAKelvin(float Kelvin)
        {
            //aquí convierte de Kelvin a Celsius
            float Celsius = Kelvin - 273.15f;    //formula
            Console.WriteLine($"Temperatura en Celsius: {Celsius}");
        }
    }
}