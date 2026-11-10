// Info
Console.WriteLine("FC Vilamongat: ");
var FCVila= Console.ReadLine()!;
var FCV = Int32.Parse(FCVila);

Console.WriteLine("UE Fontverda: ");
var UEFont= Console.ReadLine()!;
var UEF = Int32.Parse(UEFont);

// Resultat
var resultat = CalculaElResultat (FCV,UEF);
Console.WriteLine(resultat);

//Proces
string CalculaElResultat (int FCV,int UEF)
{
    // Guanya Vilamongat
    if (FCV>UEF){return $"Gran partit del Vilamongat que ha superat a la UE Fontverd per {UEF} a {FCV} ";}

    // Guanya Fontverda
    else if (FCV<UEF){return $"Gran partit de la UE Fontverda que ha superat al FC Vilamongat per {UEF} a {FCV} ";}
   
    // Empat
    return "Partit molt igualat entre els dos rivals que ha acabat en empat 1 a 1 tot i els esforços dels dos equips";
};
