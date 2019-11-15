using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KangelasProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero k1 = new Hero("Todd", "Detroit");
            k1.Name = "MegaMan";
            k1.Location = "Detroit";
            Console.WriteLine("Nimi: "k1.Name);
            Console.WriteLine("Asukoht :"k1.Location);
            int inDanger = 1000;
            int rescued = k1.Rescue(inDanger);
            Console.WriteLine(k1 + $"\n suutis päästa {rescued}/{inDanger}");
            SuperHero s1 = new SuperHero("Megaman", "New York");
            rescued = s1.Rescue(inDanger);
            Console.WriteLine(s1 + $"\n suutis päästa {rescued}/{inDanger}");
        }
    }
}
