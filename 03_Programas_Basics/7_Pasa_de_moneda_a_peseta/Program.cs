
using System.Reflection;
using System.Runtime.InteropServices;
//cuantos euros
Console.WriteLine("Cuantos euros tienes? ");
var e = Console.ReadLine();
int euro = Int32.Parse(e);
float pesetaxeuro = 166.39F;

// Calculo
double pesetas = euro * pesetaxeuro;

// Resultado
Console.WriteLine($"Tienes {pesetas} pesetas ");