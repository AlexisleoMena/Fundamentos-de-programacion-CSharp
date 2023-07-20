using System;

public class Delegados
{
    // Declaración del delegado para operaciones matemáticas
    public delegate int OperacionMatematica(int a, int b);

    // Método para realizar la operación y mostrar el resultado
    public static void RealizarOperacion(OperacionMatematica operacion, int a, int b)
    {
        int resultado = operacion(a, b);
        Console.WriteLine($"Resultado: {resultado}");
    }

    public static void imprimir()
    {
        // Declaración de los métodos para cada operación matemática
        OperacionMatematica suma = (a, b) => a + b;
        OperacionMatematica resta = (a, b) => a - b;
        OperacionMatematica multiplicacion = (a, b) => a * b;
        OperacionMatematica division = (a, b) => b != 0 ? a / b : 0;

        // Realizar operaciones y mostrar resultados
        Console.WriteLine("Operación de Suma:");
        RealizarOperacion(suma, 5, 3);

        Console.WriteLine("Operación de Resta:");
        RealizarOperacion(resta, 5, 3);

        Console.WriteLine("Operación de Multiplicación:");
        RealizarOperacion(multiplicacion, 5, 3);

        Console.WriteLine("Operación de División:");
        RealizarOperacion(division, 5, 3);
        RealizarOperacion(division, 5, 0);
    }
}
