// Cerca de informacio
using System.IO.Pipes;

Console.Write("Nom: ");
string n = Console.ReadLine()!;

Console.WriteLine("Any: ");
var a = Console.ReadLine()!;

// Ajunta text

string c = n+a;

// Resultat

Console.WriteLine($"Contrasenya: {c} ");