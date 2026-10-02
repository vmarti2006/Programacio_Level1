internal class Program
{
    private static void Main(string[] args)
    {
        // Info
        Console.WriteLine("Entra el primer nom:");
        string nom1 = Console.ReadLine()!;

        Console.WriteLine($"Entra l'edat d'en {nom1}:");
        var edat1 = Console.ReadLine()!;
        var ed_1 = int.Parse(edat1);

        Console.WriteLine("Entra el segon nom:");
        string nom2 = Console.ReadLine()!;

        Console.WriteLine($"Entra l'edat d'en {nom2}:");
        var edat2 = Console.ReadLine()!;
        var ed_2 = int.Parse(edat2);

        // Resultat
        var resultat = QuiEsElMesJove(nom1, nom2, ed_1, ed_2);
        Console.WriteLine(resultat);

        // Proces
        string QuiEsElMesJove(string nom1, string nom2, int ed_1, int ed_2)
        {
            if (ed_1<ed_2){return $"En {nom1} és més jove que en {nom2}";}
            if (ed_2<ed_1){return $"En {nom2} és més jove que en {nom1}";}
            return "Tenen la mateixa edat";
        }
;
    }
}