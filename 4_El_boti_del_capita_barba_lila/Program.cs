// Informacio
using System.Data;

Console.WriteLine("Numro pirates: ");
var num_pir = Console.ReadLine()!;
int np = Int32.Parse(num_pir);

Console.WriteLine("Monedes d'or: ");
var num_mon = Console.ReadLine()!;
int nm = Int32.Parse(num_mon);

// Calculs

int rep = nm/np;
int capita = nm%np;

// int capita2= nm - (rep * np);

// Solucio

Console.WriteLine($"Cada pirate rebra {rep} i el capita {capita} monedes extra");