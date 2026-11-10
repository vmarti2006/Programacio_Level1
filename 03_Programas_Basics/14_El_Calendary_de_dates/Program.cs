// Obtindre dades
using System.Runtime.CompilerServices;

Console.WriteLine("Entra la data sense formatar:");
string data = Console.ReadLine()!;

// Calcul
string d =$"{data[0]}{data[1]}";
string m =$"{data[2]}{data[3]}";
string a =$"{data[4..]}";

// Resultat

Console.WriteLine($"La data és {d}/{m}/{a}");