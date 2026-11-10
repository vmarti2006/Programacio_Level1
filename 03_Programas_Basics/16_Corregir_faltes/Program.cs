// Inici
Console.WriteLine("Nom: ");
string nom = Console.ReadLine()!;
Console.WriteLine("Nom: ");
string cognom = Console.ReadLine()!;

//Funcio
string n = char.ToUpper(nom[0]) + nom[1..];
string c = char.ToUpper(cognom[0]) + cognom[1..];

string j = n + " " + c;

Console.WriteLine($"Nom Complet: {j}");
