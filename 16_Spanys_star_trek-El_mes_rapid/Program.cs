using System.Runtime.CompilerServices;

namespace _15_Spanys_star_trek_El_mes_rapid;

class Program
{
    static void Main(string[] args)
    {
        string[] naus = [
            "ES001 El Cid",
            "NCC-1701 USS Enterprise",
            "Andromeda",
            "Nostromo",
            "Galàctica"
];
        int[] hores =[12,8,11,13,9];
        int[] minuts = [45,32,87,21,76];

        var resultat = QuiEsELMesRapid(naus,minuts,hores);
        
        Console.WriteLine(resultat);
    }

    public static string QuiEsELMesRapid(string[] naus, int[] minuts, int[] hores)
    {
        // Convertimos el tiempo de la primera nave a minutos totales para comparar fácilmente
        int tempsMinim = (hores[0] * 60) + minuts[0];
        string guanyador = naus[0];
        int horaGuanyador = hores[0];
        int minutGuanyador = minuts[0];

        bool hiHaEmpat = false;
        string nauEmpatada = "";

        for (int i = 1; i < naus.Length; i++)
        {
            int tempsActual = (hores[i] * 60) + minuts[i];

            if (tempsActual < tempsMinim)
            {
                // Encontramos un tiempo más rápido: actualizamos la nave ganadora
                tempsMinim = tempsActual;
                guanyador = naus[i];
                horaGuanyador = hores[i];
                minutGuanyador = minuts[i];
                hiHaEmpat = false; // Se rompe cualquier empate previo
            }
            else if (tempsActual == tempsMinim)
            {
                // Detectamos empate
                hiHaEmpat = true;
                nauEmpatada = naus[i];
            }
        }

        if (hiHaEmpat)
        {
            return $"Hi ha hagut un empat entre {guanyador} i {nauEmpatada}, han acabat en {horaGuanyador} hores i {minutGuanyador} minuts.";
        }

        return $"La cursa l'ha guanyat la nau {guanyador} amb {horaGuanyador} hores i {minutGuanyador} minuts.";
    }
}
