internal class Program
{
    private static void Main(string[] args)
    {
        // Info 
        Console.WriteLine("Entra el numero: ");
        var numero = Console.ReadLine()!;
        var num = int.Parse(numero);

        // Resultat
        var resultat = QuinColorSera(num);
        Console.WriteLine(resultat);

        // Proces
        string QuinColorSera(int num)
        {
            if (num <= 20) { return "Va al grup  vermell"; }
            else if (num <= 40) { return "Va al grup  blau"; }
            else if (num <= 60) { return "Va al grup  verd"; }
            return "Va al grup  blanc";
        }
;
    }
}