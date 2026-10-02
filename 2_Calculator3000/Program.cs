// Demana numero 1
Console.WriteLine("Insereix un numero");
var n1 = Console.ReadLine();
int numero1 = Convert.ToInt32(n1);
// Que vols fer

Console.WriteLine("Que vols fer, muliplicacio(M), suma(S), resta(R) o divisio(D)?");
var quefa = Console.ReadLine();

// Demana un segon
Console.WriteLine("Insereix un numero");
var n2 = Console.ReadLine();
int numero2 = Int32.Parse(n2);


// Calculs 

    // Multiplicacio
    if (quefa == "M")
    {
       int multiplica =  numero1 * numero2;
        Console.WriteLine($"La multiplicacio de {numero1} i {numero2} es {multiplica}");
    }

    // Suma
    else if (quefa == "S")
    {
        int suma = numero1 + numero2;
        Console.WriteLine($"La suma de {numero1} i {numero2} es {suma}");
    }

     // Divisio
    else if (quefa == "D")
    {
        double divisio = numero1 / numero2;
        Console.WriteLine($"La divisio de {numero1} i {numero2} es {divisio}");
    }
     // Resta
    else if (quefa == "R")
    {
        int resta = numero1 - numero2;
        Console.WriteLine($"La resta de {numero1} i {numero2} es {resta}");
    }
    else
    {
        Console.WriteLine($"Algo has fet malament");
    };



