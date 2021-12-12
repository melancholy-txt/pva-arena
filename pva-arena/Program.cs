using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pva_arena
{
    class Program
    {
        static void Main(string[] args)
        {
            var fighters = new List<Fighter>(); 

            ArenaUtilities.Startup();
            bool keeponcreatin = true;
            do
            {
                Fighter cosedeje = ArenaUtilities.CreateFighter();
                fighters.Add(cosedeje);
                Console.WriteLine($"Nový bojovník {cosedeje.Name}!");
                Console.WriteLine("Přejete si vytvořit dalšího? y/n");
                var ans = Console.ReadLine();
                if (ans.Trim().ToLower() == "n")
                {
                    keeponcreatin = false;
                }
            }
            while (keeponcreatin);
            
            foreach (var i in fighters)
            {
                i.Greeting();
            }

            Console.WriteLine("Jdeme bojovat!");

            ArenaUtilities.Tournament(fighters);

            Console.WriteLine($"{fighters[0].Name} vyhrál turnaj!");

            Console.ReadLine();
        }
    }
}
