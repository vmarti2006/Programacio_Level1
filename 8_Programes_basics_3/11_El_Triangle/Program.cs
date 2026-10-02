internal class Program
{
    public static string FesElTriangle(int num)
    {
        string punt =" x";
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine(punt);
            punt=punt+" x";
        }
        return punt;
    }
    private static void Main(string[] args)
    {
        // Info
        Console.Write("Número: ");
        var numero = Console.ReadLine()!;
        var num = int.Parse(numero);

        //Resultat
        var resultat = FesElTriangle(num);
    }
}