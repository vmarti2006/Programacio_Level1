using System.Diagnostics.Contracts;

namespace _19_Abans_que_els_robots_es_revoltin;

class Program
{
    static void Main(string[] args)
    {
        List<string> robots = ["Roomba","Thermomix","Cafetera","Microones"];
        int[] comtador= [5, 2, 3];

        var resultat = QuinRobotViu(robots,comtador);

        Console.WriteLine($"El robot que sobreviu és: {resultat}");    }

   public static string QuinRobotViu(List<string> robots, int[] comptador)
    {
        int posicio_r = 0; 
        int posicio_c = 0; 

        while (robots.Count > 1)
        {
            int pasos = comptador[posicio_c];

           
            posicio_r = (posicio_r + pasos - 1) % robots.Count; // Calculamos el índice exacto a eliminar i restamos 1

            Console.WriteLine($"Eliminat: {robots[posicio_r]} (pasos: {pasos})");

            robots.RemoveAt(posicio_r); // Eliminamos el robot

            posicio_c = (posicio_c + 1) % comptador.Length; // Avance del contador circular

        }
        return robots[0];
    }
}

