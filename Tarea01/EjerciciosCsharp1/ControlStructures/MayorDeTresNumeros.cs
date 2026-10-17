namespace Tarea01.EjerciciosCsharp1.ControlStructures
{
    public class MayorDeTresNúmeros
    {
        public int EvaluarMayor(int numero1, int numero2, int numero3) //declaramos un método para evaluar cuál de los tres números es el mayor
        {
            if (numero1 >= numero2 && numero1 >= numero3) // si el primer número es mayor o igual que los otros dos, es el mayor
            {
                return numero1;
            }
            else if (numero2 >= numero1 && numero2 >= numero3) // si el segundo número es mayor o igual que los otros dos, es el mayor
            {
                return numero2;
            }
            else // si el tercer número no es menor que los otros dos, es el mayor
            {
                return numero3;
            }
        }
    }
}