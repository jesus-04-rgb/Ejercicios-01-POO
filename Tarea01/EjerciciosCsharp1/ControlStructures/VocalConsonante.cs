namespace Tarea01.EjerciciosCsharp1.ControlStructures
{
    public class VocalConsonante
    {
        public void EvaluarLetra()
        {
            Console.WriteLine("Ingrese una letra:");
            string? letra = Console.ReadLine();
            if (string.IsNullOrEmpty(letra) || letra.Length != 1) // validamos que la entrada sea una sola letra // || es para verificar si la entrada es nula o vacía
            {
                Console.WriteLine("Entrada inválida");
                return;
            }
            char Caracter = char.ToLower(letra[0]); // convertimos la letra a minúscula para simplificar la evaluación
            switch (Caracter) 
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Es una vocal"); // mostramos que la letra ingresada es una vocal
                    break;
                default:
                    Console.WriteLine("Es una consonante"); // mostramos que la letra ingresada es una consonante
                    break;
            }
        }
    }
}