namespace Tarea01.EjerciciosCsharp1.Loops
{
    public class ValidaciónContraseña
    {
        public void Validar()
        {
            string contraseña = "";
               // aquí hacemos la validación de la contraseña
            while (true)
            {
                Console.Write("Ingresa tu contraseña: ");
                contraseña = Console.ReadLine() ?? "";
              // reiniciamos los indicadores de validación para cada intento
                bool tieneMayúscula = false;
                bool tieneMinúscula = false;
                bool tieneNumero = false;
                bool tieneEspecial = false;
                  // aquí verificamos cada caracter de la contraseña
                foreach (char caracter in contraseña)
                {
                    if (char.IsUpper(caracter))
                        tieneMayúscula = true;
                    else if (char.IsLower(caracter))
                        tieneMinúscula = true;
                    else if (char.IsDigit(caracter))
                        tieneNumero = true;
                    else if (!char.IsLetterOrDigit(caracter))
                        tieneEspecial = true;
                }
                // aquí recopilamos los requisitos pendientes de la contraseña
                List<string> requisitosPendientes = new List<string>();

                if (contraseña.Length < 8)
                    requisitosPendientes.Add("tener al menos 8 caracteres");
                if (!tieneMayúscula)
                    requisitosPendientes.Add("incluir una mayúscula");
                if (!tieneMinúscula)
                    requisitosPendientes.Add("incluir una minúscula");
                if (!tieneNumero)
                    requisitosPendientes.Add("incluir un número");
                if (!tieneEspecial)
                    requisitosPendientes.Add("incluir un carácter especial");

                if (requisitosPendientes.Count == 0)  // si no hay requisitos pendientes, la contraseña es válida
                {
                    Console.WriteLine("Contraseña válida.");
                    break;
                }

                Console.WriteLine("A la contraseña le falta: " +
                                  string.Join(", ", requisitosPendientes) + ".");
            }
        }
    }
}