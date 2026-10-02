public class Program
{
    public static string ComptadorDeVocals(string frase)
    {
        int vocals = 0;
        int i = 0;
        while (i < frase.Length)
        {
            if (frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u')
            {
                vocals++;
            }
            i++;
        }
        return $"La frase té {vocals} vocals";
    }
    public static void Main(string[] args)
    {
        // infomacio
        Console.Write("Frase: ");
        var frase = Console.ReadLine()!;

        // Proces
        string resultat = ComptadorDeVocals(frase);

        // Resultat
        Console.WriteLine(resultat);
    }
}