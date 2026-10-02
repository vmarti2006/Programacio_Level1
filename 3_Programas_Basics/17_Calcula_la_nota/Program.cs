// introduccio
Console.WriteLine("Nota de pràctiques: ");
var not_prac = Console.ReadLine()!;
var np = float.Parse(not_prac);

Console.WriteLine("Nota de  l'examen: ");
var not_exa = Console.ReadLine()!;
var ne = float.Parse(not_exa);

// Calcul
float prob = (np*0.8F) + (ne*0.2F);
int final = (int)prob;

// Resultat

Console.WriteLine($"La nota final és {prob} o sigui un {final}");