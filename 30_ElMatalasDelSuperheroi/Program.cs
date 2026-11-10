using System.Runtime.Serialization.Formatters;

namespace _30_ElMatalasDelSuperheroi;

class Program
{
    struct Posicio
    {
        public int filas;
        public int columnas;
    }
    static void Main(string[] args)
    {
        string[][] mapa =
        [
        [ "" , "#", "S", " ", " " ],
        [ " ", " ", " ", " ", " " ],
        [ " ", " ", "#", " ", "#" ],
        [ "#", "#", "#", " ", " " ],
        [ " ", " ", "M", " ", " " ]
        ];

        var resultat = TrobaLaS(mapa);
        Console.WriteLine(resultat);
    }

    private static string TrobaLaS(string[][] mapa)
    {
        int ColumnaS = -1;
        int FilaS = -1;
        for (int fila = 0; fila < mapa.Length; fila++)
        {
            for (int columna = 0; columna < mapa[fila].Length; columna++)
            {
                if (mapa[fila][columna] == "S") { ColumnaS = columna; FilaS = fila; }
            }
        }
        if (ColumnaS == -1 || FilaS == -1) { return "No hi ha superheroi"; }

        var resultat = ParaDondeVoy(ColumnaS, FilaS, mapa);

        return resultat;
    }

    private static string ParaDondeVoy(int columnaS, int filaS, string[][] mapa)
    {
        List<Posicio> casillasAlcanzables = [new Posicio { filas = filaS, columnas = columnaS }]; // Posicio original       

        for (int fila = filaS + 1; fila < mapa.Length; fila++) // Me situa en la fila inferior a la mia;
        {
            List<Posicio> siguientesCasillas = []; // Guardem las posicions

            foreach (Posicio pos in casillasAlcanzables) // va saltando de 1 en 1 
            {
                for (int dc = -1; dc <= 1; dc++) // me mira las 3 opciones que puedo
                {
                    int novaColumna = pos.columnas + dc;
                    int novaFila = pos.filas + 1;

                    if (novaColumna >= 0 && novaColumna < mapa[novaFila].Length)
                    { // 
                        string contingut = mapa[novaFila][novaColumna];

                        if (contingut == "M") { return "Pot caure en el matalàs"; } // en cas del matalas

                        if (contingut != "#")
                        {
                            Posicio nuevaPos = new Posicio { filas = novaFila, columnas = novaColumna };

                            // Evitamos meter posiciones repetidas
                            if (!siguientesCasillas.Contains(nuevaPos))
                            { siguientesCasillas.Add(nuevaPos); }
                        }
                    }
                }
                casillasAlcanzables = siguientesCasillas;
            }
        }
        return "No caurà en el matalàs";
    }
}
