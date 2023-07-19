public class Operadores_unarios
{
    public static void imprimir()
    {
        int manzanas = 1;
        Console.WriteLine("manzana = " + manzanas); // 1
        // Preincremento
        Console.WriteLine("++manzana = " + ++manzanas); // 2
        // Postincremento
        Console.WriteLine("manzana++ = " + manzanas++); // 2
        Console.WriteLine("manzana = " + manzanas); // 3

        int peras = 5;
        int frutas = manzanas + ++peras; // 9
        Console.WriteLine("frutas = " + frutas);

        int alto = 3;
        int ancho = 2;
        int area = alto * ++ancho; // 9
        Console.WriteLine("area = " + area);

        int uvas = 5;
        // Predecremento
        Console.WriteLine("uvas = " + --uvas); // 4
        //Postdecremento
        Console.WriteLine("uvas = " + uvas--); // 4
        Console.WriteLine("uvas = " + uvas); // 3
    }
}
