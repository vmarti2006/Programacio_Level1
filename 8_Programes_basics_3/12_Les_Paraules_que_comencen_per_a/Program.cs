using System.Runtime.Serialization.Formatters;

public class Program
{
    public static string ComensaPerA(string frase)
    {
        int cont = 0;
        for (int i = 0; i < frase.Length; i++)
        {
            if (frase[i] == 'a')
            {
                if (i == 0 || frase[i - 1] == ' ')
                { cont++; }
            }
        }
        return $"Hi ha {cont} paraules que comencen per a";
    }
    public static void Main(string[] args)
    {
        // info
        Console.Write("Frase: ");
        var frase = Console.ReadLine()!;

        // proces
        var resultat = ComensaPerA(frase);
        // Resultat
        Console.WriteLine(resultat);
    }
}