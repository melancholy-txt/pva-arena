using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pva_arena
{
    abstract class Fighter
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int DMG { get; set; }
        public int DodgeChance { get; set; }
        public int BlockChance { get; set; }
        public int Initiative { get; set; }
        public bool DoubleAttack { get; set; }

        public Fighter(string name, int hP, int dMG, int dodgeChance, int blockChance, int initiative, bool doubleAttack)
        {
            Name = name;
            HP = hP;
            DMG = dMG;
            DodgeChance = dodgeChance;
            BlockChance = blockChance;
            Initiative = initiative;
            DoubleAttack = doubleAttack;
        }

        public abstract void Greeting();
        public void Attack(Fighter fighta)
        {
            var r = new Random();
            var chance = r.Next(0, 100);
            Console.WriteLine($"{Name} útočí na {fighta.Name}!");
            if (chance > fighta.DodgeChance && chance > fighta.BlockChance)
            {
                fighta.HP -= this.DMG;
                Console.WriteLine($"{fighta.Name} dostal za {DMG} a má {fighta.HP} životů!");
                if (DoubleAttack == true && r.Next(0,5) == 0)
                {
                    fighta.HP -= this.DMG;
                    Console.WriteLine("Battle Master útočí znovu!");
                    Console.WriteLine($"{fighta.Name} dostal za dalších {DMG} a má {fighta.HP} životů!");
                }
            }
            else if (chance < fighta.DodgeChance)
            {
                Console.WriteLine($"{fighta.Name} se vyhnul!");
            }
            else if (chance < fighta.BlockChance)
            {
                Console.WriteLine($"{fighta.Name} vyblokoval útok!");
            }
        }
    }
}
