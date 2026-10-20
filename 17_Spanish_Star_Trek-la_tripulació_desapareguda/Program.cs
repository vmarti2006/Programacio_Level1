namespace _17_Spanish_Star_Trek_la_tripulació_desapareguda;

class Program
{
    static void Main(string[] args)
    {
        string[] LListaNomsOriginal = [
            "Alejandro Martínez López",
            "Carmen Sánchez Fernández",
            "María Dolores Jiménez Castro",
            "Javier García Rodríguez",
            "Lucía Pérez Gómez",
            "Antonio Ruiz Navarro",
            "Manuel Ortega Vargas"
        ];

        string[] LListaNomsFaltants = [
            "Lucía Pérez Gómez",
            "María Dolores Jiménez Castro",
            "Manuel Ortega Vargas",
            "Javier García Rodríguez",
            "Alejandro Martínez López"
        ];

        var resultat = QuinsNomsFalten(LListaNomsOriginal,LListaNomsFaltants);

        Console.WriteLine(resultat);
    }

    private static object QuinsNomsFalten(string[] lListaNomsOriginal, string[] lListaNomsFaltants)
    {
        string nom_no_esta = "";

        for (int estan = 0; estan < lListaNomsOriginal.Length; estan++)
        {
            bool trobat = false;

            for (int faltants = 0; faltants < lListaNomsFaltants.Length; faltants++)
            {
                if (lListaNomsOriginal[estan] == lListaNomsFaltants[faltants])
                {
                    trobat = true; 
                }
            }

            if (trobat == false)
            {
                nom_no_esta += "\n - " + lListaNomsOriginal[estan];
            }
        }

        return $"Han desaparegut:{nom_no_esta}";
    }
}
