using System.Runtime.CompilerServices;

namespace _14_Cadenes_idem;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Entra les dugues frases separades per un guio:");
        var frases = Console.ReadLine()!;

        if (frases == null) { Console.WriteLine("ERROR. Entra alguna cosa acpullo."); return; }

        var FrasesSeparas = frases!.Split("-");
        if (FrasesSeparas.Length != 2) { Console.WriteLine("ERROR. Que has entres de dues paraules"); return; }

        //Comprobar si les paraules son IDEM
        string resultat = ComprovaSiLesParaulesSonIDEM(FrasesSeparas[0], FrasesSeparas[1]);
        Console.WriteLine(resultat);
    }

    public static string ComprovaSiLesParaulesSonIDEM(string paraula1, string paraula2)
    {
        if (LengthSenseEspais(paraula1) != LengthSenseEspais(paraula2)) { return "NO"; }

        var paraula2array= paraula2.ToCharArray();
        // Mira les lletres 1 a 1

        foreach (var lletra in paraula1)
        {
            if (lletra == ' ') { continue; }
            if (EnQuinLLocEstaLaLLetra(lletra, paraula2array) == -1) { return "NO"; }
        }

        return "SI";
    }

    public static int EnQuinLLocEstaLaLLetra(char lletra, char[] paraula2)
    {
        for (int i = 0; i < paraula2.Length; i++)
        {
            char lletra2 = paraula2[i];
            if (lletra == lletra2) { return i; }
        }
        return -1;

    }

    public static int LengthSenseEspais(string paraula)
    {
        var suma = 0;
        foreach (var lletra in paraula)
        {
            if (lletra != ' ') { suma++; }
        }
        return suma;
    }
}
