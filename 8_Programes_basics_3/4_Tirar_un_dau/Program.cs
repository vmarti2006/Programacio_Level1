using System.Diagnostics.Contracts;

string TirarElDau(int numero, int contador, int tirades)
{
    Random r = new Random();
    while (contador <100)
    {
        // rnaodm 1 al 6
        numero=r.Next(1,6);
        contador =contador + numero;
        Console.WriteLine($"Tirar el dau: {numero}");
        tirades++;
    };

    return $"He hagut de tirar el dau {tirades} vegades";
}


// Info

// proces

int numero = 0;
int contador =0;
int tirades =0;
// Resultat
string resultat = TirarElDau(numero, contador, tirades);
Console.WriteLine(resultat);