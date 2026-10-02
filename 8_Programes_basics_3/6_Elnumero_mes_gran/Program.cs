// info
Console.Write("quants nombres hi haura: ");
var repeticions=Console.ReadLine()!;
var rep = Int32.Parse(repeticions);
int NumeroMesGran =0;

//Proces
for(int i = 0; i < rep; i++)
{
    // Fa que es repeteixi el proces
    Console.Write("número: ");
    var numero=Console.ReadLine()!;
    var num=Int32.Parse(numero);

    // Ecectual el cambi cuan es necesita
    if (NumeroMesGran<num){NumeroMesGran=num;}
}

// resultat
Console.WriteLine($"El número més gran és el {NumeroMesGran}");
