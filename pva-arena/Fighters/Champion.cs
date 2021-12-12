using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pva_arena
{
    class Champion : Fighter
    {
        public Champion(string name, int hP, int dMG, int dodgeChance, int blockChance, int initiative, bool doubleAttack) : base(name, hP, dMG, dodgeChance, blockChance, initiative, doubleAttack)
        {
        }



        public override void Greeting()
        {
            Console.WriteLine($"Ahoj! Jsem {Name}, bojovník typu Champion. Mám {HP} životů, můj útok je {DMG}, má šance na vyhnutí {DodgeChance} a má šance na blokování {BlockChance}.");
        }
    }
}
