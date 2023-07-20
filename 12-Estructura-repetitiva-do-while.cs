public class Estructura_do_while
{
    public static void imprimir()
    {
        do
        {
            Console.WriteLine("Se ejecuta por lo menos una vez sin importar el resultado de la expresión lógica");
        } while (18 < 18);

        char letra = 'a';
        do
        {
            Console.WriteLine(letra++); // a, b, c, d, e
        } while (letra < 'f');
    }
}