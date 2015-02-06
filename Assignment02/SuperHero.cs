using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class SuperHero : Hero
    {
        Random rnd = new Random();

        private string[] superPowers = new string[3]; 


        public Super_Hero (string name) : base (name)
        {
            this.name = name;
            this.generateRandomPowers();
            
            
            
        }

        private string [] generateRandomPowers()
        {
            int rndsp = 0;
            int rndsp1 = 0;
            int rndsp2 = 0;
            int rndsp3 = 0;
            int noRepeatPower = 0;
            
            
            
            while (noRepeatPower <=3)
            {
                rndsp = rnd.Next(1, 7);
                noRepeatPower++;
                if (noRepeatPower == 1)
                {
                rndsp1 = rndsp;
                }
                if (noRepeatPower == 2)
                {
                    rndsp2 = rndsp;
                    if (rndsp1 == rndsp2)
                    {
                    for (rndsp2 = rndsp2;rndsp2 == rndsp1;)
                    {
                        rndsp2  = rnd.Next(1, 7);
                    }
                        }
                    
                }
                
                
               if (noRepeatPower == 3)
                {
                    rndsp3 = rndsp;
                    
                    if (rndsp3 == rndsp1)
                        
                    {
                    for (rndsp3=rndsp3;rndsp3 == rndsp1;)
                    {
                        rndsp3  = rnd.Next(1, 7);
                        
                    }
                        }
                   if (rndsp3 == rndsp2)
                       Console.WriteLine("3 if 2 {0}", rndsp3);
                    {
                    for (rndsp3 = rndsp3;rndsp3 == rndsp2;)
                    {
                        rndsp3  = rnd.Next(1, 7);
                        
                    }
                        }
                }
                }

            
            switch (rndsp1)
            {
                case 1:
                    superPowers[0] = "Super Speed";
                    break;
                case 2:
                    superPowers[0] = "Super Strenght";
                    break;
                case 3:
                    superPowers[0] = "Body Armour";
                    break;
                case 4:
                    superPowers[0] = "Flight";
                    break;
                case 5:
                    superPowers[0] = "Fire Generation";
                    break;
                case 6:
                    superPowers[0] = "Weather Control";
                    break;
                

            }
            
            switch (rndsp2)
            {
                case 1:
                    superPowers[1] = "Super Speed";
                    break;
                case 2:
                    superPowers[1] = "Super Strenght";
                    break;
                case 3:
                    superPowers[1] = "Body Armour";
                    break;
                case 4:
                    superPowers[1] = "Flight";
                    break;
                case 5:
                    superPowers[1] = "Fire Generation";
                    break;
                case 6:
                    superPowers[1] = "Weather Control";
                    break;


            }

            switch (rndsp3)
            {
                case 1:
                    superPowers[2] = "Super Speed";
                    break;
                case 2:
                    superPowers[2] = "Super Strenght";
                    break;
                case 3:
                    superPowers[2] = "Body Armour";
                    break;
                case 4:
                    superPowers[2] = "Flight";
                    break;
                case 5:
                    superPowers[2] = "Fire Generation";
                    break;
                case 6:
                    superPowers[2] = "Weather Control";
                    break;


            }
            
            return superPowers;

        }    
        public void showPowers()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("{0}S' SUPER POWER # 1: {1}", this.name, superPowers[0]);
            Console.WriteLine("{0}S' SUPER POWER # 2: {1}", this.name,superPowers[1]);
            Console.WriteLine("{0}S' SUPER POWER # 3: {1}", this.name,superPowers[2]);
            Console.WriteLine("***********************************");
        }
            
    
    }
}
