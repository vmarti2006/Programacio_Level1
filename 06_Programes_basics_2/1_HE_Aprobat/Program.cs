// Donar Numeros
Console.Write("Entra la nota: ");
var notita= Console.ReadLine()!;
var nota = Int32.Parse(notita);

// Calcula
var resultat = CalculaSiAproba(nota);

//resultat
Console.WriteLine(resultat);

string CalculaSiAproba(int nota)
{
   if(nota<5){ return "Has suspes";}
   
   return  "Has Aprobat";
 
}
;