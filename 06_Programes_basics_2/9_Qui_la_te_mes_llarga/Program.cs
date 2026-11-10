using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        // info
        Console.WriteLine("Entra el número:");
        var paraula1 = Console.ReadLine()!;

        Console.WriteLine("Entra el número:");
        var paraula2 = Console.ReadLine()!;

        Console.WriteLine("Entra el número:");
        var paraula3 = Console.ReadLine()!;

        // reultat 
        var resultat = QuinaEsMesLLarga(paraula1, paraula2, paraula3);
        Console.WriteLine(resultat);

        //Proces

        string QuinaEsMesLLarga(string paraula1, string paraula2, string paraula3)
        {
            string lamesllarga= paraula1;
            
            if (lamesllarga.Length<paraula2.Length)
            {
                lamesllarga = paraula2;
            }
            if (lamesllarga.Length<paraula3.Length)
            {
                lamesllarga = paraula3;
            }
           
            if (paraula1.Length==paraula3.Length && paraula3.Length==paraula2.Length){return "les tres son igual de llargues";}

            return $"La paraula més llarga és {lamesllarga}";}
            
        }
    }
