public class Operadores_logicos
{
    public static void imprimir()
    {
        // AND lógico (&&)
        bool a = true;
        bool b = false;
        bool c = true;
        bool resultado1 = a && b;
        bool resultado2 = a && c;
        Console.WriteLine($"Resultado1: {resultado1}"); 
        Console.WriteLine($"Resultado2: {resultado2}"); 

        // OR lógico (||)
        bool x = true;
        bool y = false;
        bool z = false;
        bool resultado3 = x || y;
        bool resultado4 = y || z;
        Console.WriteLine($"Resultado3: {resultado3}");
        Console.WriteLine($"Resultado4: {resultado4}"); 

        // Combinación de operadores lógicos
        bool p = true;
        bool q = false;
        bool r = true;
        //bool resultado5 = p && q || p && r;
        bool resultado5 = (p && q) || (p && r);
        Console.WriteLine($"Resultado5: {resultado5}"); 

        // NOT lógico (!)
        bool estado = true;
        bool resultado6 = !estado;
        Console.WriteLine($"Resultado6: {resultado6}");

        // Evaluación cortocircuitada
        bool evaluacion1 = EvaluarCondicion1() && EvaluarCondicion2();
        Console.WriteLine($"Evaluación1: {evaluacion1}"); 

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
