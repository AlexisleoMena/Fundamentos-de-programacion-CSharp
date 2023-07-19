public class Estructura_switch_case
{
    public static void imprimir()
    {
        byte dia = 1;
        switch (dia)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;
            case 2:
                Console.WriteLine("Lunes");
                break;
            case 3:
                Console.WriteLine("Martes");
                break;
            case 4:
                Console.WriteLine("Miércoles");
                break;
            case 5:
                Console.WriteLine("Jueves");
                break;
            case 6:
                Console.WriteLine("Viernes");
                break;
            case 7:
                Console.WriteLine("Sabado");
                break;
            default:
                Console.WriteLine("La semana solo tiene 7 días");
                break;
        }

        switch (dia)
        {
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
                Console.WriteLine("Es día laboral.");
                break;
            case 7:
            case 1:
                Console.WriteLine("Es fin de semana.");
                break;
            default:
                Console.WriteLine("La semana solo tiene 7 días");
                break;
        }
    }
}
