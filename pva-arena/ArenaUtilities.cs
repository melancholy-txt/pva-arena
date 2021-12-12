using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pva_arena
{
    class ArenaUtilities
    {
        public static bool Startup()
        {
            Console.WriteLine("Vítejte v aréně!");
            Console.WriteLine("Chcete vytvořit nového bojovníka? y/n");
            string tvorba = Console.ReadLine();
            if (tvorba.Trim().ToLower() == "n")
            {
                Console.WriteLine(":( ok, tak nic");
                return false;
            }
            if (tvorba.Trim().ToLower() == "y")
            {
                Console.WriteLine("Jdeme na to!");
                return true;

            }
            else
            {
                Console.WriteLine("bruh, to beru jako ne");
                return false;
            }
        }

        public static Fighter CreateFighter()
        {
            var r = new Random();

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
                return new Champion(name, r.Next(15,35), r.Next(5,10), 0, r.Next(25, 75));
            }
            else if (type == "2")
            {
                return new BattleMaster(name, r.Next(10, 30), r.Next(10, 15), 0, r.Next(10, 20));
            }
            else if (type == "3")
            {
                return new Archer(name, r.Next(10, 20), r.Next(15, 20), r.Next(25, 75), 0);
            }
            else if (type == "4")
            {
                return new EldritchKnight(name, r.Next(10, 20), r.Next(15, 20), 0, 0);
            }
            return null;

        }
    }
}
