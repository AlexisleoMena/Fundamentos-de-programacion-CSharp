using System;

public class Expresiones_lambda
{
    public static void imprimir()
    {
        // Función lambda para sumar dos números enteros
        Func<int, int, int> add = (a, b) => a + b;
        int result1 = add(5, 3);
        Console.WriteLine($"Resultado 1: {result1}");

        // Función lambda para calcular el cuadrado de un número
        Func<int, int> square = x => x * x;
        int result2 = square(4);
        Console.WriteLine($"Resultado 2: {result2}");

        // Función lambda para verificar si un número es par
        Predicate<int> isEven = num => num % 2 == 0; // Predicate<T> es un delegado genérico predefinido que representa un método que toma un parámetro del tipo T y devuelve un valor booleano (true o false).
        int numberToCheck = 6;
        bool result3 = isEven(numberToCheck);
        Console.WriteLine($"El número {numberToCheck} {(result3 ? "es par" : "es impar")}");

        // Expresión lambda en LINQ para filtrar elementos de un array
        int[] numbers = { 1, 2, 3, 4, 5, 6 };
        var evenNumbers = Array.FindAll(numbers, n => n % 2 == 0);
        Console.WriteLine("Números pares:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        // Uso de expresión lambda en método "Where" de LINQ
        var names = new string[] { "Alice", "Bob", "Charlie", "David", "Eve" };
        var namesWithA = names.Where(name => name.Contains("a"));
        Console.WriteLine("Nombres que contienen la letra 'a':");
        foreach (var name in namesWithA)
        {
            Console.WriteLine(name);
        }
    }
}
