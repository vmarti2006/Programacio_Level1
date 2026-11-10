// intro 
int senars = 1;

// Proces

var resultat =ElsCenPrimers(senars);

// Resultat
Console.WriteLine(resultat);

string ElsCenPrimers(int senars){
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine(senars);
        senars+=2;
    }
    return "Aquets son els primers 100 senars";
}
