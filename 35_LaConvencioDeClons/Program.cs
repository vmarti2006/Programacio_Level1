namespace _35_LaConvencioDeClons;

class Program
{
    static void Main(string[] args)
    {
       List<List<string>> clones = [
            ["a", "b", "a", "c", "d"],
            ["b", "b", "c", "c", "e"],
            ["a", "c", "b", "c", "f"],
            ["d", "b", "c", "e", "e"],
            ["a", "d", "e", "f", "f"]
        ];

        for (int fila = 0;fila<clones.Count;fila++){ 
            for (int columna = 0; columna < clones[fila].Count; columna++){
                var contador = MiraAltrededor(fila,columna,clones); // Me cuenta cunatos tengo alrededor
                var resultat = MeborraIMuebeAlDearribaParabajo(fila,columna,contador,clones); // Me borra si tengo mas de 2 i acomota la lista 
            }
        }

        Console.WriteLine("Posició final dels assistents:");
        for (int fila = 0; fila < clones.Count; fila++)
        {
            for (int columna = 0; columna < clones[fila].Count; columna++)
            {
                Console.Write(clones[fila][columna] + " ");
            }
            Console.WriteLine();
        }
    }

    private static int MiraAltrededor(int F1la, int C0lumna, List<List<string>> clones)
    {
        int mifila = F1la;
        int micolumna = C0lumna;
        int contador = -1;
        
        for (int fila= mifila-1;fila<=mifila+1;fila++){
            if (fila < 0 || fila >= clones.Count) { continue; }
            else
            {
                for (int columna = micolumna - 1; columna <= micolumna + 1; columna++){
                   if (columna < 0 || columna >= clones[fila].Count) { continue; }
                    else
                    {
                        if (clones[fila][columna]==clones[mifila][micolumna]){
                            contador++;
                        }
                    }
                }
            }
        }

        return contador;
    }

    private static string MeborraIMuebeAlDearribaParabajo(int f1la, int c0lumna, int contador, List<List<string>> clones)
    {
        int fila = f1la-1;

        if (contador>=2){
            if (f1la == 0) {clones[f1la][c0lumna] = " ";}
            else
            {
                // Bucle que sube desde la fila borrada hacia arriba bajando cada elemento una posición
                for (int f = f1la; f > 0; f--)
                {
                    clones[f][c0lumna] = clones[f - 1][c0lumna];
                }
                // La posición de arriba del todo (fila 0) queda vacía
                clones[0][c0lumna] = " ";
            }  
        }
        return"";
    }
}
