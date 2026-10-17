namespace Tarea01.EjerciciosCsharp1.VariablesOperators
{
    public class AreaYPerímetro
    {
        public void Menu()
        {
            int opción;
             // Menu principal de Area y Perímetro
            do
            {
                Console.WriteLine();
                Console.WriteLine("=== Area y Perímetro ===");
                Console.WriteLine("1. Circulo");
                Console.WriteLine("2. Triangulo");
                Console.WriteLine("3. Rectángulo");
                Console.WriteLine("4. Trapecio");
                Console.WriteLine("5. Salir");
                Console.Write("Elija una opción: ");

                int.TryParse(Console.ReadLine(), out opción);

                switch (opción)
                {
                    case 1:
                        Circulo();
                        break;
                    case 2:
                        Triangulo();
                        break;
                    case 3:
                        Rectángulo();
                        break;
                    case 4:
                        Trapecio();
                        break;
                    case 5:
                        Console.WriteLine("cheque ingeniero");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            } while (opción != 5);
        }

        // Pide un numero y lo repite hasta que sea positivo
        private double LeerPositivo(string mensaje)
        {
            double valor;

            Console.Write(mensaje);
            while (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0) // Repite hasta que el valor sea positivo
            {
                Console.Write("Valor no valido, debe ser un numero positivo. " + mensaje);
            }

            return valor;
        }

        private void Circulo() // Calcula el área y perímetro de un círculo
        {
            double radio = LeerPositivo("Ingrese el radio: ");

            double area = Math.PI * radio * radio;
            double perímetro = 2 * Math.PI * radio;

            Console.WriteLine("Area: " + area.ToString("F2"));
            Console.WriteLine("Perímetro: " + perímetro.ToString("F2"));
        }

        private void Triangulo() // Calcula el área y perímetro de un triángulo
        {
            double baseT = LeerPositivo("Ingrese la base: ");
            double altura = LeerPositivo("Ingrese la altura: ");
            double lado1 = LeerPositivo("Ingrese el lado 1: ");
            double lado2 = LeerPositivo("Ingrese el lado 2: ");
            double lado3 = LeerPositivo("Ingrese el lado 3: ");

            double area = (baseT * altura) / 2;
            double perímetro = lado1 + lado2 + lado3;

            Console.WriteLine("Area: " + area.ToString("F2"));
            Console.WriteLine("Perímetro: " + perímetro.ToString("F2"));
        }

        private void Rectángulo() // Calcula el área y perímetro de un rectángulo
        {
            double baseR = LeerPositivo("Ingrese la base: ");
            double altura = LeerPositivo("Ingrese la altura: ");

            double area = baseR * altura;
            double perímetro = 2 * (baseR + altura);

            Console.WriteLine("Area: " + area.ToString("F2"));
            Console.WriteLine("Perímetro: " + perímetro.ToString("F2"));
        }

        private void Trapecio() // Calcula el área y perímetro de un trapecio
        {
            double baseMayor = LeerPositivo("Ingrese la base mayor: ");
            double baseMenor = LeerPositivo("Ingrese la base menor: ");  
            double altura = LeerPositivo("Ingrese la altura: ");
            double lado1 = LeerPositivo("Ingrese el lado 1: ");
            double lado2 = LeerPositivo("Ingrese el lado 2: ");

            double area = ((baseMayor + baseMenor) * altura) / 2;
            double perímetro = baseMayor + baseMenor + lado1 + lado2;

            Console.WriteLine("Area: " + area.ToString("F2")); //f2 especifica 2 decimales
            Console.WriteLine("Perímetro: " + perímetro.ToString("F2"));
        }
    }
}