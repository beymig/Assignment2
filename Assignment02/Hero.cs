using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Hero
    {
        //Random class to be used in different methods
        Random rnd = new Random();

        //Private Properties

        private int strength;
        private int speed;
        private int health;


        //Public Properties
        public string name;

        //Public Properties
        //Constructor
        public Hero(string name)
        {

            this.name = name;

            generateAbilities();
        }



        //Receives value to determine if the villain will be hit by the hero
        public void fight()
        {
            hitAttempt();

            if (hitAttempt() == true)
            {

                if (this.name == "SUPERMAN")
                {
                    Console.WriteLine("******************** {0} HITS LEX LUTHOR!!! YEEEEI! **********************", this.name);
                    hitDamage();
                    Console.WriteLine("***********************************");
                    Console.WriteLine("DAMAGE CAUSED ----------------> {0}", hitDamage());
                    Console.WriteLine("***********************************");
                    hitAttempt();
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }

                if (this.name == "BATMAN")
                {
                    Console.WriteLine("******************** {0} HITS THE RIDDLER!!! YEEEEI! ********************", this.name);
                    hitDamage();
                    Console.WriteLine("***********************************");
                    Console.WriteLine("DAMAGE CAUSED ----------------> {0}", hitDamage());
                    Console.WriteLine("***********************************");
                    hitAttempt();

                }

            }
            else
            {
                if (this.name == "SUPERMAN")
                {
                    Console.WriteLine("------------------{0} COULDN'T HIT LEX LUTHOR :( BUUUUU--------------------", this.name);
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
                if (this.name == "BATMAN")
                {
                    Console.WriteLine("------------------{0} COULDN'T HIT THE RIDDLER :( BUUUUU------------------", this.name);

                }

            }

        }

        //Show the hero abilities
        public void show()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("{0}S' STRENGTH ------------> {1}", this.name, this.strength);
            Console.WriteLine("{0}S' SPEED ---------------> {1}", this.name, this.speed);
            Console.WriteLine("{0}S' HEALTH --------------> {1}", this.name, this.health);
            Console.WriteLine("***********************************");
        }

        //Private Methods
        //Randomly generates Hero Abilities
        private void generateAbilities()
        {

            this.strength = rnd.Next(1, 101);
            this.speed = rnd.Next(1, 101);
            this.health = rnd.Next(1, 101);

        }
        //Randomly determines if the villain will be hit
        private bool hitAttempt()
        {
            bool hit;
            int rndHit;
            rndHit = rnd.Next(1, 1001);
            if (rndHit <= 200)
            {

                hit = true;
                return hit;
            }
            else
            {
                hit = false;
                return hit;
            }

        }

        //Determine the damage occasionated by the hit
        private int hitDamage()
        {
            int damage;
            damage = strength * rnd.Next(1, 7);
            return damage;
        }
    }
}
