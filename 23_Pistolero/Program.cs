using System.Diagnostics.CodeAnalysis;

namespace _23_Pistolero;

class Program
{
    static void Main(string[] args)
    {
        List<string> noms = ["Ringo","Dead","Iron","Shadow"];
        List<List<int>> puntuacios = [
            [3,5,4,1],
            [4,1,3,1],
            [5,5,5,1],
            [2,5,4,1]
        ];
        
        string guañador="Cap";
        int puntuacioGuañador=0;

        for (int columna=0; columna < puntuacios[0].Count; columna++){
            var max = QuinEsElMesGranDeLaColumna(columna,puntuacios);
            var min = QuinEsElMesPetitDeLaColumna(columna,puntuacios);
            if (max+min>puntuacioGuañador){ puntuacioGuañador= max+min;guañador=noms[columna];}

        }
    }

    private static int QuinEsElMesPetitDeLaColumna(int columna, List<List<int>> puntuacios)
    {
        int gran=-1;
        if(){}
        return gran;
    }

    private static int QuinEsElMesGranDeLaColumna(int columna, List<List<int>> puntuacios)
    {
       int petit=-1;
        return petit;
    }
}