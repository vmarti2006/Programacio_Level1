// intro 
int numero = 1;

// Proces

var resultat =ElsCenPrimers(numero);

// Resultat
Console.WriteLine(resultat);

string ElsCenPrimers(int numero){
    for (int i = 0; i < 100; i++)
    {
        Console.Write(numero);
        if (numero%3==0 && numero%3==5 ){Console.WriteLine("Xocolata i LLauna");}
        else if (numero%3==0){Console.WriteLine("Xocolata");}
        else if (numero%3==5 ){Console.WriteLine("LLauna");}

        numero ++;
    }
    return "Aquets son els primers 100 senars";
}