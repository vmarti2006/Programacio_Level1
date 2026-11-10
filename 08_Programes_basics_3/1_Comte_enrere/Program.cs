// Informacio
using System.Runtime.CompilerServices;

int deu = 10;

// Proces
var resultat = ComteEnrrere(deu);
// Resultat
Console.WriteLine(resultat);

string ComteEnrrere(int deu)
{
    for (int i= 0; i < 10; i++)
    {
        Console.WriteLine(deu);
        deu--;
    }
    return"Despege";
}
;