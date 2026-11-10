// Intro 
Console.WriteLine("Paraula:");
string paraula = Console.ReadLine()!;

// Trabajo
int u = paraula.Length -1;
int x = paraula.Length;
if (x % 2 ==0)
{
var p_i_p = $"{paraula[0]} * {paraula[u]}";
// Resultado
Console.WriteLine($"Resultat: {p_i_p}");
}

else
{

int m = u/2;

var p_i_ip= $"{paraula[0]} {paraula[m]} {paraula[u]}";

// Resultado
Console.WriteLine($"Resultat: {p_i_ip}");
}