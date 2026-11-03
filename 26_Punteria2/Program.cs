using System.Globalization;

namespace _26_Punteria2;

class Program
{
    struct participant
    {
        public string nom { get; init; }
        public int[] punts { get; set; }
    }
    static void Main(string[] args)
    {
        List<participant> participants = [
            new participant{nom="Ringo Kill", punts=[3,5,4,1]},
            new participant{nom="Dead-Eye", punts=[5,1,5,5]},
            new participant{nom="Iron Wild", punts=[4,3,5,4]},
            new participant{nom="Shadow Mac", punts=[1,1,1,1]},
        ];
        var maximPunts = 0;
        var guañador = "Ningú";

        foreach (var participant in participants)
        {
            var punts = participant.punts.Max() + participant.punts.Min();
            if (punts > maximPunts)
            {
                maximPunts = punts;
                guañador = participant.nom;
            }
        }
        Console.WriteLine($"El guañador és {guañador} amb {maximPunts} punts");

    }
}
