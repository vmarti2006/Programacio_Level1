// Informacio

Console.WriteLine("Minuts: ");
var minuts = Console.ReadLine()!;
int mg = Int32.Parse(minuts);


// Calcul horas

int h = mg/60;

// Calcul minuts

int m = mg - (h*60);

// Resultat

Console.WriteLine($"{h} horas i {m} minuts");