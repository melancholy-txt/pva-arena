using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pva_arena
{
    class EldritchKnight : Fighter
    {
        public EldritchKnight(string name, int hP, int dMG, int dodgeChance, int blockChance, int initiative, bool doubleAttack) : base(name, hP, dMG, dodgeChance, blockChance, initiative, doubleAttack)
        {
        }


        public override void Greeting()
        {
            Console.WriteLine($"Ahoj! Jsem {Name}, bojovník typu Elditch Knight. Mám {HP} životů, můj útok je {DMG}, má šance na vyhnutí {DodgeChance} a má šance na blokování {BlockChance}.");
        }
    }
}
