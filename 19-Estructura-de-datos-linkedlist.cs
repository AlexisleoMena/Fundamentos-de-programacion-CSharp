using System;
using System.Collections.Generic;

public class Estructura_linkedlist
{
    public static void imprimir()
    {
        // Crear una lista enlazada y agregar elementos al final.
        LinkedList<string> nombres = new LinkedList<string>();
        nombres.AddLast("Alexisleo");
        nombres.AddLast("Bob");
        nombres.AddLast("Charlie");
        nombres.AddLast("David");

        // Recorrer la lista enlazada y mostrar los elementos.
        Console.WriteLine("Elementos de la lista enlazada:");
        foreach (var nombre in nombres)
        {
            Console.WriteLine(nombre);
        }

        // Agregar un elemento al inicio de la lista enlazada.
        nombres.AddFirst("Aaron");
        Console.WriteLine("\nElementos después de agregar al inicio:");
        foreach (var nombre in nombres)
        {
            Console.WriteLine(nombre);
        }

        // Agregar un elemento después de un nodo específico.
        var nodoBob = nombres.Find("Bob");
        if (nodoBob != null)
        {
            nombres.AddAfter(nodoBob, "Brenda");
        }
        Console.WriteLine("\nElementos después de agregar después de 'Bob':");
        foreach (var nombre in nombres)
        {
            Console.WriteLine(nombre);
        }

        // Eliminar un elemento de la lista enlazada.
        nombres.Remove("Charlie");
        Console.WriteLine("\nElementos después de eliminar 'Charlie':");
        foreach (var nombre in nombres)
        {
            Console.WriteLine(nombre);
        }
    }
}
