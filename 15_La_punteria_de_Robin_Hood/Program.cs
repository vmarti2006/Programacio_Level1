using Microsoft.CSharp.RuntimeBinder;

namespace _15_La_punteria_de_Robin_Hood;

class Program
{
    public static void Main(string[] args)
    {
        // Dades basiques inicials
        Console.WriteLine("Posa la cadena de RIC i REC");
        var cadena = Console.ReadLine();

        string resultat = CapaOnEsMouLaDiana(cadena!);

        Console.WriteLine(resultat);
    }
    public static string CapaOnEsMouLaDiana(string cadena)
    {
        // dades de aquesta que necesito
        int Esquerra = 0;
        int Dreta = 0;
        int resta = 0;

        foreach (var lletra in cadena)
        {
            if (lletra == 'I') { Dreta++; }
            else if (lletra == 'E') { Esquerra++; }
        }

        // Resultat
        if (Esquerra < Dreta) { resta = Dreta - Esquerra; return $"{resta} a la dreta"; }
        else if (Esquerra > Dreta) { resta = Esquerra - Dreta; return $"{resta} a la esquerra"; }
        else return "No s'ha mogut";
    }
}
