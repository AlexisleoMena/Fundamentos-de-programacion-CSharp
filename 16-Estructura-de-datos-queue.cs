using System;
using System.Collections.Generic;

public class Estructura_queue
{
    public static void imprimir()
    {
        // Crear una cola y agregar elementos.
        Queue<string> tareas = new Queue<string>();
        tareas.Enqueue("Tarea 1");
        tareas.Enqueue("Tarea 2");
        tareas.Enqueue("Tarea 3");

        // Obtener el primer elemento de la cola (FIFO).
        string proximaTarea = tareas.Dequeue();
        Console.WriteLine("La próxima tarea a realizar es: " + proximaTarea);

        // Verificar si la cola contiene un elemento específico.
        bool contieneTarea2 = tareas.Contains("Tarea 2");
        Console.WriteLine("¿La cola contiene la Tarea 2?: " + contieneTarea2);

        // Acceder al primer elemento de la cola sin eliminarlo.
        string primeraTarea = tareas.Peek();
        Console.WriteLine("La primera tarea en la cola es: " + primeraTarea);

        // Recorrer y vaciar la cola utilizando un bucle while.
        Console.WriteLine("\nRecorrido de la cola:");
        while (tareas.Count > 0)
        {
            string tareaActual = tareas.Dequeue();
            Console.WriteLine("Tarea realizada: " + tareaActual);
        }

        // Verificar si la cola está vacía.
        bool colaVacia = tareas.Count == 0;
        Console.WriteLine("\n¿La cola está vacía?: " + colaVacia);
    }
}
