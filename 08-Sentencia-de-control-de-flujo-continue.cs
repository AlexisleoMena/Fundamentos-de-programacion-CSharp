public class Sentencia_continue
{
    public static void imprimir()
    {
        for (int i = 1; i < 6; i++)
        {
            Console.WriteLine("Inicio de la iteración " + i);
            if (i % 2 == 0)
            {
                // Cada vez que i sea par, "continue" evita el código restante de la iteración actual e inicia la siguiente iteración.
                continue; 
            }
            Console.WriteLine("Fin de la iteración " + i);
        }
    }
}