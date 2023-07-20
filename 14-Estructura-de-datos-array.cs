public class Estructura_array
{
    public static void imprimir()
    {
        // int[] numeros = new int[2]; // Declaración explícita de tamaño.
        // int[] numeros = new int[2] { 2, 4 }; // Declarar + Definir = Inicializar.
        // int[] numeros = new int[] { 2, 4 }; // Inicializar con declaración implicita.
        // var numeros = new[] { 1, 2, 3, 4 }; // Inicializar con inferencia del tipo por parte del compilador.

        //Extra
        // int[] numeros = new int[10];
        // Array.Fill(numeros, 0); // llena el arreglo con el valor 0.

        string[] nombres = new string[4];
        nombres[0] = "Juan";
        nombres[1] = "Alexis";
        nombres[2] = "Kevin";
        nombres[3] = "Bruno";
        Console.WriteLine("Tamaño del array nombres: " + nombres.Length);

        string[] apellidos = new string[] { "Mena", "Lopez", "Rodriguez" };
        Console.WriteLine("Tamaño del array apellidos: " + apellidos.Length);

        string[] materias = { "Ingles", "Lengua", "Fisica" };
        Console.WriteLine("Tamaño del array materias: " + materias.Length);

        // Ordenamiento mediante método burbuja
        for (int i = 0; i < nombres.Length - 1; i++)
        {
            for (int j = i + 1; j < nombres.Length; j++)
            {
                if (nombres[i].CompareTo(nombres[j]) > 0)
                {
                    string aux = nombres[i];
                    nombres[i] = nombres[j];
                    nombres[j] = aux;
                }
            }
        }
        foreach (string n in nombres)
        {
            Console.WriteLine(n);
        }

        //Busqueda lineal
        string nombre = "Kevin";
        int indice = -1;
        for (int i = 0; i < nombres.Length; i++)
        {
            if (nombres[i] == nombre)
            {
                indice = i;
                break;
            }
        }
        if (indice != -1)
        {
            Console.WriteLine($"nombres[{indice}] = Kevin");
        }
    }
}
