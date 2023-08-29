using Newtonsoft.Json;
using System.Text.Json.Serialization;

public class ClaseString
{
    public static void Imprimir()
    {
        string[] arrStr = { "Banana", "Manzana" };
        string resultStr = String.Join(" y ", arrStr);
        Console.WriteLine("String.Join(\" y \", new string[] { \"Banana\", \"Manzana\" }) = " + resultStr);

        int resultInt = String.Compare("café", "cafeteria");
        Console.WriteLine("String.Compare(\"café\", \"cafeteria\") = " + resultInt.ToString());

        resultInt = String.CompareOrdinal("café", "cafeteria");
        Console.WriteLine("String.CompareOrdinal(\"café\", \"cafeteria\") = " + resultInt.ToString());

        resultStr = String.Concat("Hola", "¿Como éstas?");
        Console.WriteLine("String.Concat(\"Hola\",\"¿Como éstas?\") = " + resultStr);

        bool resultBool = String.IsNullOrEmpty("") && String.IsNullOrEmpty(null);
        Console.WriteLine("String.IsNullOrEmpty(\"\") && String.IsNullOrEmpty(null) = " + resultBool.ToString());

        resultBool = String.IsNullOrWhiteSpace("") && String.IsNullOrWhiteSpace(null) && String.IsNullOrWhiteSpace(" ");
        Console.WriteLine("String.IsNullOrWhiteSpace(\"\") && String.IsNullOrWhiteSpace(null) && String.IsNullOrWhiteSpace(\" \") = " + resultBool.ToString());

        resultStr = String.Format("{0} y {1}", "bananas", "manzanas");
        Console.WriteLine("String.Format(\"{0} y {1}\", \"bananas\", \"manzanas\") = " + resultStr);

        string[] resultArrStr = "Manzana, Banana, Pera.".Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(" \"Manzana, Banana, Pera.\".Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries) = " + JsonConvert.SerializeObject(resultArrStr));

        resultBool = "La palabra manzana está en ésta oración.".Contains("manzana");
        Console.WriteLine("\"La palabra manzana está en ésta oración.\".Contains(\"manzana\") = " + resultBool.ToString());

        resultInt = "BAnanA".IndexOf('A', 0, "BAnanA".Length - 1);
        Console.WriteLine("\"BAnanA\".IndexOf('A', 0, \"BAnanA\".Length - 1) = " + resultInt.ToString());

        resultInt = "café".CompareTo("cafeteria");
        Console.WriteLine("\"café\".CompareTo(\"cafeteria\") = " + resultInt.ToString());

        resultBool = "Café".Equals("café", StringComparison.OrdinalIgnoreCase);
        Console.WriteLine("\"Café\".Equals(\"café\", StringComparison.OrdinalIgnoreCase) = " + resultBool.ToString());

        resultStr = "Manzana".Remove(1, 3);
        Console.WriteLine("\"Manzana\".Remove(1, 3) = " + resultStr);

        resultStr = "Manzana manzana MANzana!".Replace("manzana", "Pera", StringComparison.OrdinalIgnoreCase);
        Console.WriteLine("\"Manzana manzana MANzana!\".Replace(\"manzana\", \"Pera\", StringComparison.OrdinalIgnoreCase) = " + resultStr);

        string str = "sleo";
        char[] chars = new char[] { 'A', 'l', 'e', 'x', 'i', 's', ' ', ' ', ' ' };
        str.CopyTo(1, chars, 5, str.Length - 1);
        Console.WriteLine("\"sleo\".CopyTo(1, new char[] { 'A', 'l', 'e', 'x', 'i', 's', ' ', ' ',' ' }, 5, \"sleo\".Length - 1) = " + new String(chars));

        resultBool = "Manzana!".EndsWith("a!");
        Console.WriteLine("\"Manzana!\".EndsWith(\"a!\") = " + resultBool.ToString());

        resultInt = "Banana y Manzana".IndexOfAny(new char[] { 'n', 'z', }, 0, "Banana y Manzana".Length - 1);
        Console.WriteLine("\"Banana y Manzana\".IndexOfAny(new char[] { 'n', 'z', }, 0, \"Banana y Manzana\".Length - 1) = " + resultInt.ToString() );

        resultStr = "BananaManzana".Insert(6, " y ");
        Console.WriteLine("\"BananaManzana\".Insert(6, \" y \") = " + resultStr );
         
        resultStr = "Manzanas rojas".Substring(0, 7);
        Console.WriteLine("\"Manzanas rojas\".Substring(0, 7) = " + resultStr);

        resultStr = "ManZanaS".ToLower();
        Console.WriteLine("\"ManZanaS\".ToLower() = " + resultStr);

        resultStr = "ManZanaS".ToUpper();
        Console.WriteLine("\"ManZanaS\".ToUpper() = " + resultStr);

        resultStr = "Manzanas".Trim(new char[] {'M', 's'});
        Console.WriteLine("\"Manzanas\".Trim(new char[] {'M', 's'}) = " + resultStr );

        resultStr = "MMManzanassS".TrimStart(new char[] { 'M', 'S' });
        Console.WriteLine("\"MMManzanassS\".TrimStart(new char[] { 'M', 'S' }) = " + resultStr);

        resultStr = "MMManzanassS".TrimEnd(new char[] { 'M', 'S' });
        Console.WriteLine("\"MMManzanassS\".TrimEnd(new char[] { 'M', 'S' }) = " + resultStr);

        resultInt = "BAnanA".LastIndexOf('A', "BAnanA".Length - 1);
        Console.WriteLine("\"BAnanA\".LastIndexOf('A', \"BAnanA\".Length - 1) = " + resultInt.ToString());

        resultInt = "Banana y Manzana".LastIndexOfAny(new char[] { 'M', 'z', }, "Banana y Manzana".Length - 1);
        Console.WriteLine("\"Banana y Manzana\".LastIndexOfAny(new char[] { 'M', 'z', }, \"Banana y Manzana\".Length - 1) = " + resultInt.ToString());

        resultStr = "Manzana".PadRight("Manzana".Length + 5, 'A');
        Console.WriteLine("\"Manzana\".PadRight(\"Manzana\".Length + 5, 'A') = " + resultStr);

        resultStr = "Manzana".PadLeft("Manzana".Length + 5, 'A');
        Console.WriteLine("\"Manzana\".PadLeft(\"Manzana\".Length + 5, 'A') = " + resultStr);

        resultBool = "Las manzanas".StartsWith("las", StringComparison.OrdinalIgnoreCase);
        Console.WriteLine("\"Las manzanas\".StartsWith(\"las\", StringComparison.OrdinalIgnoreCase) = " + resultBool.ToString());



        /*
            String.Join(" y ", new string[] { "Banana", "Manzana" }) = Banana y Manzana
            String.Compare("café", "cafeteria") = -1
            String.CompareOrdinal("café", "cafeteria") = 132
            String.Concat("Hola","¿Como éstas?") = Hola¿Como éstas?
            String.IsNullOrEmpty("") && String.IsNullOrEmpty(null) = True
            String.IsNullOrWhiteSpace("") && String.IsNullOrWhiteSpace(null) && String.IsNullOrWhiteSpace(" ") = True
            String.Format("{0} y {1}", "bananas", "manzanas") = bananas y manzanas

            "Manzana, Banana, Pera.".Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries) = ["Manzana","Banana","Pera"]
            "La palabra manzana está en ésta oración.".Contains("manzana") = True
            "BAnanA".IndexOf('A', 0, "BAnanA".Length - 1) = 1
            "café".CompareTo("cafeteria") = -1
            "Café".Equals("café", StringComparison.OrdinalIgnoreCase) = True
            "Manzana".Remove(1, 3) = Mana
            "Manzana manzana MANzana!".Replace("manzana", "Pera", StringComparison.OrdinalIgnoreCase) = Pera Pera Pera!
            "sleo".CopyTo(1, new char[] { 'A', 'l', 'e', 'x', 'i', 's', ' ', ' ',' ' }, 5, "sleo".Length - 1) = Alexileo
            "Manzana!".EndsWith("a!") = True
            "Banana y Manzana".IndexOfAny(new char[] { 'n', 'z', }, 0, "Banana y Manzana".Length - 1) = 2
            "BananaManzana".Insert(6, " y ") = Banana y Manzana
            "Manzanas rojas".Substring(0, 7) = Manzana
            "ManZanaS".ToLower() = manzanas
            "ManZanaS".ToUpper() = MANZANAS
            "Manzanas".Trim(new char[] {'M', 's'}) = anzana
            "MMManzanassS".TrimStart(new char[] { 'M', 'S' }) = anzanassS
            "MMManzanassS".TrimEnd(new char[] { 'M', 'S' }) = MMManzanass
            "BAnanA".LastIndexOf('A', "BAnanA".Length - 1) = 5
            "Banana y Manzana".LastIndexOfAny(new char[] { 'M', 'z', }, "Banana y Manzana".Length - 1) = 12
            "Manzana".PadRight("Manzana".Length + 5, 'A') = ManzanaAAAAA
            "Manzana".PadLeft("Manzana".Length + 5, 'A') = AAAAAManzana
            "Las manzanas".StartsWith("las", StringComparison.OrdinalIgnoreCase) = True 
        */
    }
}