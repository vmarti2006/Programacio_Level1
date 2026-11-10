internal class Program
{
    private static void Main(string[] args)
    {
        // Info
        Console.WriteLine("Temperatura: ");
        var tempe = Console.ReadLine()!;
        var temperatura = float.Parse(tempe);

        Console.WriteLine("Cafes: ");
        var cafecitos = Console.ReadLine()!;
        var cafes = int.Parse(cafecitos);

        //Determina si entra o no

        var resultat = DeterminaSiEntren(temperatura, cafes);

        // Resultat
        Console.WriteLine(resultat);


        // segona part del programa
        string DeterminaSiEntren(double temperatura, int cafes)
        {
            if (temperatura > 37.5 || cafes > 5)
            {
                return "ALERTA: Àlien detectat! Tanqueu les comportes!";
            }
            return "Accés permès. Bon dia humà";
        }
;
    }
}