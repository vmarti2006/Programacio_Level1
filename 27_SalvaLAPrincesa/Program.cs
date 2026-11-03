using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace _27_SalvaLAPrincesa;

class Program
{

    static void Main(string[] args)
    {
        int Casc=0;
        int Escut=0;
        int Espasa=0;
        int Armadura=0;
        int Llança=0;

       string[] armes = {
        "Escut", "Casc", "Espasa", "Escut", "Espasa", "Casc", "Armadura", "Llança",
        "Escut", "Escut", "Casc", "Armadura", "Escut", "Llança", "Espasa", "Escut",
        "Llança", "Escut", "Espasa", "Casc", "Casc", "Escut", "Espasa", "Llança",
        "Llança", "Espasa", "Armadura", "Escut", "Escut", "Armadura", "Armadura",
        "Llança", "Armadura", "Espasa", "Escut", "Casc", "Escut", "Espasa", "Armadura",
        "Armadura", "Casc", "Casc", "Llança", "Casc", "Escut", "Escut", "Llança",
        "Llança", "Casc", "Espasa", "Armadura", "Casc", "Armadura", "Espasa", "Llança",
        "Casc", "Llança", "Llança", "Espasa", "Casc", "Espasa", "Casc", "Armadura",
        "Casc", "Casc", "Armadura", "Llança", "Escut", "Escut", "Armadura", "Llança",
        "Espasa", "Casc", "Llança", "Armadura", "Espasa", "Casc", "Escut", "Armadura",
        "Llança", "Llança", "Casc", "Casc", "Espasa", "Armadura", "Escut", "Armadura",
        "Espasa", "Armadura", "Espasa", "Espasa", "Armadura", "Escut", "Armadura",
        "Espasa", "Casc", "Llança", "Armadura", "Casc", "Armadura", "Llança", "Casc",
        "Escut", "Espasa", "Casc", "Casc", "Llança", "Llança", "Armadura", "Casc",
        "Llança", "Llança", "Espasa", "Llança", "Armadura", "Casc", "Casc", "Escut",
        "Casc", "Llança", "Casc", "Escut", "Llança", "Escut", "Espasa", "Escut", "Llança",
        "Armadura", "Casc", "Escut", "Espasa", "Llança", "Llança", "Casc", "Escut",
        "Casc", "Espasa", "Escut", "Escut", "Llança", "Llança", "Llança", "Llança",
        "Casc", "Escut", "Armadura", "Llança", "Casc", "Espasa", "Espasa",
        };

        // Suma per cada cas
        for (int i = 0; i < armes.Length; i++)
        {
            if(armes[i]=="Casc"){Casc++;}
            if(armes[i]=="Escut"){Escut++;}
            if(armes[i]=="Espasa"){Espasa++;}
            if(armes[i]=="Armadura"){Armadura++;}
            if(armes[i]=="Llança"){Llança++;}
        }

        var caballers = Caballers(Casc, Escut, Armadura, Llança);
        Casc=Casc-caballers;
        Escut=Escut-caballers;
        Llança=Llança-caballers;

        var soldat= Soldats(Casc, Escut, Espasa);
        Espasa=Espasa-soldat;

        var pagesos= Pagesos(Espasa,Llança);

        Console.WriteLine($"Hi han {caballers} caballers, {soldat} soldats i {pagesos} pagesos");
    }

    private static int Pagesos(int espasa, int llança)
    {
        bool bucle= true;
        int cont=0;

        while (bucle){
            if(llança>=1&&espasa>=1){
                cont++;
                llança--;
                espasa--;
            }
            else{bucle= false;}
        }
        return cont;  
    }

    private static int Soldats(int casc, int escut, int espasa)
    {
        bool bucle= true;
        int cont=0;

        while (bucle){
            if(casc>=1&& escut>=1&&espasa>=1){
                cont++;
                casc--;
                escut--;
                espasa--;
            }
            else{bucle= false;}
        }
        return cont;    
    }

    private static int Caballers(int casc, int escut, int armadura, int llança)
    {
        bool bucle= true;
        int cont=0;

        while (bucle){
            if(casc>=1&& escut>=1&&llança>=1&&armadura>=1){
                cont++;
                casc--;
                escut--;
                llança--;
                armadura--;
            }
            else{bucle= false;}
        }
        return cont;
    }
}

