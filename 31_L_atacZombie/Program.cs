namespace _31_L_atacZombie;

class Program
{
    public struct Bala
    {
        public string tipus { get; set; }
        public bool esta { get; set; }
    }
   public struct Monstre
    {
        public string tipus { get; set; }
        public string afecta { get; set; }
    }
    static void Main(string[] args)
    {
        // LListes
        Bala[] cargador = [
            new Bala {tipus= "plata",esta=true},
            new Bala {tipus= "all",esta=true},
            new Bala {tipus= "normal",esta=true},
            new Bala {tipus= "normal",esta=true},
            new Bala {tipus= "plata",esta=true},
            new Bala {tipus= "plata",esta=true},
            new Bala {tipus= "all",esta=true}
        ];
        List<Monstre> horda = [
            new Monstre {tipus="vampir", afecta="all"},
            new Monstre {tipus="zombi", afecta="normal"},
            new Monstre {tipus="zombi", afecta="normal"},
            new Monstre {tipus="vampir", afecta="all"},
            new Monstre {tipus="homes llop", afecta="plata"}
        ];

        var resultat = MirraLaBalaPerCadaMonstre(cargador,horda);

        Console.WriteLine(resultat);
    }

    private static string MirraLaBalaPerCadaMonstre(Bala[] cargador, List<Monstre> horda)
    {        

        for (int defensa=-1; defensa<=cargador.Length; defensa++)
        {
            if (horda.Count<0){return "Has guañat";} // Guañya si no queda ningu a la horda

            if (defensa == cargador.Length){defensa=0;Console.WriteLine($"Seguent bala, aquesta no li fara res"); }// Cuando acaba la tonda 
            
            if (horda[0].afecta == cargador[defensa].tipus){ // Si es la bala que necesita 
               if (cargador[defensa].esta == false){ // recarga
                    cargador[defensa].esta = true;
                    
                    Console.WriteLine($"Has recarregat la bala de {cargador[0].tipus}");

                }

                Console.WriteLine($"Has matat el {horda[0].tipus}");

                horda.RemoveAt(0); // Luego mata
                cargador[defensa].esta = false; // Se queda sin bala
            }

            Console.WriteLine("Seguent bala");
        }
            return "Has perdut";        
    }
}
