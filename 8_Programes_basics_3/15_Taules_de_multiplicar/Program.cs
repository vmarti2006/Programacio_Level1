namespace _15_Taules_de_multiplicar;

public class Program
{
    public static string FesLaTaula(int multi)
    {
        int i=0;
        while (i <= 10)
        {
            int r= multi * i;

            Console.WriteLine($"{multi} x {i} = {r}");

            i++;
        }
        return "Final de la taula";
    }
    public static void Main(string[] args)
    {
        Console.Write("De quin numero vols la taula de multiplicar: ");
        int multi;
        int.TryParse(Console.ReadLine(),out multi);

        var resultat= FesLaTaula(multi);

        Console.WriteLine(resultat);

    }
}
