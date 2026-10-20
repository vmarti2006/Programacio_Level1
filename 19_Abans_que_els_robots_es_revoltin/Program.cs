namespace _19_Abans_que_els_robots_es_revoltin;

class Program
{
    static void Main(string[] args)
    {
        string[] robots = ["Roomba","Thermomix","Cafetera","Microones"];
        int[] comtador= [5, 2, 3];

        var resultat = QuinRobotViu(robots,comtador);

        Console.Write(resultat);
    }

    public static string QuinRobotViu(string[] robots, int[] comtador)
    {
        int morts=0;
       
        while (robots.Length >= 1)
        {
            for (int i = 0; morts > comtador.Length-1; i++)
            {
                
            }
            
        }
        return $"";
    }
}

