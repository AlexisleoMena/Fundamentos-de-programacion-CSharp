using System;

public class Clousures
{
    public static void imprimir()
    {
        Func<int, int> potenciaBase2 = Potencia(2);
        Console.WriteLine($"2^3 = {potenciaBase2(3)}");
        Console.WriteLine($"2^4 = {potenciaBase2(4)}");

        Func<int, int> potenciaBase3 = Potencia(3);
        Console.WriteLine($"3^3 = {potenciaBase3(3)}");
        Console.WriteLine($"3^4 = {potenciaBase3(4)}");

    }

    public static Func<int, int> Potencia(int baseNum)
    {
        return exponente =>
        {
            int resultado = 1;
            for (int i = 0; i < exponente; i++)
            {
                resultado *= baseNum;
            }
            return resultado;
        };
    }
}
