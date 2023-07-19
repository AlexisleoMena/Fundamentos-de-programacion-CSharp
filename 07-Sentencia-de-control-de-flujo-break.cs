public class Sentencia_break
{
    public static void imprimir()
    {
        string[] nombres = { "Alexis", "Juan", "Carlos", "Esteban" };

        string nombre = "Carlos";
        int indice = -1;
        for (int i = 0; i < nombres.Length; i++)
        {
            // Hará 3 iteraciones (2 completas) hasta encontrar el indice de Carlos, al encontrarlo sale del loop.
            Console.WriteLine("Inicio de la iteración " + (i + 1)); 
            if (nombres[i] == nombre)
            {
                indice = i;
                break;
            }
            Console.WriteLine("Fin de la iteración " + (i + 1));
        }

        if (indice != -1)
            Console.WriteLine("El nombre Carlos se encuentra en el índice " + indice);
        else
            Console.WriteLine("El nombre Carlos no se encuentra dentro de la lista de nombres");
    }
}
