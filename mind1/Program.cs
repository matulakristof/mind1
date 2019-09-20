using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mind1
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Szia hogy hívnak?");
            var nev = Console.ReadLine();
            Console.WriteLine($"Oh milyen szép név az hogy {nev} ! <3");
            Console.WriteLine("Szerecc programozni?");
            var valasz = Console.ReadLine();
            if (valasz.ToLower() == "igen")
            {
                Console.WriteLine("Akkor mi nagyon jó barátok leszünk!");
                Console.WriteLine(":)");
            }
            else
            {
                Console.WriteLine(":(");
                Console.WriteLine("Akkor b@zd meg!");
            }
            Console.WriteLine("Hallod, nesze itt van 100 csillag!");
            for (int i = 0; i < 100; i++)
            {
                Console.SetCursorPosition(
                    rnd.Next(Console.WindowWidth),
                    rnd.Next(Console.WindowHeight));
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                Console.Write("*");
            }
            Console.ReadKey();
        }
    }
}
