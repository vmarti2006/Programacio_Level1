namespace _28_AmagarElNumero;

class Program
{
    static void Main(string[] args)
    {
        List<string> NumeroOcult = [];
        
        long[][] cadena = [
            [9,8,7,6,5,4,3,2,1,1,1,1,1,1,1],
            [2,3,4,2,3,4,2,3,4,2,3,4,2,7,8],
            [8,1,8,1,8,1,9,1,1,1,1,2,1,1,1]
        ];

        var resultat = RecorreLaLLista(cadena, NumeroOcult);
    }

    private static object RecorreLaLLista(long[][] cadena, List<string> numeroOcult)
    {
        for (int fila = 0; fila < cadena.Length; fila++)
        {
            // Inicializamos por cada fila
            int UltimaColumna = -1;
            int mesGran = -1;

            // Recorremos todas las columnas de la fila actual
            for (int columna = 0; columna < cadena[fila].Length-1; columna++)
            {
                if (mesGran < cadena[fila][columna])
                {
                    mesGran = (int)cadena[fila][columna];
                    UltimaColumna = columna;
                }
            }

            // Calculamos el segundo número a la derecha de UltimaColumna
            int mesGran2 = CalculaElSegonMesGran(fila, UltimaColumna, cadena);

            // Guardamos la combinación de los dos números encontrados
            numeroOcult.Add($"{mesGran}{mesGran2}");
        }

        Console.WriteLine("Els numeros ocults son: ");
        for (int i = 0; i < numeroOcult.Count; i++)
        {
            Console.WriteLine(numeroOcult[i]);
        }

        return "";
    }

    private static int CalculaElSegonMesGran(int fila, int ultimaColumna, long[][] cadena)
    {
        int mesGran = -1;

        // Si la UltimaColumna es la última de la fila, no hay columnas a la derecha
            for (int columna2 = ultimaColumna + 1; columna2 < cadena[fila].Length; columna2++)
            {
                if (mesGran < cadena[fila][columna2])
                {
                    mesGran = (int)cadena[fila][columna2];
                }
        }

        return mesGran;
    }
}
