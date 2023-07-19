public class Variables_y_constantes
{
    public static void imprimir()
    {
        char sexo = 'M';
        string nombre = "Alexis";

        const int DNI = 11111111; //constante
        byte tios = 127;
        short primos = 32767;
        int sobrinos = 2147483647;

        decimal saldo = 300.51M;
        float altura = 1.899f;
        double peso = 84.2334d;

        bool casado = false;

        var manzanas = 2;
        var vuelto = 20;

        Console.Write("sexo: " + sexo + "\n");
        Console.WriteLine("nombre: {0}, dni: {1}.", nombre, DNI);
        Console.WriteLine(
            "Ayer compré {0} manzanas, y de ${1}, me devolvieron ${2}.",
            manzanas,
            saldo,
            vuelto
        );

        string msgA = string.Format(
            "Tengo {0} tios, {1} primos y {2} sobrinos.",
            tios,
            primos,
            sobrinos
        );
        string msgB =
            $"Mido {altura}m \nPeso {peso}kg \n¿Estoy casado?, la respuesta es: {(casado ? "Si" : "No")}";
        Console.WriteLine(msgA);
        Console.WriteLine(msgB);
    }
}
