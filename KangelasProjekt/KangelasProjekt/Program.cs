using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KangelasProjekt
{
    class Program
    {
        private static List<Hero> heroes = new List<Hero>();
        private static void LoadHeroesFromFile(string Filename)
        {
            string[] data = File.ReadAllLines(Filename);
            //TODO load file parse data, add to heroes list
            for (int i = 0; i < data.Length; i++)
            {
                string[] name_loc = data[i].Split(new char[] { '/' });

                if (name_loc[0].EndsWith('*'))

                    heroes.Add(new Hero(name_loc[0].Substring(0, name_loc[0].Length - 1), name_loc[1]));
                else
                    heroes.Add(new SuperHero(name_loc[0], name_loc[1]));
                
            }

            
        }
        static void Main(string[] args)
        {
            Hero k1 = new Hero("Todd", "Detroit");
            k1.Name = "MegaMan";
            k1.Location = "Detroit";
            Console.WriteLine("Nimi: ",k1.Name);
            Console.WriteLine("Asukoht :",k1.Location);
            int inDanger = 1000;
            int rescued = k1.Rescue(inDanger);
            Console.WriteLine(k1 + $"\n suutis päästa {rescued}/{inDanger}");
            SuperHero s1 = new SuperHero("Megaman", "New York");
            rescued = s1.Rescue(inDanger);
            Console.WriteLine(s1 + $"\n suutis päästa {rescued}/{inDanger}");
            LoadHeroesFromFile("kangelased.txt");
            foreach (Hero hero in heroes)
            {
                Console.WriteLine(hero);
                Console.WriteLine("Suutis päästa 1000 / "+hero.Rescue(1000));
            }
        }
    }
}
