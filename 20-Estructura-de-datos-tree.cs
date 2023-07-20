using System;
using System.Collections.Generic;

public class TreeNode
{
    public string Data;
    public List<TreeNode> Children = new List<TreeNode>();
}

public class Estructura_Tree
{
    public static void MostrarArbol(TreeNode nodo, int nivel)
    {
        // Mostrar los datos del nodo actual con indentación según su nivel
        Console.WriteLine(new string(' ', nivel * 4) + nodo.Data);

        // Recorrer los nodos hijos y mostrarlos recursivamente
        foreach (var hijo in nodo.Children)
        {
            MostrarArbol(hijo, nivel + 1);
        }
    }

    public static void imprimir()
    {
        // Crear el nodo raíz
        TreeNode raiz = new TreeNode { Data = "Nodo Raíz" };

        // Crear nodos hijos
        TreeNode nodo1 = new TreeNode { Data = "Nodo 1" };
        TreeNode nodo2 = new TreeNode { Data = "Nodo 2" };
        TreeNode nodo3 = new TreeNode { Data = "Nodo 3" };

        // Conectar nodos hijos a la raíz
        raiz.Children.Add(nodo1);
        raiz.Children.Add(nodo2);
        raiz.Children.Add(nodo3);

        // Crear nodos hijos para Nodo 1
        TreeNode nodo11 = new TreeNode { Data = "Nodo 1.1" };
        TreeNode nodo12 = new TreeNode { Data = "Nodo 1.2" };

        // Conectar nodos hijos a Nodo 1
        nodo1.Children.Add(nodo11);
        nodo1.Children.Add(nodo12);

        // Crear nodos hijos para Nodo 2
        TreeNode nodo21 = new TreeNode { Data = "Nodo 2.1" };
        TreeNode nodo22 = new TreeNode { Data = "Nodo 2.2" };

        // Conectar nodos hijos a Nodo 2
        nodo2.Children.Add(nodo21);
        nodo2.Children.Add(nodo22);

        // Mostrar la estructura del árbol
        Console.WriteLine("Estructura del árbol:");
        MostrarArbol(raiz, 0);
    }


}
