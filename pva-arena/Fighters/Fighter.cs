using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pva_arena
{
    class Fighter
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int DMG { get; set; }
        public int DodgeChance { get; set; }
        public int BlockChance { get; set; }

        public Fighter(string name, int hP, int dMG, int dodgeChance, int blockChance)
        {
            Name = name;
            HP = hP;
            DMG = dMG;
            DodgeChance = dodgeChance;
            BlockChance = blockChance;
        }
    }
}
