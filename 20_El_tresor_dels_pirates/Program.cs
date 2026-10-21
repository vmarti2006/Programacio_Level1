namespace _20_El_tresor_dels_pirates;

class Program
{
    static void Main(string[] args)
    {
        string[][] mapa = [
            [".",".",".",".",".",".","#"],
            [".",".","#",".",".",".","."],
            [".",".",".",".",".",".","."],
            [".",".",".",".","T",".","."],
            [".","#",".",".",".",".","."],
            [".",".",".",".",".","#","."]
        ];

        var resultat = HonEsElTresor(mapa);

        Console.WriteLine(resultat);
    }

    private static string HonEsElTresor(string[][] mapa)
    {
        for (int fila = 0; fila < mapa.Length; fila++) // va pasant fila per fila 
        {
            for (int columna = 0; columna < mapa[fila].Length; columna++)// va pasando columna por columna
            {
                if (mapa[fila][columna] == "T")
                { return $"Tresor trobat a: ({fila},{columna})\n" + $"Distància al límit superior: {fila}\n" + $"Distància al límit esquerre: {columna}"; }
            }
        }
        return "T'han enredat, no hi ha cap tresor";
    }
}
