namespace Girad;

public class Program
{
    public static void Main(string[] args)
    {
        // Demanar les dades
        Console.Write("Numero: ");
        var numero =Console.ReadLine()!;

        // GIrar el numero
        string resultat = GirarNumero(numero);

        // Resultat
        Console.WriteLine(resultat);
    }

    public static string GirarNumero(string numero)
    {
        var resultat="";
        // 1 numero
        if (numero.Length==1)
        {
            return numero;
        }
        if (numero[0] == numero[1])
        {
            return numero;
        }

        var NouNumero = girarLaXifra(numero);

        while(NouNumero!=numero)
        {
            resultat += $", {numero}";
            
        }



        return resultat;
    }
}
