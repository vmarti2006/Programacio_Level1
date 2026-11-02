namespace _25_Dusterwater_Corral;

class Program
{
    static void Main(string[] args)
    {
        string[][] mapa = [ // 1. De tot hem de crear una estructura mapa.
            [".", ".", "v", "v", "."],
            [".", ">", ".", ".", "."],
            [".", ".", ".", ".", "<"],
            [".", ".", ".", ".", "."],
            ["^", ".", ".", "<", "^"]
        ];

        var resultat = ReroregutDelMapa(mapa);
    }

    private static string ReroregutDelMapa(string[][] mapa)
    {
        // 2. Un cop tenim el mapa fem es recorri cada casella del mapa
        int fila = -1; int columna = -1;
        for (fila = 0; fila < mapa.Length; fila++)
        {
            for (columna = 0; columna < mapa[fila].Length; columna++)
            {

                // 3. Miras para donde dispara el cauboy  
                if (mapa[fila][columna] == "^") // dispara arriba
                {
                    var cambiado = CambiamosHacciaArriba(mapa, fila, columna);
                }
                else if (mapa[fila][columna] == "v") // dispara abajo
                {
                    var cambiado = CambiamosHacciaAbajo(mapa, fila, columna);
                }
                else if (mapa[fila][columna] == ">") // dispara a la derecha
                {
                    var cambiado = CambiamosHacciaDerecha(mapa, fila, columna);
                }
                else if (mapa[fila][columna] == "<") // dispara a la izquierda
                {
                    var cambiado = CambiamosHacciaIzquierda(mapa, fila, columna);
                }
                else if (mapa[fila][columna] == ".")
                {
                    continue;
                }

            }
        }

        var salvats = ComAQuedatElMapa(mapa, fila, columna);
        return "";
    }

    // 4. Cambias de simbulo todas las casillas a las que apunta el cauboy
    private static string CambiamosHacciaIzquierda(string[][] mapa, int fila, int columna)
    {
        while (columna != -1)
        {
            if (mapa[fila][columna] == "." || mapa[fila][columna] == "-")
            { mapa[fila][columna] = "-"; }

            columna--;
        }
        return "";
    }

    private static string CambiamosHacciaDerecha(string[][] mapa, int fila, int columna)
    {
        while (columna != mapa[fila].Length)
        {
            if (mapa[fila][columna] == "." || mapa[fila][columna] == "-")
            { mapa[fila][columna] = "-"; }


            columna++;
        }
        return "";
    }

    private static string CambiamosHacciaAbajo(string[][] mapa, int fila, int columna)
    {
        while (fila != mapa.Length)
        {
            if (mapa[fila][columna] == "." || mapa[fila][columna] == "-")
            { mapa[fila][columna] = "-"; }

            fila++;
        }
        return "";
    }

    private static string CambiamosHacciaArriba(string[][] mapa, int fila, int columna)
    {
        while (fila != -1)
        {
            if (mapa[fila][columna] == "." || mapa[fila][columna] == "-")
            { mapa[fila][columna] = "-"; }

            fila--;
        }
        return "";
    }

    // 5. Recorres otra vez el mapa entero para mirar cuales son las casillas buenas i las guardas
    private static string ComAQuedatElMapa(string[][] mapa, int fila, int columna)
    {
        List<string> salvats = [];
        for (fila = 0; fila < mapa.Length; fila++)
        {
            for (columna = 0; columna < mapa[fila].Length; columna++)
            {
                if (mapa[fila][columna] == ".") { salvats.Add($"{fila},{columna}"); }
            }
        }

        foreach (string[] fila2 in mapa)
        {
            // Recorremos cada celda dentro de la fila
            foreach (string celda in fila2)
            {
                Console.Write(celda + " "); // Imprime la celda seguida de un espacio
            }
            Console.WriteLine(); // Salto de línea al terminar cada fila
        }
        if (salvats.Count >= 1)
        {
            Console.WriteLine("Les Posicions correctes son: ");
            for (int x = 0; x < salvats.Count; x++) { Console.WriteLine($"- {salvats[x]}"); }
        }
        else Console.WriteLine("No hi ha posicio correcte.");
        return "";
    }
}



