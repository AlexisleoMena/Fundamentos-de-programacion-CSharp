public class Sentencia_continue
{
    public static void imprimir()
    {
        for (int i = 1; i < 6; i++)
        {
            Console.WriteLine("Inicio de la iteraci�n " + i);
            if (i % 2 == 0)
            {
                // Cada vez que i sea par, "continue" evita el c�digo restante de la iteraci�n actual e inicia la siguiente iteraci�n.
                continue; 
            }
            Console.WriteLine("Fin de la iteraci�n " + i);
        }
    }
}