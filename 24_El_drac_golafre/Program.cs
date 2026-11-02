namespace _24_El_drac_golafre;

class Program
{
    static void Main(string[] args)
    {
        int [][] mapa= [
            [2, 5, 6, 8, 3],
            [9, 6, 7, 4, 6],
            [0, 3, 1, 5, 9],
            [4, 6, 7, 9, 9],
            [5, 6, 4, 8, 7] 
        ];

        var resultat= HonEsElDrac(mapa);
        
    }

    private static string HonEsElDrac(int[][] mapa)
    {
        int Filainici=-1;
        int ColumnaInici=-1;
        for(int fila = 0; fila < mapa.Length; fila++)
        {
            for(int columna = 0; columna < mapa[fila].Length; columna++)
            {
                if (mapa[fila][columna]==0){
                    Filainici=fila;
                    ColumnaInici=columna;
                    var Resultat=MiraVoltant(mapa,Filainici,ColumnaInici);
                }
            }

        }
        
        Console.WriteLine("No hi ha cap drac");
        return "";    
    }

    private static string MiraVoltant(int[][] mapa, int Filainici, int ColumnaInici)
    {

        return "";
    }
}
