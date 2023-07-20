using System;
using System.Collections.Generic;

public class GraphNode
{
    public string Data;
    public List<GraphNode> Neighbors = new List<GraphNode>();
}

public class Estructura_graph
{
    public static void imprimir()
    {
        // Crear nodos del grafo
        GraphNode nodo1 = new GraphNode { Data = "Nodo 1" };
        GraphNode nodo2 = new GraphNode { Data = "Nodo 2" };
        GraphNode nodo3 = new GraphNode { Data = "Nodo 3" };
        GraphNode nodo4 = new GraphNode { Data = "Nodo 4" };

        // Conectar los nodos con aristas
        nodo1.Neighbors.Add(nodo2); // Nodo 1 -> Nodo 2
        nodo1.Neighbors.Add(nodo3); // Nodo 1 -> Nodo 3
        nodo2.Neighbors.Add(nodo3); // Nodo 2 -> Nodo 3
        nodo3.Neighbors.Add(nodo4); // Nodo 3 -> Nodo 4

        // Mostrar las relaciones del grafo
        Console.WriteLine("Relaciones del grafo:");
        MostrarGrafo(nodo1, 0, new HashSet<GraphNode>());
    }

    public static void MostrarGrafo(GraphNode nodo, int nivel, HashSet<GraphNode> visitados)
    {
        // Mostrar el dato del nodo actual con indentación según su nivel
        Console.WriteLine(new string(' ', nivel * 4) + nodo.Data);

        // Agregar el nodo actual a la lista de visitados
        visitados.Add(nodo);

        // Recorrer los nodos vecinos y mostrarlos recursivamente
        foreach (var vecino in nodo.Neighbors)
        {
            // Si el vecino no ha sido visitado, mostrarlo
            if (!visitados.Contains(vecino))
            {
                MostrarGrafo(vecino, nivel + 1, visitados);
            }
        }
    }
}
