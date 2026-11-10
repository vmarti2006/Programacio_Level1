namespace _29_Rapunzel;

class Program
{
    static void Main(string[] args)
    {
        List<string> princeps = ["Bernart", "Arnau", "Guillem", "Guerau", "Hug"];
        int y = -1;

        while (y != 0)
        {
            int div = princeps.Count * 20 / 100;
            int cuantos_quedan = princeps.Count;

            // Parte 1: 20% no es 0
            if (div >= 1)
            {
                var resultat = RapuncelTalla(princeps, div);
            }
            // Parte 2: se quita el de delante del segundo par
            else if (div == 0 && cuantos_quedan % 2 == 0)
            {
                princeps.RemoveAt(1);
            }
            // Parte 3: se quita el de enmedio si es impar
            else if (div == 0 && cuantos_quedan % 2 != 0)
            {
                princeps.RemoveAt(cuantos_quedan / 2);
            }
            // Guanyador
            else if (cuantos_quedan == 2)
            {
                princeps.RemoveAt(0);
                break;
            }
            else if(cuantos_quedan == 1) break;
        }
        Console.WriteLine($"Ha guanyat el Princep {princeps[0]}");
    }

    private static string RapuncelTalla(List<string> princeps, double atallat)
    {
        for (int x = 0; x < atallat; x++)
        {
            princeps.RemoveAt(princeps.Count - 1);
        }
        return $"Rapuncel talla {atallat} candidat dels de derrera ";
    }
}
