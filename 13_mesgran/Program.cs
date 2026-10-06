namespace mesgran;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entra els numeros separats per comas");
        var numerosstring= Console.ReadLine()!;
        
        var arrayNumeros = numerosstring!.Split(","); // Separa per el que tu posis aqui

        var mesGran = Convert.ToInt32(arrayNumeros[0]);
        // var mesPetit = Int32.MinValue(arrayNumeros);

        foreach(var numero in arrayNumeros)
        {
           var nouNumero=Convert.ToInt32(numero);
           if (nouNumero>mesGran)
            {
                mesGran=nouNumero;
            }

            Console.WriteLine(numero);
        }
    }
}
