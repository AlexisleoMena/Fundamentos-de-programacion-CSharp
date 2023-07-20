using System;
using System.Collections.Generic;

public class Estructura_dictionary
{
    public static void imprimir()
    {
        // Crear un diccionario y agregar elementos.
        Dictionary<string, int> edades = new Dictionary<string, int>();
        edades.Add("Juan", 25);
        edades.Add("Mar�a", 30);
        edades.Add("Pedro", 40);

        // Acceder a un valor utilizando una clave.
        int edadMaria = edades["Mar�a"];
        Console.WriteLine("La edad de Mar�a es: " + edadMaria);

        // Verificar si una clave existe en el diccionario.
        bool existePedro = edades.ContainsKey("Pedro");
        Console.WriteLine("�Existe Pedro en el diccionario?: " + existePedro);

        // Modificar el valor de una clave existente.
        edades["Juan"] = 28;
        Console.WriteLine("\nDiccionario despu�s de modificar la edad de Juan:");
        foreach (var kvp in edades)
        {
            Console.WriteLine(kvp.Key + ": " + kvp.Value);
        }

        // Recorrer el diccionario utilizando un bucle foreach.
        Console.WriteLine("\nRecorrido del diccionario:");
        foreach (var kvp in edades)
        {
            Console.WriteLine(kvp.Key + ": " + kvp.Value);
        }
    }
}
