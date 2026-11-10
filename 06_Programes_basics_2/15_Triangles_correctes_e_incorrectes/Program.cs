// Info
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;

Console.WriteLine("Costat 1: ");
var costat_1 = Console.ReadLine()!;
var cost1 = float.Parse(costat_1);

Console.WriteLine("Costat 2: ");
var costat_2 = Console.ReadLine()!;
var cost2 = float.Parse(costat_1);

Console.WriteLine("Costat 1: ");
var costat_3 = Console.ReadLine()!;
var cost3 = float.Parse(costat_3);

// resultat
var resultat = CalcualTrinagles(cost1,cost2,cost3);
Console.WriteLine(resultat);

// Proces
string CalcualTrinagles(float cost1, float cost2, float cost3)
{
    // Sumas
    float c1c2= cost1+cost2;
    float c1c3= cost1+cost3;
    float c3c2= cost3+cost2;
    
    // es un triangle?
    if (c1c2<cost3 ||c1c3<cost2||c3c2<cost1)
    {
        if (cost1==cost2||cost2==cost3||cost1==cost3) {return"El triangle és isòsceles.";}
        if (cost1==cost2&&cost2==cost3){return"El triangle és equilater.";}
        return "El triangle és escalè.";
    }

    return"Aquest triangle no és correcte";
}
;