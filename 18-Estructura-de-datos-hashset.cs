using System;
using System.Collections.Generic;

public class Estructura_hashset
{
    public static void imprimir()
    {
        // Crear un conjunto y agregar elementos.
        HashSet<int> numeros = new HashSet<int>();
        numeros.Add(1);
        numeros.Add(2);
        numeros.Add(3);

        // Verificar si un elemento está presente en el conjunto.
        bool contiene2 = numeros.Contains(2);
        Console.WriteLine("¿El conjunto contiene el número 2?: " + contiene2);

        // Agregar un elemento duplicado (no se permite en HashSet).
        bool resultado = numeros.Add(1); // Devuelve false, ya que 1 ya estaba en el conjunto.
        Console.WriteLine("¿Se pudo agregar el número 1 nuevamente?: " + resultado);

        // Remover un elemento del conjunto.
        numeros.Remove(3);
        Console.WriteLine("Elementos en el conjunto después de eliminar el número 3:");
        foreach (var num in numeros)
        {
            Console.WriteLine(num);
        }

        // Realizar operaciones de conjuntos como unión, intersección, diferencia.
        HashSet<int> otroConjunto = new HashSet<int> { 2, 3, 4, 5 };
        HashSet<int> union = new HashSet<int>(numeros);
        union.UnionWith(otroConjunto);

        HashSet<int> interseccion = new HashSet<int>(numeros);
        interseccion.IntersectWith(otroConjunto);

        HashSet<int> diferencia = new HashSet<int>(numeros);
        diferencia.ExceptWith(otroConjunto);

        Console.WriteLine("\nResultado de la unión de conjuntos:");
        foreach (var num in union)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("\nResultado de la intersección de conjuntos:");
        foreach (var num in interseccion)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("\nResultado de la diferencia de conjuntos:");
        foreach (var num in diferencia)
        {
            Console.WriteLine(num);
        }
    }
}
