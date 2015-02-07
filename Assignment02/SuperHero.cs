using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class SuperHero : Hero
    {


        //private properties
        private static string[] superPowers = { "SUPER SPEED", "SUPER STRENGTH", "BODY ARMOUR", "FLIGHT", "FIRE GENERATION", "WEATHER CONTROL" };
        private string[] tempSuperPowers = new string[superPowers.Length];
        private string[] finalSuperPowers = new string[3];

        //constructor
        public SuperHero(string name)
            : base(name)
        {
            this.name = name;
            Random rnd = new Random();
            int rndSuperPower;

            //copy each element of the superPower array to tempSuperPowers array
            for (int superPower = 0; superPower < superPowers.Length; superPower++)
            {
                tempSuperPowers[superPower] = superPowers[superPower];
            }

            // Assign cells from one array to another ensuring no super power is going to be repeated
            int index = 0;

            while (index < finalSuperPowers.Length)
            {
                rndSuperPower = generateRandomPowers(rnd, superPowers.Length);
                
                if (tempSuperPowers[rndSuperPower] != "taken")
                {

                    finalSuperPowers[index] = tempSuperPowers[rndSuperPower];
                    tempSuperPowers[rndSuperPower] = "taken";
                    index++;
                }
            }

        }

        //private method
        //generates a random number to randomly select the super power
        private int generateRandomPowers(Random rnd, int max)
        {
            int number;
            number = rnd.Next(max);
            return number;

        }
        
        //public method
        //shows the selected super powers
        public void showPowers()
        {
            Console.WriteLine("******************************************");
            for (int index = 0; index < finalSuperPowers.Length; index++)
            {
                if (index == 0)
                {
                    Console.WriteLine("{0}S' SUPER POWER # 1: {1}", this.name, finalSuperPowers[index]);
                }
                if (index == 1)
                {
                    Console.WriteLine("{0}S' SUPER POWER # 2: {1}", this.name, finalSuperPowers[1]);
                }
                if (index == 2)
                {
                    Console.WriteLine("{0}S' SUPER POWER # 3: {1}", this.name, finalSuperPowers[2]);
                }

            }
            Console.WriteLine("*****************************************");

        }
    }
}

