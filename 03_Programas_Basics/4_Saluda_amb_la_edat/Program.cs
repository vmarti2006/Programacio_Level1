// NOmbre
using System.Data.Common;
using System.Runtime.InteropServices.Marshalling;

Console.WriteLine("Como te llamas? ");
string nom = Console.ReadLine();

// Edad
Console.WriteLine("De que año eres? ");
var año_n = Console.ReadLine();
int naixement = Int32.Parse(año_n);

// Calcula edad
int año_actual = DateTime.Now.Year;

int edad = año_actual - naixement;

// Resultat 
 
 Console.Write($"Hola {nom} ya tens {edad} ");