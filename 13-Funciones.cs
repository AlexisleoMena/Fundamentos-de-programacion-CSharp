public class Funciones
{
    public static void imprimir()
    {
        // Funci�n que suma dos n�meros enteros y devuelve el resultado.
        int Sum(int a, int b)
        {
            return a + b;
        }

        // Funci�n que concatena dos cadenas de texto y devuelve el resultado.
        string ConcatenateStrings(string str1, string str2)
        {
            return str1 + str2;
        }

        // Funci�n que calcula el �rea de un c�rculo dado su radio.
        double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        // Funci�n que verifica si un n�mero es par.
        bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Funci�n que imprime un mensaje en pantalla.
        void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        int suma = Sum(1, 4);
        string mensaje = ConcatenateStrings("Hola ", "mundo");
        double area = CircleArea(1.44d);
        bool esPar = IsEven(4);

        Console.WriteLine(suma);
        PrintMessage(mensaje);
        Console.WriteLine(area);
        Console.WriteLine(esPar);
    }
}
