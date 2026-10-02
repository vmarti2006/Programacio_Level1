// Info 
Console.Write("Metres: ");
var metres = Console.ReadLine()!;
int m = Int32.Parse(metres);
float peus = 3.28084F;

// Calculo
float p = m*peus;

// Resultat
Console.WriteLine($"{m} metres es igual a {p} peus");