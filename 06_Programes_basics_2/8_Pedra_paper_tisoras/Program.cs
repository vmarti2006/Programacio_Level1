using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        // Informacio
        Console.WriteLine("selecciona jugador 1: ");
        string jugador1 = Console.ReadLine()!;

        Console.WriteLine("selecciona jugador 2: ");
        string jugador2 = Console.ReadLine()!;

        // Resultat
        var resultat = CalculaQuiGuanya(jugador1, jugador2);
        Console.WriteLine(resultat);

        // Proces
        string CalculaQuiGuanya(string jugador1, string jugador2)
        {
            // guanya jugador 1
            if (jugador1 == "pedra" && jugador2=="tisores"){return "Jugador 1 guanya";}
            if (jugador1 == "tisores" && jugador2=="pape"){return "Jugador 1 guanya";}
            if (jugador1 == "pape" && jugador2=="pedra"){return "Jugador 1 guanya";}
            
            // Guanya jugador 2
            if (jugador2 == "pedra" && jugador1=="tisores"){return "Jugador 2 guanya";}
            if (jugador2 == "tisores" && jugador1=="pape"){return "Jugador 2 guanya";}
            if (jugador2 == "pape" && jugador1=="pedra"){return "Jugador 2 guanya";}
           
            // Empat
            return "No guanya ningú";

        }
        ;
    }
}