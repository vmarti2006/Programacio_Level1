internal class Program
{
    private static void Main(string[] args)
    {
        // Info
        Console.WriteLine("Entra el numero 1: ");
        var numero1 = Console.ReadLine()!;
        var num1 = int.Parse(numero1);

        Console.WriteLine("Entra el numero 2: ");
        var numero2 = Console.ReadLine()!;
        var num2 = int.Parse(numero2);

        Console.WriteLine("Entra el numero 3: ");
        var numero3 = Console.ReadLine()!;
        var num3 = int.Parse(numero3);

        Console.WriteLine("Entra el numero 4: ");
        var numero4 = Console.ReadLine()!;
        var num4 = int.Parse(numero4);

        Console.WriteLine("Entra el numero 5: ");
        var numero5 = Console.ReadLine()!;
        var num5 = int.Parse(numero5);

        // Resultat
        var resultat = QuinEsElMesGran(num1, num2, num3, num4, num5);
        Console.WriteLine(resultat);

        // Proces
        string QuinEsElMesGran(int num1, int num2, int num3, int num4, int num5)
        {
            // numero 1
            int n_mesgran = num1;
            // numero 2
            if (n_mesgran < num2) { n_mesgran = num2; }
            // numero 3
            if (n_mesgran < num3) { n_mesgran = num3; }
            // numero 4
            if (n_mesgran < num4) { n_mesgran = num4; }
            // numero 5
            if (n_mesgran < num5) { n_mesgran = num5; }
            // resultat
            return $"El número més gran és el {n_mesgran}";
        }
;
    }
}