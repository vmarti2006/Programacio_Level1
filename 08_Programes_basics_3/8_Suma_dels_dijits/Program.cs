
public class Program
{
    public static string DesglosaISuma(string numero)
    {
        int i =0;
        int num=0;

        while (i<numero.Length)
        {
            num += Int32.Parse($"{numero[i]}");
            i++;
        }

        return $"La suma dels digits es {num}";
    }
    public static void Main(string[] args)
    {
        // info
        Console.Write("Numero: ");
        var numero = Console.ReadLine()!;
        

        // Proces

        var resultat = DesglosaISuma(numero);

        // Resultat
        Console.WriteLine(resultat);
    } 
}