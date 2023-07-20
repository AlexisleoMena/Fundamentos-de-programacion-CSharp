using System;
using System.Collections.Generic;

public class Estructura_stack
{
    public static void imprimir()
    {
        // Crear una pila y agregar elementos.
        Stack<string> libros = new Stack<string>();
        libros.Push("Libro 1");
        libros.Push("Libro 2");
        libros.Push("Libro 3");

        // Obtener el �ltimo elemento de la pila (LIFO).
        string ultimoLibro = libros.Pop();
        Console.WriteLine("El �ltimo libro de la pila es: " + ultimoLibro);

        // Verificar si la pila contiene un elemento espec�fico.
        bool contieneLibro2 = libros.Contains("Libro 2");
        Console.WriteLine("�La pila contiene el Libro 2?: " + contieneLibro2);

        // Acceder al �ltimo elemento de la pila sin eliminarlo.
        string primerLibro = libros.Peek();
        Console.WriteLine("El primer libro en la pila es: " + primerLibro);

        // Recorrer y vaciar la pila utilizando un bucle while.
        Console.WriteLine("\nRecorrido de la pila:");
        while (libros.Count > 0)
        {
            string libroActual = libros.Pop();
            Console.WriteLine("Libro retirado: " + libroActual);
        }

        // Verificar si la pila est� vac�a.
        bool pilaVacia = libros.Count == 0;
        Console.WriteLine("\n�La pila est� vac�a?: " + pilaVacia);
    }
}
