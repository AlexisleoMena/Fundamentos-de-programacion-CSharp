public class Estructura_while
{
    public static void imprimir()
    {
        bool condicion = 4 < 1;
        while (condicion)
        {
            Console.WriteLine(
                "Puede no ejecutarse nunca, todo depende del resultado de la expresión lógica."
            );
        }

        byte manzanas = 1;
        while (manzanas < 10)
        {
            Console.WriteLine("Cantidad de manzanas: " + manzanas);
            manzanas++;
        }
    }
}
