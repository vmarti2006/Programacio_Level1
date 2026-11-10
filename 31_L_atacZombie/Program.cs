using System.Reflection.Metadata.Ecma335;

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
            new Monstre {tipus="homes llop", afecta="plata"},
            new Monstre {tipus="vampir", afecta="all"},
            new Monstre {tipus="homes llop", afecta="plata"},
            new Monstre {tipus="homes llop", afecta="plata"},
            new Monstre {tipus="homes llop", afecta="plata"}

        ];

        var resultat = MirraLaBalaPerCadaMonstre(cargador,horda);

        Console.WriteLine(resultat);
    }

    private static string MirraLaBalaPerCadaMonstre(Bala[] cargador, List<Monstre> horda)
    {        
        int recarrega =1;
        for (int defensa=0; defensa<=cargador.Length; defensa++)
        {
            if (!horda.Any()){return "Has guañat";} // Guañya si no queda ningu a la horda

            if (defensa == cargador.Length){defensa=0;Console.WriteLine($"Seguent bala, aquesta no li fara res"); }// Cuando acaba la tonda 
            
            if (horda[0].afecta == cargador[defensa].tipus){ // Si es la bala que necesita 
               if (cargador[defensa].esta == false && recarrega>=1){ // recarga
                    cargador[defensa].esta = true;

                    recarrega--;

                    Console.WriteLine($"Has recarregat la bala de {cargador[0].tipus}");
                }
                else if(cargador[defensa].esta == false && recarrega==0){return "Has mort, no tens per recarrega";}

                Console.WriteLine($"Has matat el {horda[0].tipus} utilitzan una bala {cargador[defensa].tipus}");
                Console.WriteLine("");

                horda.RemoveAt(0); // Luego mata
                cargador[defensa].esta = false; // Se queda sin bala
            }

            Console.WriteLine("Seguent bala");
        }
            return "";        
    }
}
