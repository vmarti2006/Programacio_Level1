namespace _13Girar_paraules;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entrada: ");
        var frase1 = Console.ReadLine()!;

        // haces un lenth de frase i que vayada desde la ultima asta el espacio que encuentre,
        //  cuando encuenta un espacio que te lo guade en frase2 + paraula;
        for (int i = frase1.Length - 1; 0 <= i; i--)
        {
            if (frase1[i] == ' ' || i == 0)
            {
                int inicio = (i == 0) ? i : i + 1;
                for (int j = inicio; j < frase1.Length; j++)
                {
                    if (frase1[j] == ' ')
                    {
                        break;
                    }
                    Console.Write(frase1[j]);
                }
                if (i > 0)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
