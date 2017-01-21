using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Chocobo
    {
        //Declaring fields and variables
        private string name;
        private string color;
        private int speed;
        private int hunger;
        private int boredom;
        private int tiredness;
        private int stamina;
        private int anger;  //anger will be a hidden stat that will affect the pet behind the scenes

        Random randomNumber = new Random(); //I will be using lots of random numbers in my Methods. 
                                            //So, I am constructing my random number generator here.

        //Setting up Properties for each stat for easy access
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Boredom
        {
            get { return this.boredom; }
            set { this.boredom = value; }
        }

        public int Tiredness
        {
            get { return this.tiredness; }
            set { this.tiredness = value; }
        }

        public int Stamina
        {
            get { return this.stamina; }
            set { this.stamina = value; }
        }

        public int Anger
        {
            get { return this.anger; }
            set { this.anger = value; }
        }

        //Constructor
        public Chocobo()
        {
            Console.WriteLine("Thank you for using ChocoPet2000.\n");
            Console.WriteLine("Max out your ChocoPet's Speed and Stamina then dominate the race!\n");
            Console.WriteLine("Be careful not to make your ChocoPet too hungry, bored, tired, or angry,");
            Console.WriteLine("or terrible things will happen...");
            Console.WriteLine("\n\nPlease enter a name for your Chocobo:\n");
            Name = Console.ReadLine();

            bool trueFalse = true; //this is a shortcut I have enjoyed for killing or restarting loops
            while (trueFalse == true)
            {
                //Get different starting stats depending on which color
                //also activities adjust stat differently based on color
                Console.WriteLine("\nPlease choose a color for {0} from the following:\n\n", Name);
                Console.WriteLine("Yellow -->(well-rounded, easygoing)");
                Console.WriteLine("\nGreen -->(forest-dweller, fast, loves food)");
                Console.WriteLine("\nBlue -->(swimmer, fast, loves play)");
                Console.WriteLine("\nBlack -->(faster, but high-maintenance)");
                Console.WriteLine("\nGold -->(incredible, but moody and volatile)\n");
                Color = Console.ReadLine();
                color = color.ToUpper();
                if (color == "YELLOW")
                {
                    Speed = 25;
                    Hunger = 0;
                    Boredom = 0;
                    Tiredness = 0;
                    Stamina = 25;
                    Anger = 0;
                }
                else if (color == "GREEN")
                {
                    Speed = 35;
                    Hunger = 20;
                    Boredom = 15;
                    Tiredness = 20;
                    Stamina = 30;
                    Anger = 5;
                }
                else if (color == "BLUE")
                {
                    Speed = 35;
                    Hunger = 15;
                    Boredom = 20;
                    Tiredness = 20;
                    Stamina = 30;
                    Anger = 5;
                }
                else if (color == "BLACK")
                {
                    Speed = 50;
                    Hunger = 20;
                    Boredom = 20;
                    Tiredness = 20;
                    Stamina = 35;
                    Anger = 15;
                }
                else if (color == "GOLD")
                {
                    Speed = 65;
                    Hunger = 35;
                    Boredom = 30;
                    Tiredness = 20;
                    Stamina = 50;
                    Anger = 35;
                }
                else
                {
                    Console.Write("\nThat is not a valid choice\n");
                    Console.ReadKey();
                    continue;
                }
                trueFalse = false;
            }
        }

        //Methods

        public void Feed() //feed Method
        {
            Console.Clear();
            Console.WriteLine("You feed {0} some fresh greens!", Name);
            Console.WriteLine("{0} releases a loud, \"WARK!!!\"");
            Console.WriteLine("{0} has become faster and gained stamina!", Name);
            Console.WriteLine("{0} has become less hungry!", Name);
            Console.WriteLine("{0} has become slightly less angry.", Name);
            Console.WriteLine("{0} has become more tired and bored.", Name);

            if (color == "YELLOW" || color == "BLUE")
            {
                Speed += randomNumber.Next(1, 4);
                Stamina += randomNumber.Next(1, 5);
                Hunger -= randomNumber.Next(10, 16);
                Anger -= randomNumber.Next(1, 4);
                Tiredness += randomNumber.Next(8, 12);
                Boredom += randomNumber.Next(5, 11);
            }
            else if (color == "GREEN")
            {
                Speed += randomNumber.Next(3, 7);
                Stamina += randomNumber.Next(2, 6);
                Hunger -= randomNumber.Next(14, 20);
                Anger -= randomNumber.Next(3, 7);
                Tiredness += randomNumber.Next(12, 16);
                Boredom += randomNumber.Next(7, 13);
            }
            else if (color == "BLACK")
            {
                Speed += randomNumber.Next(1, 4);
                Stamina += randomNumber.Next(1, 4);
                Hunger -= randomNumber.Next(9, 12);
                Anger -= randomNumber.Next(1, 3);
                Tiredness += randomNumber.Next(10, 14);
                Boredom += randomNumber.Next(10, 16);
            }
            else //color Gold
            {
                Speed += randomNumber.Next(1, 4);
                Stamina += randomNumber.Next(1, 4);
                Hunger -= randomNumber.Next(7, 11);
                Anger -= randomNumber.Next(1, 3);
                Tiredness += randomNumber.Next(12, 17);
                Boredom += randomNumber.Next(12, 20);
            }
        }

        public void Play() //play Method
        {
            Console.Clear();
            if (Speed <= 25)
            {
                Console.WriteLine("You shoot marbles with {0}!", Name);
            }
            else if (Speed > 25 && Speed <= 50)
            {
                Console.WriteLine("You play a game of hopscotch with {0}!", Name);
            }
            else if (Speed > 50 && Speed <= 75)
            { 
                Console.WriteLine("You play a spirited game of fetch with {0}!", Name);
            }
            else //speed > 75
            {
                Console.WriteLine("{0} wrecks you and your friends in a game of tag!", Name);
            }
            Console.WriteLine("{0} has become less bored and gained speed and stamina!", Name);
            Console.WriteLine("{0} has become more hungry.", Name);
            Console.WriteLine("{0} has become less angry.", Name);
            Console.WriteLine("{0} has become more tired.", Name);

            if (color == "YELLOW" || color == "GREEN")
            {
                Speed += randomNumber.Next(1, 4);
                Stamina += randomNumber.Next(3, 6);
                Hunger += randomNumber.Next(4, 8);
                Anger -= randomNumber.Next(1, 5);
                Tiredness += randomNumber.Next(10, 14);
                Boredom -= randomNumber.Next(5, 11);
            }
            else if (color == "BLUE")
            {
                Speed += randomNumber.Next(3, 7);
                Stamina += randomNumber.Next(2, 6);
                Hunger += randomNumber.Next(14, 20);
                Anger -= randomNumber.Next(3, 7);
                Tiredness += randomNumber.Next(12, 16);
                Boredom -= randomNumber.Next(7, 13);
            }
            else if (color == "BLACK")
            {
                Speed += randomNumber.Next(1, 4);
                Stamina += randomNumber.Next(1, 4);
                Hunger += randomNumber.Next(15, 21);
                Anger -= randomNumber.Next(1, 3);
                Tiredness += randomNumber.Next(13, 17);
                Boredom -= randomNumber.Next(4, 10);
            }
            else //color Gold
            {
                Speed += randomNumber.Next(1, 4);
                Stamina += randomNumber.Next(1, 4);
                Hunger += randomNumber.Next(17, 26);
                Anger -= randomNumber.Next(1, 3);
                Tiredness += randomNumber.Next(15, 20);
                Boredom -= randomNumber.Next(2, 8);
            }
        }

        public void Dance() //dance Method
        {
            Console.Clear();
            Console.WriteLine("You have a late night dance party with {0}!", Name);
            Console.WriteLine("{0} has become much less bored and gained speed and stamina!", Name);
            Console.WriteLine("{0} has become much more hungry.", Name);
            Console.WriteLine("{0} has become much less angry.", Name);
            Console.WriteLine("{0} has become much more tired.", Name);

            if (color == "YELLOW")
            {
                Speed += randomNumber.Next(3, 6);
                Stamina += randomNumber.Next(3, 6);
                Hunger += randomNumber.Next(12, 21);
                Anger -= randomNumber.Next(5, 13);
                Tiredness += randomNumber.Next(16, 21);
                Boredom -= randomNumber.Next(10, 19);
            }
            else if (color == "BLUE" || color == "GREEN")
            {
                Speed += randomNumber.Next(3, 6);
                Stamina += randomNumber.Next(3, 6);
                Hunger += randomNumber.Next(14, 25);
                Anger -= randomNumber.Next(5, 12);
                Tiredness += randomNumber.Next(18, 25);
                Boredom -= randomNumber.Next(10, 19);
            }
            else if (color == "BLACK")
            {
                Speed += randomNumber.Next(2, 6);
                Stamina += randomNumber.Next(2, 6);
                Hunger += randomNumber.Next(16, 29);
                Anger -= randomNumber.Next(4, 12);
                Tiredness += randomNumber.Next(20, 31);
                Boredom -= randomNumber.Next(8, 19);
            }
            else //color Gold
            {
                Speed += randomNumber.Next(2, 5);
                Stamina += randomNumber.Next(2, 5);
                Hunger += randomNumber.Next(17, 31);
                Anger -= randomNumber.Next(3, 11);
                Tiredness += randomNumber.Next(22, 35);
                Boredom -= randomNumber.Next(7, 16);
            }
        }

        public void Sleep() //sleep Method
        {
            Console.Clear();
            Console.WriteLine("You allow {0} to catch some Zzzz's.", Name);
            Console.WriteLine("{0} has become much less tired and gained speed and stamina!", Name);
            Console.WriteLine("{0} has become more hungry.", Name);
            Console.WriteLine("{0} has become less angry.", Name);
            Console.WriteLine("{0} has become much more bored.", Name);

            if (color == "YELLOW")
            {
                Speed += randomNumber.Next(1, 3);
                Stamina += randomNumber.Next(1, 3);
                Hunger += randomNumber.Next(12, 21);
                Anger -= randomNumber.Next(5, 13);
                Tiredness = 0;
                Boredom += randomNumber.Next(10, 19);
            }
            else if (color == "BLUE" || color == "GREEN")
            {
                Speed += randomNumber.Next(1, 3);
                Stamina += randomNumber.Next(1, 3);
                Hunger += randomNumber.Next(14, 25);
                Anger -= randomNumber.Next(5, 12);
                Tiredness = 0;
                Boredom += randomNumber.Next(12, 21);
            }
            else if (color == "BLACK")
            {
                Speed++;
                Stamina++;
                Hunger += randomNumber.Next(16, 29);
                Anger -= randomNumber.Next(4, 12);
                Tiredness = 0;
                Boredom += randomNumber.Next(14, 25);
            }
            else //color Gold
            {
                Speed++;
                Stamina++;
                Hunger += randomNumber.Next(17, 31);
                Anger -= randomNumber.Next(3, 11);
                Tiredness = 0;
                Boredom += randomNumber.Next(18, 31);
            }
        }

        public void Tick() //Tick Method, if the user wants to pass time, or in case the user is misbehaving
        {

        }

        //Race Method ---Complicated; results based on Speed and Stamina stats (this is the only way to win the game)
        public void Race() 
        {
            if (Speed >= 50 && Speed <=99)
            {
                if (Stamina >= 50 && Stamina <= 100)
                {
                    Console.Clear();
                    Console.WriteLine("{0} wins the race by two lengths!!!\n", Name);
                    Console.WriteLine("{0} has gained speed and stamina.", Name);
                    Console.WriteLine("{0} has become much less angry and bored.", Name);
                    Console.WriteLine("{0} has become much more hungry and tired.", Name);

                    if (color == "YELLOW")
                    {
                        Speed += randomNumber.Next(7, 13);
                        Stamina += randomNumber.Next(7, 13);
                        Hunger += randomNumber.Next(20, 31);
                        Anger -= randomNumber.Next(7, 15);
                        Tiredness += randomNumber.Next(20, 31);
                        Boredom -= randomNumber.Next(7, 15);
                    }
                    else if (color == "BLUE" || color == "GREEN")
                    {
                        Speed += randomNumber.Next(6, 12);
                        Stamina += randomNumber.Next(6, 12);
                        Hunger += randomNumber.Next(22, 34);
                        Anger -= randomNumber.Next(6, 14);
                        Tiredness += randomNumber.Next(22, 34);
                        Boredom -= randomNumber.Next(6, 14);
                    }
                    else if (color == "BLACK")
                    {
                        Speed += randomNumber.Next(5, 10);
                        Stamina += randomNumber.Next(5, 10);
                        Hunger += randomNumber.Next(24, 36);
                        Anger -= randomNumber.Next(5, 13);
                        Tiredness += randomNumber.Next(24, 36);
                        Boredom -= randomNumber.Next(5, 13);
                    }
                    else //color Gold
                    {
                        Speed += randomNumber.Next(4, 8);
                        Stamina += randomNumber.Next(4, 8);
                        Hunger += randomNumber.Next(25, 41);
                        Anger -= randomNumber.Next(4, 12);
                        Tiredness += randomNumber.Next(25, 41);
                        Boredom -= randomNumber.Next(4, 12);
                    }
                }
                else if (Stamina >= 30 && Stamina < 50)
                {
                    Console.Clear();
                    Console.WriteLine("{0} is barely beaten, but comes in second...\n", Name);
                    Console.WriteLine("{0} has gained a little speed and stamina.", Name);
                    Console.WriteLine("{0} has become a little less angry and bored.", Name);
                    Console.WriteLine("{0} has become more hungry and tired.", Name);

                    if (color == "YELLOW")
                    {
                        Speed += randomNumber.Next(3, 7);
                        Stamina += randomNumber.Next(3, 7);
                        Hunger += randomNumber.Next(20, 31);
                        Anger -= randomNumber.Next(3, 7);
                        Tiredness += randomNumber.Next(20, 31);
                        Boredom -= randomNumber.Next(3, 7);
                    }
                    else if (color == "BLUE" || color == "GREEN")
                    {
                        Speed += randomNumber.Next(2, 6);
                        Stamina += randomNumber.Next(2, 6);
                        Hunger += randomNumber.Next(22, 34);
                        Anger -= randomNumber.Next(2, 6);
                        Tiredness += randomNumber.Next(22, 34);
                        Boredom -= randomNumber.Next(2, 6);
                    }
                    else if (color == "BLACK")
                    {
                        Speed += randomNumber.Next(5, 10);
                        Stamina += randomNumber.Next(5, 10);
                        Hunger += randomNumber.Next(24, 36);
                        Anger -= randomNumber.Next(5, 13);
                        Tiredness += randomNumber.Next(24, 36);
                        Boredom -= randomNumber.Next(5, 13);
                    }
                    else //color Gold
                    {
                        Speed += randomNumber.Next(4, 8);
                        Stamina += randomNumber.Next(4, 8);
                        Hunger += randomNumber.Next(25, 41);
                        Anger -= randomNumber.Next(4, 12);
                        Tiredness += randomNumber.Next(25, 41);
                        Boredom -= randomNumber.Next(4, 12);
                    }


                }
            }
        }
    }
}
