// Info
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Entra el número: ");
        var numero1 = Console.ReadLine()!;
        var num1 = int.Parse(numero1);

        Console.WriteLine("Entra el número: ");
        var numero2 = Console.ReadLine()!;
        var num2 = int.Parse(numero2);

        Console.WriteLine("Entra el número: ");
        var numero3 = Console.ReadLine()!;
        var num3 = int.Parse(numero3);

        // resultat 
        var resultat = CuinEsElMesProper(num1, num2, num3);
        Console.WriteLine(resultat);

        // Proces
        string CuinEsElMesProper(int num1, int num2, int num3)
        {
            // Preparacio
            int suma1 = num1 + num2;
            int suma2 = num1 + num3;

            // Quin es 
            if (suma1 < suma2) { return $"El número més proper a {num1} és el {num2}"; }
            else if (suma1 > suma2) { return $"El número més proper a {num1} és el {num3}"; }
            return $"Tots dos números són igual de propers a {num1}";
        }
;
    }
}