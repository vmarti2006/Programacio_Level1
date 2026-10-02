internal class Program
{
    private static void Main(string[] args)
    {
        // Informacio
        Console.WriteLine("Entra el número: ");
        var numero = Console.ReadLine()!;
        var num = int.Parse(numero);

        // resultat
        var resultat = DiguemSiEsParellOSenar(num);
        Console.WriteLine(resultat);

        //Proces
        string DiguemSiEsParellOSenar(int num)
        {
            if (num % 2 == 0) { return "El número és parell"; }
            else if (num % 2 != 0) { return "El número és senar"; }
            return "No es un numero";
        }
        ;
    }
}