using System.Runtime.Serialization.Formatters;

namespace _32_PirataTramunt;

class Program
{
    public struct Barco
    {
        public string Pais { get; set; }
        public string distancia { get; set; }
    }
    static void Main(string[] args)
    {
        Barco[] flotas = [
            new() {Pais="Francès",distancia="66666633334444"}, // espera 64 
            new() {Pais="Anglès",distancia="343335333"}, // espera 33
            new() {Pais="Espanyol",distancia="19999999993333444411"} // espera 194
        ];

        var distanciamespatita= Int32.MaxValue;
        var pais = "";
        foreach(var flota in flotas){
            var distancia= AquinaDistanciaEstaElBarco(flota);
            if (distancia < distanciamespatita){
                distanciamespatita=distancia;
                pais=flota.Pais;
            }
        }
        Console.WriteLine($"Ataquem el vaixell {pais} que esta a {distanciamespatita}");
    }
    static int AquinaDistanciaEstaElBarco(Barco flota)
    {
        char quinesticbuscan= flota.distancia[0];
        var compte = 0;
        var solucio = "";
        
        foreach(var digit in flota.distancia){
            if (digit==quinesticbuscan){compte++;}
            else{
                var numeroqueestavabuscan= Convert.ToUInt32($"{quinesticbuscan}");
                if (numeroqueestavabuscan==compte){solucio +=quinesticbuscan;}
                quinesticbuscan=digit;
                compte=1;
            }
        }
        return Convert.ToInt32(solucio);
    }
}
