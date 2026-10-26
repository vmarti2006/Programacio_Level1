using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace _22_Mordor;

class Program
{
    static void Main(string[] args)
    {
        string[][] mapa = [
            ["2","4","1","8"],
            ["3","1","5","6"],
            ["4","5","4","4"],
        ];

        var resultat = MiraraCadaCasellaDelMapa(mapa);
    }

    private static object MiraraCadaCasellaDelMapa(string[][] mapa)
    {
        List<string> GuardaPoscicions = [];
        for (int fila = 0; fila < mapa.Length; fila++)
        {
            for (int columna = 0; columna < mapa[0].Length; columna++)
            {
                var mitjanaFila = MitjanaFila(mapa, columna);
                var mitjanaColumna = MitjanaColumna(mapa, fila);

                var zonaperillosa = EsZonaPerillosa(mapa, columna, fila, mitjanaFila, mitjanaColumna);

                GuardaPoscicions.Add(zonaperillosa); // Me guarda las posiciones
            }
        }
        var colocaElAnillo = DondeVaElAnillo(mapa, GuardaPoscicions);
        return "";
    }

    private static string DondeVaElAnillo(string[][] mapa, List<string> guardaPoscicions)
    {

        return "";
    }

    private static string EsZonaPerillosa(string[][] mapa, int columna, int fila, double mitjanaFila, double mitjanaColumna)
    {
        int numero = Convert.ToInt32(mapa[fila][columna]);
        if (numero < mitjanaFila || numero < mitjanaColumna) { mapa[fila][columna] = "X"; }
        return $"{fila}.{columna}";
    }

    private static double MitjanaColumna(string[][] mapa, int fila)
    {
        double mitjanaColumna = 0;
        int actualF = fila;
        mitjanaColumna = (Convert.ToInt32(mapa[actualF][0]) + Convert.ToInt32(mapa[actualF][1]) + Convert.ToInt32(mapa[actualF][2])) / mapa[actualF].Length;
        return mitjanaColumna;
    }

    private static double MitjanaFila(string[][] mapa, int columna)
    {
        double mitjanaFila = 0;
        int actualC = columna;

        mitjanaFila = (Convert.ToInt32(mapa[0][actualC]) + Convert.ToInt32(mapa[1][actualC]) + Convert.ToInt32(mapa[2][actualC])) / mapa.Length;

        return mitjanaFila;
    }
}
