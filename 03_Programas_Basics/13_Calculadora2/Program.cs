// Informacio

Console.WriteLine();
var n1=Console.ReadLine()!;
int num1 = Int32.Parse(n1);

Console.WriteLine();
var n2=Console.ReadLine()!;
int num2 = Int32.Parse(n2);

// Suma
int s = num1 + num2;
Console.WriteLine($"{num1} + {num2 } = {s}");

// Suma
int r = num1 - num2;
Console.WriteLine($"{num1} - {num2 } = {r}");

// Suma
int m = num1 * num2;
Console.WriteLine($"{num1} x {num2 } = {m}");

// Suma
int d = num1 / num2;
int sob = num1 % num2;
Console.WriteLine($"{num1} x {num2 } = {d} i en sobra {sob}");