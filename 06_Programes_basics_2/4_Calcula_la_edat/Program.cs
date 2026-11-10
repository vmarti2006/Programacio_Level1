internal class Program
{
    private static void Main(string[] args)
    {
        // info
        Console.WriteLine("Posa el teu any de naixement");
        Console.WriteLine("Any: ");
        var any_naixement = Console.ReadLine()!;
        var any_n = int.Parse(any_naixement);

        Console.WriteLine("Mes: ");
        var mes_naixement = Console.ReadLine()!;
        var mes_n = int.Parse(mes_naixement);

        Console.WriteLine("dia: ");
        var dia_naixement = Console.ReadLine()!;
        var dia_n = int.Parse(dia_naixement);

        // clacul
        var resultat = CalcualLaMevaEdat(dia_n, mes_n, any_n);

        // Resultat
        Console.WriteLine(resultat);

        // Proces
        string CalcualLaMevaEdat(int dia_n, int mes_n, int any_n)
        {
            // calcula quin dia mes i any es 
            var avui = DateTime.Now;
            var any = avui.Year;
            var mes = avui.Month;
            var dia = avui.Day;

            // Calculs de esdat
            int edat_f=0;
            int edat_base = any - any_n;
            if (mes>mes_n)
            {
                edat_f=edat_base++;
                return $"Tens {edat_f} anys";
            }
            else if(mes == mes_n && dia_n<=dia)
            {
                edat_f=edat_base++;
                return $"Tens {edat_f} anys";
            }
            return $"Tens {edat_base} anys";
        }
    }
}