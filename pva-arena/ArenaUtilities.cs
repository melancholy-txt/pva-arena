using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pva_arena
{
    class ArenaUtilities
    {
        public static void Startup()
        {
            Console.WriteLine("Vítejte v aréně!");
            Console.WriteLine("Chcete vytvořit nového bojovníka? y/n");
            string tvorba = Console.ReadLine();
            if (tvorba.Trim().ToLower() == "y")
            {
                Console.WriteLine("Jdeme na to!");
                return;

            }
            else
            {
                Console.WriteLine("mas smulu stejne ho udelame");
                return;
            }
        }

        public static Fighter CreateFighter()
        {
            var r = new Random();
            var init = r.Next(0, 100);
            Console.WriteLine("Jak se jmenuje?");
            string name = Console.ReadLine().Trim();
            Console.WriteLine("Jaký bojovník to bude? 👀");
            Console.WriteLine("1: Champion - šance na zablokování");
            Console.WriteLine("2: Battle Master - šance na zaútočení znova");
            Console.WriteLine("3: Archer - šance na vyhnutí");
            Console.WriteLine("4: Eldritch Knight - nemůže nic, lol");
            string type = Console.ReadLine().Trim();
            if (type == "1")
            {
                return new Champion(name, r.Next(15,35), r.Next(5,10), 0, r.Next(25, 75), init, false);
            }
            else if (type == "2")
            {
                return new BattleMaster(name, r.Next(10, 30), r.Next(10, 15), 0, r.Next(10, 20), init, true);
            }
            else if (type == "3")
            {
                return new Archer(name, r.Next(10, 20), r.Next(15, 20), r.Next(25, 75), 0, init, false);
            }
            else if (type == "4")
            {
                return new EldritchKnight(name, r.Next(10, 20), r.Next(15, 20), 0, 0, init, false);
            }
            return null;

        }

        public static void Tournament(List<Fighter> fighters)
        {
            var r = new Random();
            bool keepOnFightin = true;
            while (fighters.Count() > 1)
            {
                keepOnFightin = true;
                var f1 = r.Next(0, fighters.Count());
                var f2 = r.Next(0, fighters.Count());               
                while (f2 == f1)
                {
                    f2 = r.Next(0, fighters.Count());
                }
                Console.WriteLine($"Utkají se {fighters[f1].Name} a {fighters[f2].Name}!");
                var f1Health = fighters[f1].HP;
                var f2Health = fighters[f2].HP;
                while (keepOnFightin)
                {
                    if (fighters[f1].Initiative > fighters[f2].Initiative)
                    {
                        fighters[f1].Attack(fighters[f2]);
                        if (fighters[f2].HP <= 0)
                        {
                            Console.WriteLine($"{fighters[f2].Name} byl eliminován! {fighters[f1].Name} byl vyhealován.");
                            fighters[f1].HP = f1Health;
                            fighters.RemoveAt(f2);
                            keepOnFightin = false;
                        }
                        else
                        {
                            fighters[f2].Attack(fighters[f1]);
                            if (fighters[f1].HP <= 0)
                            {
                                Console.WriteLine($"{fighters[f1].Name} byl eliminován! {fighters[f2].Name} byl vyhealován.");
                                fighters[f2].HP = f2Health;
                                fighters.RemoveAt(f1);
                                keepOnFightin = false;

                            }
                        }
                    }
                    else
                    {
                        fighters[f2].Attack(fighters[f1]);
                        if (fighters[f1].HP <= 0)
                        {
                            Console.WriteLine($"{fighters[f1].Name} byl eliminován! {fighters[f2].Name} byl vyhealován.");
                            fighters[f2].HP = f2Health;
                            fighters.RemoveAt(f1);
                            keepOnFightin = false;

                        }
                        else
                        {
                            fighters[f1].Attack(fighters[f2]);
                            if (fighters[f2].HP <= 0)
                            {
                                Console.WriteLine($"{fighters[f2].Name} byl eliminován! {fighters[f1].Name} byl vyhealován.");
                                fighters[f1].HP = f1Health;
                                fighters.RemoveAt(f2);
                                keepOnFightin = false;

                            }
                        }

                    }
                } 
                //if (fighters[f1].HP <= 0)
                //{
                //    Console.WriteLine($"{fighters[f1].Name} byl eliminován! {fighters[f2].Name} byl vyhealován.");
                //    fighters[f2].HP = f2Health;
                //    fighters.RemoveAt(f1);             
                //}
                //else if (fighters[f2].HP <= 0)
                //{
                //    Console.WriteLine($"{fighters[f1].Name} byl eliminován! {fighters[f2].Name} byl vyhealován.");
                //    fighters[f1].HP = f1Health;
                //    fighters.RemoveAt(f2);
                //}

            }
        }
    }
}
