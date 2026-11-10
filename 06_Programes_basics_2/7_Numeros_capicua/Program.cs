internal class Program
{
    private static void Main(string[] args)
    {
        // Informacio
        Console.WriteLine("Digues el numero");
        var numero = Console.ReadLine()!;

        // Resultat
        var resultat = EsUnCapicua(numero);
        Console.WriteLine(resultat);

        // Proces
        string EsUnCapicua(string numero)
        {
            string numero_reves = $"{numero[3]}{numero[2]}{numero[1]}";
            if (numero == numero_reves){ return "El número és capicua";}
            return "El número no és capicua";
        };
    }
}