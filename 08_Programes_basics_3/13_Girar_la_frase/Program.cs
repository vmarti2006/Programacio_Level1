public class Program
{
    public static string GirarLaFrase(string frase)
    {
        string frase_girada= "";
        for (int i = frase.Length-1; i >= 0; i--)
        {
            frase_girada= $"{frase_girada}"+ $"{frase[i]}";
        }
        return $"{frase_girada}";
    }
    public static void Main(string[] args)
    {
        // Info
        Console.Write("Frase: ");
        var frase = Console.ReadLine()!;

        // Proces
        var resultat = GirarLaFrase(frase);

        // Resultat
        Console.WriteLine(resultat);
    }
}