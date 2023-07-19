public class Operadores_aritmeticos
{
    public static void imprimir()
    {
        int limones = 6;
        int tomates = 2;

        // Operador suma
        int verduras = limones + tomates;
        Console.WriteLine("limones + tomates = " + verduras); // 8

        // Operador resta
        verduras = limones - tomates;
        Console.WriteLine("limones - tomates = " + verduras); // 4

        // Operador multiplicación
        verduras = limones * tomates;
        Console.WriteLine("limones * tomates = " + verduras); // 12

        // Operador división
        verduras = limones / tomates;
        Console.WriteLine("limones / tomates = " + verduras); // 3

        // Operador módulo
        verduras = limones % tomates;
        Console.WriteLine("limones % tomates = " + verduras); // 0

        // Precedencia de operadores
        // ((6 + (6 / 2)) * 6) - (2 * 6) = 42
        verduras = (limones + limones / tomates) * limones - tomates * limones;
        Console.WriteLine("verduras = " + verduras);

        // Operadores relativos de asignacón

        int manzanas = 1;
        manzanas += 8; // Equivale a: manzanas = manzanas + 8;
        Console.WriteLine("manzanas = " + manzanas); // 9

        manzanas -= 3; // Equivale a: manzanas = manzanas - 3;
        Console.WriteLine("manzanas = " + manzanas); // 6

        int peras = 2;
        peras *= 6; // Equivale a: peras = peras * 6;
        Console.WriteLine("peras = " + peras); // 12

        peras /= 3; // Equivale a: peras = peras / 3;
        Console.WriteLine("peras = " + peras); // 4
    }
}
