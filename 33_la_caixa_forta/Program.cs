using System.Runtime.CompilerServices;

namespace _33_la_caixa_forta;

class Program
{
    public struct girador
    {
        public char lletra {get; set;}
        public int cantidad{get;set;}
    }

    static void Main(string[] args)
    {
        List<girador> combinacions = [
            new () {lletra='L', cantidad=68},
            new () {lletra='L', cantidad=30},
            new () {lletra='R', cantidad=48},
            new () {lletra='L', cantidad=5},
            new () {lletra='R', cantidad=60},
            new () {lletra='L', cantidad=55},
            new () {lletra='L', cantidad=1},
            new () {lletra='L', cantidad=99},
            new () {lletra='R', cantidad=14},
            new () {lletra='L', cantidad=82}
        ];

        int mes_gran= 99;
        int mes_petit=0;
        int posicio_actual=50;
        
        var resposta= CuantsCopsPasaPer0(mes_gran,mes_petit,combinacions,posicio_actual);

        Console.WriteLine($"El resultat és que ha passat pel zero {resposta} vegades");
    }

    private static int CuantsCopsPasaPer0(int mes_gran, int mes_petit, List<girador> combinacions,int posicio_actual)
    {
        int count=0;

        for (int x=0;x<combinacions.Count;x++){
            if (combinacions[x].lletra == 'L'){
                posicio_actual=posicio_actual+combinacions[x].cantidad;
                if (posicio_actual > mes_gran)
                {
                    posicio_actual= posicio_actual-mes_gran;
                    count++;
                }
            }
            else if (combinacions[x].lletra == 'R'){
                posicio_actual=posicio_actual-combinacions[x].cantidad;
                if (posicio_actual < mes_petit)
                {
                    posicio_actual= posicio_actual+mes_gran;
                    count++;
                }
            }
            Console.WriteLine($"{combinacions[x]} arriba a {posicio_actual}");
        }

        return count;
    
    }
}
