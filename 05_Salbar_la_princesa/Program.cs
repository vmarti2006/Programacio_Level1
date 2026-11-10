// Introduccio
Console.Write("Quants carros ha de preparar? ");
var carros = Console.ReadLine()!;
var c = Int32.Parse(carros);

Console.Write("Quin és el preu d'una ferradura? ");
var ferralla = Console.ReadLine()!;
var f = Int32.Parse(ferralla);

Console.Write("Quin és el preu d'un sac de menjar? ");
var sacs = Console.ReadLine()!;
var s= Int32.Parse(sacs);

// Calcul
int resultat = c*(f*4) + (s*2)*c;

Console.WriteLine($"Cost total de preparar els carros: {resultat} euros");