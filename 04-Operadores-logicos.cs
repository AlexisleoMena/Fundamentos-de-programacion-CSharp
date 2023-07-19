public class Operadores_logicos
{
    public static void imprimir()
    {
        // AND l�gico (&&)
        bool a = true;
        bool b = false;
        bool c = true;
        bool resultado1 = a && b;
        bool resultado2 = a && c;
        Console.WriteLine($"Resultado1: {resultado1}"); 
        Console.WriteLine($"Resultado2: {resultado2}"); 

        // OR l�gico (||)
        bool x = true;
        bool y = false;
        bool z = false;
        bool resultado3 = x || y;
        bool resultado4 = y || z;
        Console.WriteLine($"Resultado3: {resultado3}");
        Console.WriteLine($"Resultado4: {resultado4}"); 

        // Combinaci�n de operadores l�gicos
        bool p = true;
        bool q = false;
        bool r = true;
        //bool resultado5 = p && q || p && r;
        bool resultado5 = (p && q) || (p && r);
        Console.WriteLine($"Resultado5: {resultado5}"); 

        // NOT l�gico (!)
        bool estado = true;
        bool resultado6 = !estado;
        Console.WriteLine($"Resultado6: {resultado6}");

        // Evaluaci�n cortocircuitada
        bool evaluacion1 = EvaluarCondicion1() && EvaluarCondicion2();
        Console.WriteLine($"Evaluaci�n1: {evaluacion1}"); 

    }

    public static bool EvaluarCondicion1()
    {
        return false;
    }

    public static bool EvaluarCondicion2()
    {
        return true;
    }
}
