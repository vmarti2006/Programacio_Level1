namespace _34_El_restaurant_de_la_reina_malvada;

class Program
{
    public struct Taula
    {
        public int cadiras {get;set;}
    }
    public struct Grup
    {
        public int gent {get;set;}
        public int temps {get;set;}
    }
    static void Main(string[] args)
    {
        List<Taula> taules = [
            new (){cadiras=2},
            new (){cadiras=5},
        ];
        List<Grup> ListaEspera = [
          new(){gent=3 , temps= 62},
          new(){gent=2 , temps= 20},
          new(){gent=4 , temps= 50},
          new(){gent=1 , temps= 20},
          new(){gent=7 , temps= 20}    
        ];

        var restultat = EntregarMesas(taules,ListaEspera);    
    }

    private static object EntregarMesas(List<Taula> taules, List<Grup> listaEspera)
    {
        int tempsp=0;
        int tempsg=0;

        Console.WriteLine($"Minut {tempsp} Hi ha una taula petita");
        Console.WriteLine($"Minut {tempsg} Hi ha una taula gran");


        for (int x=0;x<listaEspera.Count;x++){
            if (taules[0].cadiras >= listaEspera[x].gent){
                 tempsp=+listaEspera[x].temps;
                 Console.WriteLine($"Minut {tempsp} Hi ha una taula petita");
            };
            if (taules[1].cadiras >= listaEspera[x].gent){
                tempsg=+listaEspera[x].temps;
                Console.WriteLine($"Minut {tempsg} Hi ha una taula gran");

            }
            if (taules[1].cadiras <= listaEspera[x].gent)
            {Console.WriteLine("No tenim taula per a un grup tan gran");continue;}
        }

        return "";
    }
}
