using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KangelasProjekt
{
    class SuperHero:Hero
    {
        private static Random r = new Random();
        private  double _skill;
        public SuperHero(string Name, string Location) : base(Name,Location)
        {
            _skill = r.Next(100, 501) / 100.0;
        }
        public double Skill { get => _skill; }
        public override string ToString()
        {
            return base.ToString()+ "Lisaks on ta võimekam "+ _skill + "%";
        }
    }
}
