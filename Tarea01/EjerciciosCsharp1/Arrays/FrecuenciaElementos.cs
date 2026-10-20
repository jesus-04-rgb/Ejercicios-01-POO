namespace Tarea01.EjerciciosCsharp1.Arrays
{
    public class FrecuenciaElementos
    {
        public void FrecuenciaDeElementos(int[] elementos)
        {
            if (elementos.Length == 0)
            {
                Console.WriteLine("El arreglo está vacío.");
                return;
            }

            // Aquí marcamos los elementos que ya contamos para no repetirlos
            bool[] yaContado = new bool[elementos.Length];

            int elementoMasFrecuente = elementos[0];
            int mayorFrecuencia = 0;

            int elementoMenosFrecuente = elementos[0];
            int menorFrecuencia = elementos.Length; // empezamos con el valor más alto posible

            for (int i = 0; i < elementos.Length; i++)
            {
                // Si este número ya lo contamos antes, lo saltamos
                if (yaContado[i])
                {
                    continue;
                }

                // Contamos cuántas veces aparece elementos
                int veces = 0;
                for (int j = i; j < elementos.Length; j++)
                {
                    if (elementos[j] == elementos[i])
                    {
                        veces++;
                        yaContado[j] = true;
                    }
                }

                Console.WriteLine($"Elemento {elementos[i]}: {veces} veces");

                // Revisamos si es el más o el menos frecuente hasta ahora
                if (veces > mayorFrecuencia)
                {
                    mayorFrecuencia = veces;
                    elementoMasFrecuente = elementos[i];
                }

                if (veces < menorFrecuencia)
                {
                    menorFrecuencia = veces;
                    elementoMenosFrecuente = elementos[i];
                }
            }

            Console.WriteLine($"\nEl elemento con mayor frecuencia es: {elementoMasFrecuente} ({mayorFrecuencia} )");
            Console.WriteLine($"El elemento con menor frecuencia es: {elementoMenosFrecuente} ({menorFrecuencia} )");
        }
    }
}