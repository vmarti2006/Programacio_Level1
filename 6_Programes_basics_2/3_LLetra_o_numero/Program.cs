// Info
Console.WriteLine("Caràcter: ");
var caracter = Console.ReadLine()!;
char car = char.Parse(caracter);

// Proces
string resultat = IdentificaComEsElCaracter(car);

// Resultat
Console.WriteLine(resultat);

// Codi 
string IdentificaComEsElCaracter(char car)
{
    // Numeros
    if (car>=1 && car<=9){return "Numero";}
    // LLetras minuscula
    else if (car>='a' && car<='z'){return "Minúscula";}
    // LLetras majusculas
    else if (car>='A' && car<='Z'){return "Majúscula";}

    return "No és ni letra ni número";
}
