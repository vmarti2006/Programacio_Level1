// Demana Usuari
Console.WriteLine("Username:");
string user = Console.ReadLine()!;

// Resultat
var resultat = QuinUsuariES(user);
Console.WriteLine(resultat);

string QuinUsuariES(string user){
    if (user=="administrador"){return "Benvingut al sistema";}
   
   // Demana Contraseña
    Console.WriteLine("Contraseña:");
    string contra = Console.ReadLine()!;

    if (user== "pere" && contra== "xxx"){return "Benvingut al sistema";}
    else if (user== "pere" && contra!= "xxx"){return "Contraseña incorrecta";}
    return "Algo a fallado";
}
