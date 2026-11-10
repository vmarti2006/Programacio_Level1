string DesmontarElNumero(int num, int suma1)
{
    int suma=suma1;

    for (int i=0; i<=num;i++)
    {
        suma +=i;
    }
    return $"La suma es {suma}";
}

// info
Console.Write("Numero: ");
var numero =Console.ReadLine()!;
var num= Int32.Parse(numero);
int suma1=0;
//
string resultat = DesmontarElNumero(num,suma1);

Console.WriteLine(resultat);