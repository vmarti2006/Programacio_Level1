// Inici
Console.WriteLine("Hora actual:");
var hora_acrual = Console.ReadLine()!;
int ha = Int32.Parse(hora_acrual);

Console.WriteLine("Hora a incrementar:");
var hora_incremental = Console.ReadLine()!;
int hi = Int32.Parse(hora_incremental);

// Calculs

int hf = ha + hi;
if (hf > 12)
{
    hf = hf-12;
}

// Resultat
Console.WriteLine($"D'aqui a {hi} hores seran les {hf}");