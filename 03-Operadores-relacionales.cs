public class Operadores_relacionales
{
    public static void imprimir()
    {
        string frutaA = "banana";
        string frutaB = "limón";
        string frutaC = "banana";
        string frutaD = "naranja";
        string frutaE = "pera";

        // Comparación de igualdad (==)
        bool sonIguales = frutaA == frutaC;
        Console.WriteLine($"¿frutaA es igual a frutaC? {sonIguales}");

        // Comparación de desigualdad (!=)
        bool sonDiferentes = frutaA != frutaB;

        Console.WriteLine($"¿frutaA es diferente a frutaB? {sonDiferentes}");

        // Comparación mayor que (>)
        bool esMayorQue = frutaA.Length > frutaB.Length;
        Console.WriteLine($"¿frutaA tiene más letras que frutaB? {esMayorQue}"); 

        // Comparación menor que (<)
        bool esMenorQue = frutaA.Length > frutaC.Length;
        Console.WriteLine($"¿frutaA tiene más letras que frutaC? {esMenorQue}");

        // Comparación mayor o igual que (>=) y menor o igual que (<=)
        bool esMayorOigualQue = frutaA.Length >= frutaD.Length;
        bool esMenorOigualQue = frutaA.Length <= frutaE.Length;
        Console.WriteLine($"¿frutaA tiene más o iguales letras que frutaD? {esMayorOigualQue}"); 
        Console.WriteLine($"¿frutaA tiene menos o iguales letras que frutaE? {esMenorOigualQue}"); 
    }
}
