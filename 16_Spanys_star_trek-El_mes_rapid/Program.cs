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
        int mes_rapit=0;

        var resultat = QuiEsELMesRapid(naus,minuts,hores,mes_rapit);
    }

    public static object QuiEsELMesRapid(string[] naus,int[] minuts, int[] hores, int mes_rapit)
    {
        mes_rapit=hores[0];
        int minut_mes_rapit=minuts[0];

        string va_guañant=naus[0];

        for (int i=1; i<hores.Length;i++)
        {
            if(mes_rapit>hores[i]){
                mes_rapit=hores[i];
                minut_mes_rapit=minuts[i];
                va_guañant=naus[i];
            }
            else if (mes_rapit == hores[i])
            {
                if (minuts[i] < minut_mes_rapit)
                {
                    minut_mes_rapit=minuts[i];
                    va_guañant=naus[i];
                }
            }
            else if (minut_mes_rapit==minuts[i] && hores[i]==mes_rapit&&minuts.Length-1==i)
            {return $"Ha agut un empat enter {va_guañant} i {naus[i]}, han acabat en {mes_rapit} hores i {minut_mes_rapit} minuts ";}
        }
        return $"La cursa l'ha guanyat la nau {va_guañant} amb {mes_rapit} hores i {minut_mes_rapit} minuts";
    }
}
