public class Estructura_condicional_if
{
    public static void imprimir()
    {
        byte edadA = 18;
        if (edadA >= 18)
        {
            Console.WriteLine("Es mayor de edad.");
        }
        else
        {
            Console.WriteLine("No es mayor de edad.");
        }


        byte edadB = 17;
        if (edadB >= 18)
        {
            Console.WriteLine("Es mayor de edad.");
        }
        else if (edadB >= 16)
        {
            Console.WriteLine("Es menor de edad, pero tiene edad para conducir.");
        }
        else
        {
            Console.WriteLine("Es menor de edad y no tiene edad para conducir.");
        }

        // Operador ternario
        string respuesta = edadA >= 18 ? "Es mayor de edad." : "No es mayor de edad.";
        Console.WriteLine(respuesta);

        respuesta =
            edadB >= 18
                ? "Es mayor de edad."
                : edadB >= 16
                    ? "Es menor de edad, pero tiene edad para conducir."
                    : "Es menor de edad y no tiene edad para conducir.";
        Console.WriteLine(respuesta);

        // Operador de coalescencia nula
        string? textoA = null;
        string textoB = "Hola Mundo desde C#";

        string mensajeA = textoA ?? "La cadena es nula.";
        string mensajeB = textoB ?? "La cadena es nula.";

        Console.WriteLine(mensajeA); 
        Console.WriteLine(mensajeB); 

    }
}
