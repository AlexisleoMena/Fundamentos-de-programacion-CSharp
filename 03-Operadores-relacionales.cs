public class Operadores_relacionales
{
    public static void imprimir()
    {
        string frutaA = "banana";
        string frutaB = "lim�n";
        string frutaC = "banana";
        string frutaD = "naranja";
        string frutaE = "pera";

        // Comparaci�n de igualdad (==)
        bool sonIguales = frutaA == frutaC;
        Console.WriteLine($"�frutaA es igual a frutaC? {sonIguales}");

        // Comparaci�n de desigualdad (!=)
        bool sonDiferentes = frutaA != frutaB;

        Console.WriteLine($"�frutaA es diferente a frutaB? {sonDiferentes}");

        // Comparaci�n mayor que (>)
        bool esMayorQue = frutaA.Length > frutaB.Length;
        Console.WriteLine($"�frutaA tiene m�s letras que frutaB? {esMayorQue}"); 

        // Comparaci�n menor que (<)
        bool esMenorQue = frutaA.Length > frutaC.Length;
        Console.WriteLine($"�frutaA tiene m�s letras que frutaC? {esMenorQue}");

        // Comparaci�n mayor o igual que (>=) y menor o igual que (<=)
        bool esMayorOigualQue = frutaA.Length >= frutaD.Length;
        bool esMenorOigualQue = frutaA.Length <= frutaE.Length;
        Console.WriteLine($"�frutaA tiene m�s o iguales letras que frutaD? {esMayorOigualQue}"); 
        Console.WriteLine($"�frutaA tiene menos o iguales letras que frutaE? {esMenorOigualQue}"); 
    }
}
