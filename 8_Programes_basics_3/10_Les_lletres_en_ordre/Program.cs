public class Program
{
    public static string MirarSiEstanEnElOrdreIndicat(string gia, string mirar)
    {
        int i =0;
        int y = 0;

        while (i<gia.Length && y<mirar.Length)
        {
            // si son iguals avanza
            if (gia[i]==mirar[y]){i++;}
            // havanza en la frase despues de comprobar
            y++;
        }
        if (i==gia.Length){return "Resultat: SI";}
        return "Resultat: NO";
    }
    public static void Main(string[] args)
    {
        // Inici
        Console.Write("Entrada: ");
        var gia = Console.ReadLine()!;

        Console.Write("Entrada: ");
        var mirar = Console.ReadLine()!;

        // Proces 

        var resultat = MirarSiEstanEnElOrdreIndicat(gia, mirar);

        //Resultat
        Console.WriteLine(resultat);
    }
}