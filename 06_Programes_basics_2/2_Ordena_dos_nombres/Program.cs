// Demana Info
Console.WriteLine("Número: ");
var numero_1 = Console.ReadLine()!;
var num_1 = int.Parse(numero_1);

Console.WriteLine("Número: ");
var numero_2 = Console.ReadLine()!;
var num_2 = int.Parse(numero_2);
// cas 2
Console.WriteLine("Número: ");
var numero_3 = Console.ReadLine()!;
var num_3 = int.Parse(numero_3);

// Cas 1
//Calcula
var resultat1 = CalculaQuinVaDevant_1(num_1, num_2);

// Cas 2
// Calcula
var resultat2 = CalculaQuinVaDevant_2(num_1, num_2, num_3);


//Resultat
Console.WriteLine(resultat1);

// Cas 1
string CalculaQuinVaDevant_1(int num_1, int num_2)
{
    if (num_1 < num_2) { return $"{num_2} {num_1}"; }
    ;
    return $"{num_1} {num_2}";
}

// Cas 2

string CalculaQuinVaDevant_2(int num_1, int num_2, int num_3)
{
    // 1. num_1 es el menor, num_3 el mayor
    if (num_1 <= num_2 && num_2 <= num_3) { return $"{num_1} {num_2} {num_3}"; }

    // 2. num_1 es el menor, num_2 el mayor
    if (num_1 <= num_3 && num_3 <= num_2) { return $"{num_1} {num_3} {num_2}"; }

    // 3. num_2 es el menor, num_3 el mayor
    if (num_2 <= num_1 && num_1 <= num_3) { return $"{num_2} {num_1} {num_3}"; }

    // 4. num_2 es el menor, num_1 el mayor
    if (num_2 <= num_3 && num_3 <= num_1) { return $"{num_2} {num_3} {num_1}"; }

    // 5. num_3 es el menor, num_2 el mayor
    if (num_3 <= num_1 && num_1 <= num_2) { return $"{num_3} {num_1} {num_2}"; }

    // 6. num_3 es el menor, num_1 el mayor (este puede ser simplemente el return por defecto)
    return $"{num_3} {num_2} {num_1}";
}
;
