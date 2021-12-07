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
            if (tvorba.Trim().ToLower() == "n")
            {
                Console.WriteLine(":( ok, tak nic");
                return;
            }
            if (tvorba.Trim().ToLower() == "y")
            {
                CreateFighter();
            }
        }

        private static void CreateFighter()
        {
            Console.WriteLine("Jak se jmenuje?");
            string name = Console.ReadLine().Trim();
            string type = Console.ReadLine().Trim();
        }
    }
}
