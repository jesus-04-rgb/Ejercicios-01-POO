namespace Tarea01.EjerciciosCsharp1.Arrays
{
    public class ArreglosTemperaturas
    {
        public void ArregloTemperaturas()
        {
            //Temperaturas de 7 días
            double[] temperaturas = { 23.5, 25.0, 22.8, 24.1, 26.3, 27.0, 22.5 };
            double suma = 0;
            foreach (double temp in temperaturas)
            {
                suma += temp;
            }
            //Mostrar promedio semanal de temperaturas 
            double promedio = suma / temperaturas.Length;
            Console.WriteLine($"La temperatura promedio es: {promedio}");
            
            //Dias con temperaturas por encima del promedio
            int díasArribaPromedio = 0;
            foreach (double temp in temperaturas)
            {
                if (temp > promedio)
                {
                    díasArribaPromedio++;
                }
            }
            Console.WriteLine($"Número de días con temperatura por encima del promedio: {díasArribaPromedio}");
        }
        //Aquí muestra el dia mas caluroso
        public void DiaMasCaluroso()
        {
            double[] temperaturas = { 23.5, 25.0, 22.8, 24.1, 26.3, 27.0, 12.5 };
            double maxTemp = temperaturas[0];
            int diaMaxTemp = 0;
            for (int i = 1; i < temperaturas.Length; i++)
            {
                if (temperaturas[i] > maxTemp)
                {
                    maxTemp = temperaturas[i];
                    diaMaxTemp = i;
                }
            }
            Console.WriteLine($"El día más caluroso fue el día {diaMaxTemp + 1} con una temperatura de {maxTemp}");
        }
        //Aquí muestra el dia mas frio
        public void DiaMasFrio()
        {
            double[] temperaturas = { 23.5, 25.0, 22.8, 24.1, 26.3, 27.0, 12.5 };
            double minTemp = temperaturas[0];
            int diaMinTemp = 0;
            for (int i = 1; i < temperaturas.Length; i++)
            {
                if (temperaturas[i] < minTemp)
                {
                    minTemp = temperaturas[i];
                    diaMinTemp = i;
                }
            }
            Console.WriteLine($"El día más frío fue el día {diaMinTemp + 1} con una temperatura de {minTemp}");
        }
        //variación entre días consecutivos
        public void VariaciónEntreDias()
        {
            double[] temperaturas = { 23.5, 25.0, 22.8, 24.1, 26.3, 27.0, 12.5 };
            for (int i = 1; i < temperaturas.Length; i++)
            {
                double variación = temperaturas[i] - temperaturas[i - 1];
                Console.WriteLine($"Variación del día {i} al día {i + 1}: {variación}");
            }
        }
    }
}