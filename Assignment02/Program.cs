// Author's Name: Beymig Munoz 
// Date Last Modified: Feb 5, 2015
// Program Description:  A program that generates Hero abilities and allows him to hit a villain (or not). 
//                       Additionally ramdomly selects Super Hero powers and allows him to hit a villain (or not).
// Revision History: Feb 2, 2015 - Started Assignment 2, added Super Hero Class
//                   Feb 3, 2015 - properties, constructor and methods created in Super Hero class
//                   Feb 3, 2015 - added new super hero to main and fixed mistakes in generateRandomPowers method
//                   Feb 3, 2015 - change hero and super hero names and arrange output
//                   Feb 5, 2015 - testing new repository
//                   Feb 5, 2015 - added hero and super hero classes
//                   Feb 5, 2015 - populated the classes with data from previous repository (https://github.com/beymig/COMP123-Assignment01/tree/newbranch)
//                   Feb 5, 2015 - new features to super hero class to generate random super powers
//                   Feb 5, 2015 - ramdom super powers optimized
//                   Feb 5, 2015 - final improvement to ramdom super powers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        
        //Creates the new Hero and New Super Hero and calls the required methods
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
