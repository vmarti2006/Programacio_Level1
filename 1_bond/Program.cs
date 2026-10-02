// Nom
Console.WriteLine("Com es diu?");
string nom =Console.ReadLine();

// Cognom
Console.WriteLine("Y quin es el cognom?");
string cognom =Console.ReadLine();

// Tot junt separant
Console.WriteLine("Hola bon dia" + cognom + "," + nom + " " + cognom + "!");

// Tot junt interpulacio (sense treure les cometes)
Console.WriteLine($"Em dic {cognom}, {nom} {cognom}!");
