namespace _32_PirataTramunt;

class Program
{
    public struct Barco
    {
        public string pais { get; set; }
        public int[] encriptat { get; set; }
        public int numero_secret { get; set; }
    }
    static void Main(string[] args)
    {
        Barco[] flotas = [
            new Barco{pais="Francès",encriptat=[6,6,6,6,6,6,3,3,3,3,4,4,4,4],numero_secret=-1}, // espera 64 
            new Barco{pais="Anglès",encriptat=[3,4,3,3,3,5,3,3,3],numero_secret=-1}, // espera 33
            new Barco{pais="Espanyol",encriptat=[1,9,9,9,9,9,9,9,9,9,3,3,3,3,4,4,4,4,1,1],numero_secret=-1} // espera 194
        ];

        var resultat = QuinEstaMesLLuny(flotas);
        Console.WriteLine(resultat);
    }
    private static string QuinEstaMesLLuny(Barco[] flotas)
    {
        for (int flota = 0; flota < flotas.Length; flota++){ // Me va mirando los barcos 

            Console.WriteLine($"Pais: {flotas[flota].pais}"); // Te dice el pais

            var resultat = MirarLaDistancia(flota, flotas);

            if (resultat==-1){return"Algo esta mal en 'MirarLaDistancia'";} 

            flotas[flota].numero_secret = resultat; // Te cambia el numero secreto por el resultado
        }

        for (int y = 0; y < flotas.Length; y++){ // Me da los resultados 

            Console.WriteLine($" - un vaixell  {flotas[y].pais} a {flotas[y].numero_secret} nussos");
        }

        return "";
    }
    private static int MirarLaDistancia(int flota, Barco[] flotas)
    {
        int resultat = -1;
        int repeticions= 0;

        for (int x = 0; x < flotas[flota].encriptat.Length; x++){ // Me va mirando los arrays
            
        }

        return resultat;
    }
}
