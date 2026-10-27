namespace ExamenCorrecion;

class Program
{
    static bool FilaHiHaUn(int queBusco, List<List<int>> mapa, int fila)
    {
        for(int i=0; i < mapa[fila].Count; i++)
        {
            if (mapa[fila][i] == queBusco) {return true;}
        }
        return false;
    }
    static bool columnaHiHaUn(int queBusco, List<List<int>> mapa, int columna)
    {   
        for(int i=0; i<mapa.Count; i++)
        {
            if(mapa[i][columna] == queBusco) {return true;}
        }
        return false;
    }
    static void Main(string[] args)
    {
        List<List<int>> mapa = [
            [2, 4, 7, 1],
            [9, 3, 5, 0],
            [20, 3, 4, 5]
        ];
        List<string> resultat = [];

        for (var linia=0; linia<mapa.Count; linia++)
        {
            for(var columna=0; columna < mapa[linia].Count; columna++)
            {
                if(mapa[linia][columna] != 9 && mapa[linia][columna]!= 7)
                {
                    if (columnaHiHaUn(9, mapa, columna) && FilaHiHaUn(7, mapa, linia))
                    {resultat.Add($"{linia},{columna}");} 
                    else if (columnaHiHaUn(7, mapa, columna) && FilaHiHaUn(9, mapa, linia))
                    {resultat.Add($"{linia},{columna}");}
                }                
            }
        }
        Console.WriteLine(string.Join(" ", resultat));
    }
}