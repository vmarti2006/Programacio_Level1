namespace _21_La_mina_de_DryDust;

class Program
{
    static void Main(string[] args)
    {
        // Demana cuantitat de numeros que vols a la linea
        Console.Write("Quants barrils hi ha? ");
        var num = Convert.ToInt32(Console.ReadLine()!);

        // Demana que posis la la polvora
        Console.Write("Introdueix la quantitat de pólvora de cada barril: ");
        string numeors= Console.ReadLine()!;
        
        string[] fragments = numeors.Split(' ', StringSplitOptions.RemoveEmptyEntries); // separa text per espais
        
        List<int> polboras = new();
        foreach (string fragment in fragments) // mete casa uno ena de los numeros en fragment 
        {polboras.Add(Convert.ToInt32(fragment));} // conertim els numeros a int
        
    }

}
