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
            var createF = ArenaUtilities.Startup();
            if (createF)
            {
                ArenaUtilities.CreateFighter();
            }
            Console.ReadLine();
        }
    }
}
