using System.ComponentModel;

namespace _18_Spanish_Star_Trek_Salvant_els_àliens;

class Program
{
    static void Main(string[] args)
    {
        int []ADN=[5,3,7,2,9,12];

        var resultat = OstasComoPanes(ADN);

        if (resultat ==0){Console.WriteLine($"{resultat} hòsties - l’ADN ja és ascendent");}
        else {Console.WriteLine($"{resultat} hòsties");}
    }

    public static int OstasComoPanes(int[] ADN)
    {
        int hostias=0;
        int anterior=ADN[0];

        for (int i=0;i<ADN.Length;i++)
        {
        if(ADN[i]<anterior){hostias=anterior-ADN[i];}
        else anterior=ADN[i];
        }
        return hostias;
    }
}
