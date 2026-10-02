// Informacio
using System.Runtime.Intrinsics.X86;

Console.WriteLine("Número lleig:");
var v1 = Console.ReadLine()!;

// Traspasar
float ed = float.Parse(v1);
double d = ed - Math.Truncate(ed);

// Resultat

Console.WriteLine($"Nombre meravellós: {d}");