namespace Tarea01.EjerciciosCsharp1.VariablesOperators
{
    public class AreaYPerímetro
    {
        public void CalcularAreaYPerímetro(int opción, float radio, float b, float h, float lado1, float lado2, float lado3, float b2, float h2, float Bm, float bm, float ladoIzq, float ladoDer, float h3 )
        {
          switch (opción)
          {
              case 1:
                  // Cálculo del área y perímetro del círculo
                  float areaCirculo = (float)(Math.PI * radio * radio);
                  float perímetroCirculo = (float)(2 * Math.PI * radio);
                  Console.WriteLine($"Área del círculo: {areaCirculo}");
                  Console.WriteLine($"Perímetro del círculo: {perímetroCirculo}");
                  break;
              case 2:
                  // Cálculo del área y perímetro del rectángulo
                  float areaRectángulo = b * h;
                  float perímetroRectángulo = 2 * (b + h);
                  Console.WriteLine($"Área del rectángulo: {areaRectángulo}");
                  Console.WriteLine($"Perímetro del rectángulo: {perímetroRectángulo}");
                  break;
              case 3:
                  // Cálculo del área y perímetro del triángulo
                  float areaTriángulo = (b2 * h2) / 2;
                  float perímetroTriángulo = lado1 + lado2 + lado3;
                  Console.WriteLine($"Área del triángulo: {areaTriángulo}");
                  Console.WriteLine($"Perímetro del triángulo: {perímetroTriángulo}");
                  break;
              case 4:
                  // Cálculo del área y perímetro del trapecio
                  float areaTrapecio = ((Bm + bm) * h3) / 2;
                  float perímetroTrapecio = ladoIzq + ladoDer + Bm + bm;
                  Console.WriteLine($"Área del trapecio: {areaTrapecio}");
                  Console.WriteLine($"Perímetro del trapecio: {perímetroTrapecio}");
                  break;
              default:
                  Console.WriteLine("Opción no válida.");
                  break;
          }
        }
    }
}