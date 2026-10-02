public class Program
{
    public static string EsMultipleDeDeu(int num)
        {
            // No es multiple de 10
            if (num % 10 != 0) { return "INCORRECTE"; }

            int originals = num;
            int elev = 0;

            while (num%10==0&&num>1)
            {
                num/=10;
                elev++;
                   
            }
            int multi=num;

            return $"CORRECTE {multi} per 10 elvat a {elev} es {originals}";
        }
    public static void Main(string[] args)
    {
        // info
        Console.Write("Entra un múltiple de 10: ");
        var numero = Console.ReadLine()!;
        var num = int.Parse(numero);
        

        var resultat = EsMultipleDeDeu(num);

        Console.WriteLine(resultat);
    }
}