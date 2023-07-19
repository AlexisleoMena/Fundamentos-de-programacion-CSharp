// Ejemplo de uso de la estructura repetitiva "for" en C#
public class Estructura_for
{
    public static void imprimir()
    {
        // Imprimir los números del 1 al 10
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i);
        }

        Console.WriteLine();

        // Imprimir los números del 10 al 1
        for (int i = 10; i >= 1; i--)
        {
            Console.Write(i);
        }

        Console.WriteLine();


        // Imprimir los números pares del 0 al 20
        for (int i = 0; i <= 20; i += 2)
        {
            Console.Write(i);
        }

        Console.WriteLine();


        // Imprimir el abecedario de la A a la J
        for (char c = 'A'; c <= 'J'; c++)
        {
            Console.Write(c);
        }

        Console.WriteLine();

        // Calcular la suma de los números del 1 al 100
        int suma = 0;
        for (int i = 1; i <= 100; i++)
        {
            suma += i;
        }
        Console.WriteLine("La suma de los números del 1 al 100 es: " + suma);

        // Imprimir los caracteres de una cadena
        string mensaje = "Hola, este es un ejemplo";
        for (int i = 0; i < mensaje.Length; i++)
        {
            Console.Write(mensaje[i]);
        }

        Console.WriteLine();

        // Imprimir los elementos de un arreglo
        int[] numeros = { 10, 20, 30, 40, 50 };
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write(numeros[i]);
        }

        Console.WriteLine();

        // Con inicialización fuera del ciclo. Imprimir los números del 0 al 4
        int j = 0;
        for (; j < 5; j++)
        {
            Console.Write(j);
        }

        Console.WriteLine();

        // Sin parametros. Imprimir números del 0 al 4
        j = 0;
        for (; ; )
        {
            if (j >= 5)
            {
                break;
            }
            Console.Write(j);
            j++;
        }
    }
}
