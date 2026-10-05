namespace _13Girar_paraules;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entrada: ");
        var frase1 = Console.ReadLine()!;

        // haces un lenth de frase i que vayada desde la ultima asta el espacio que encuentre,
        //  cuando encuenta un espacio que te lo guade en frase2 + paraula;
        string paraula = "";
        int i = 0;
        while (i < frase1.Length)
        {
            if (frase1[i] == ' ')
            {
                int final_paraula = frase1[i - 1];
            }

            int inici_paraula = 0;

            i++;
        }
        // va girant la frase 
        string frase2 = " ";
        frase2 = paraula + " " + frase2;
    }
}
