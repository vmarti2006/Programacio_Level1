// info 
Console.Write("Entra el número a invertir: ");
string numero_t = Console.ReadLine()!;

// Proces
char n1 = numero_t[2];
char n2 = numero_t[1];
char n3 = numero_t[0];

string numero_t2 = $"{n1}{n2}{n3}";
int n = Int32.Parse(numero_t2);

// Resultat
Console.Write($"El número invertit és: {n} ");
