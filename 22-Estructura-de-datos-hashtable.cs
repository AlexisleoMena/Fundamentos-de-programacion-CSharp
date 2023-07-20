using System;
using System.Collections;

public class Estructura_hashtable
{
    public static void imprimir()
    {
        // Crear una Hashtable para almacenar las edades de personas
        Hashtable edades = new Hashtable();

        // Agregar información a la Hashtable
        edades.Add("Alexisleo", 30);
        edades.Add("Bob", 25);
        edades.Add("Charlie", 40);
        edades.Add("David", 22);
        edades.Add("Eva", 35);

        // Recuperar la edad de una persona específica
        string nombreBuscado = "Charlie";
        if (edades.ContainsKey(nombreBuscado))
        {
            int edad = (int)edades[nombreBuscado];
            Console.WriteLine($"{nombreBuscado} tiene {edad} años.");
        }
        else
        {
            Console.WriteLine($"No se encontró información para {nombreBuscado} en la Hashtable.");
        }

        // Mostrar todas las edades almacenadas en la Hashtable
        Console.WriteLine("\nEdades almacenadas en la Hashtable:");
        foreach (DictionaryEntry entrada in edades)
        {
            string nombre = (string)entrada.Key;
            int edad = (int)entrada.Value;
            Console.WriteLine($"{nombre}: {edad} años");
        }
    }
}
