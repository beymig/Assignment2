using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero Batman = new Hero("BATMAN");
            Batman.show();
            Batman.fight();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            SuperHero Superman = new SuperHero("SUPERMAN");
            Superman.showPowers();
            Superman.fight();
            
        }
    }
}
