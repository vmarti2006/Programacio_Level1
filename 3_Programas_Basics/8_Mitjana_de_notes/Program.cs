// Demana notas

Console.Write("Nota 1: ");
var n1 = Console.ReadLine()!;
int nota1 = Int32.Parse(n1);

Console.Write("Nota 2: ");
var no2 = Console.ReadLine()!;
int nota2 = Int32.Parse(no2);

Console.Write("Nota 3: ");
var not3 = Console.ReadLine()!;
int nota3 = Int32.Parse(not3);

// Calcula

int mitjana = (nota1 + nota2 + nota3) / 3;

// Resultat
if (mitjana > 10)
{
    Console.WriteLine($"Has fet el imposible tens un {mitjana}");
}
else
{
    Console.WriteLine($"Mitjana: {mitjana}");
}