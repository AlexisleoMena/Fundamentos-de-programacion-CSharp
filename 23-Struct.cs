public class Struct
{
    public struct Point
    {
        public int X;
        public int Y;

        // Constructor
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Método para calcular la distancia entre dos puntos
        public double DistanceTo(Point other)
        {
            int deltaX = X - other.X;
            int deltaY = Y - other.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }

    public static void imprimir()
    {
        // Ejemplo de uso de la estructura Point
        Point p1 = new Point(10, 20);
        Point p2 = new Point(5, 8);

        // Calcular y mostrar la distancia entre los puntos p1 y p2
        double distance = p1.DistanceTo(p2);
        Console.WriteLine($"La distancia entre p1 y p2 es: {distance}");

        // Sumar los puntos p1 y p2 y obtener un nuevo punto p3
        Point p3 = new Point(p1.X + p2.X, p1.Y + p2.Y); ;
        Console.WriteLine($"El punto resultante de la suma es: ({p3.X}, {p3.Y})");
    }

}
