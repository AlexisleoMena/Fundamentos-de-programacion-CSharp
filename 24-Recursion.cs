using System;

public class Recursion
{
    public static void imprimir()
    {
        // Suma de elementos de un array
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = SumArrayElements(numbers, numbers.Length - 1);
        Console.WriteLine($"La suma de los elementos del array es: {sum}");

        // Factorial
        int n = 5;
        int result = Factorial(n);
        Console.WriteLine($"El factorial de {n} es: {result}");

        // Búsqueda de un elemento en un array
        int[] arr = { 10, 20, 30, 40, 50 };
        int key = 30;
        bool found = SearchElement(arr, key, 0);
        Console.WriteLine($"El elemento {key} {(found ? "se encuentra" : "no se encuentra")} en el array.");

        // Potencia de un número
        int baseNum = 2;
        int exponent = 5;
        int powerResult = Power(baseNum, exponent);
        Console.WriteLine($"{baseNum} elevado a {exponent} es igual a: {powerResult}");

        // Fibonacci
        int fibonacciTerm = 7;
        int fibonacciResult = Fibonacci(fibonacciTerm);
        Console.WriteLine($"El término {fibonacciTerm} de la secuencia Fibonacci es: {fibonacciResult}");
    }

    // Método para sumar los elementos de un array recursivamente
    public static int SumArrayElements(int[] arr, int index)
    {
        if (index < 0)
            return 0;

        return arr[index] + SumArrayElements(arr, index - 1);
    }

    // Método para calcular el factorial de un número recursivamente
    public static int Factorial(int n)
    {
        if (n == 0)
            return 1;

        return n * Factorial(n - 1);
    }

    // Método para buscar un elemento en un array recursivamente
    public static bool SearchElement(int[] arr, int key, int index)
    {
        if (index >= arr.Length)
            return false;

        if (arr[index] == key)
            return true;

        return SearchElement(arr, key, index + 1);
    }

    // Método para calcular la potencia de un número recursivamente
    public static int Power(int baseNum, int exponent)
    {
        if (exponent == 0)
            return 1;

        return baseNum * Power(baseNum, exponent - 1);
    }

    // Método para calcular el término n de la secuencia Fibonacci recursivamente
    public static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
