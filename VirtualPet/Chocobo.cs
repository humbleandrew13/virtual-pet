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
            Console.WriteLine("Thank you for using ChocoboPet2000.\n");
            Console.WriteLine("Max out your Chocobo's Speed and Stamina then dominate the race!\n");
            Console.WriteLine("Be careful not to make your Chocobo too hungry, bored, tired, or angry,");
            Console.WriteLine("or terrible things will happen...");
            Console.WriteLine("\n\nPlease enter a name for your Chocobo:\n");
            Name = Console.ReadLine();

            while (true)
            {
                //Get different starting stats depending on which color
                //also activities adjust stat differently based on color
                Console.WriteLine("\nPlease choose a color for {0} from the following:\n\n", Name);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Yellow   (well-rounded, easygoing)");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nGreen   (forest-dweller, fast, loves food)");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nBlue   (swimmer, fast, loves play)");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\nBlack   (faster, but high-maintenance)");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nGold   (incredible, but moody and volatile)\n");

                Console.ForegroundColor = ConsoleColor.Gray;
                Color = Console.ReadLine();
                color = color.ToUpper();

                if (color == "YELLOW")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Speed = 10;
                    Hunger = 0;
                    Boredom = 0;
                    Tiredness = 0;
                    Stamina = 10;
                    Anger = 0;
                }
                else if (color == "GREEN")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Speed = 15;
                    Hunger = 20;
                    Boredom = 15;
                    Tiredness = 20;
                    Stamina = 15;
                    Anger = 10;
                }
                else if (color == "BLUE")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Speed = 15;
                    Hunger = 20;
                    Boredom = 15;
                    Tiredness = 20;
                    Stamina = 15;
                    Anger = 10;
                }
                else if (color == "BLACK")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Speed = 22;
                    Hunger = 20;
                    Boredom = 25;
                    Tiredness = 25;
                    Stamina = 22;
                    Anger = 25;
                }
                else if (color == "GOLD")
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Speed = 30;
                    Hunger = 35;
                    Boredom = 30;
                    Tiredness = 30;
                    Stamina = 30;
                    Anger = 40;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("\nThat is not a valid choice\n");
                    Console.ReadKey();
                    continue;
                }
                break;
            }
        }

        //Methods

        public void Feed() //feed Method
        {
            Console.Clear();
            Console.WriteLine("You feed {0} some fresh greens!\n", Name);
            Console.WriteLine("{0} releases a loud, \"WARK!!!\"\n", Name);
            Console.WriteLine("{0} has become faster and gained stamina.\n", Name);
            Console.WriteLine("{0} has become less hungry.\n", Name);
            Console.WriteLine("{0} has become slightly less angry.\n", Name);
            Console.WriteLine("{0} has become more tired and bored.\n", Name);

            if (color == "YELLOW" || color == "BLUE")
            {
                Speed += randomNumber.Next(1, 4);
                Stamina += randomNumber.Next(1, 4);
                Hunger -= randomNumber.Next(10, 16);
                Anger -= randomNumber.Next(1, 4);
                Tiredness += randomNumber.Next(8, 12);
                Boredom += randomNumber.Next(5, 11);
            }
            else if (color == "GREEN")
            {
                Speed += randomNumber.Next(1, 7);
                Stamina += randomNumber.Next(1, 7);
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
                Tiredness += randomNumber.Next(20, 29);
                Boredom += randomNumber.Next(10, 16);
            }
            else //color Gold
            {
                Speed += randomNumber.Next(1, 4);
                Stamina += randomNumber.Next(1, 4);
                Hunger -= randomNumber.Next(7, 11);
                Anger -= randomNumber.Next(1, 3);
                Tiredness += randomNumber.Next(23, 33);
                Boredom += randomNumber.Next(12, 20);
            }

            Console.ReadKey();
        }

        public void Play() //play Method
        {
            Console.Clear();
            if (Speed <= 25)
            {
                Console.WriteLine("You shoot marbles with {0}!\n", Name);
            }
            else if (Speed > 25 && Speed <= 50)
            {
                Console.WriteLine("You play a game of hopscotch with {0}!\n", Name);
            }
            else if (Speed > 50 && Speed <= 75)
            { 
                Console.WriteLine("You play a spirited game of fetch with {0}!\n", Name);
            }
            else //speed > 75
            {
                Console.WriteLine("{0} wrecks you and your friends in a game of tag!\n", Name);
            }
            Console.WriteLine("{0} has become less bored and gained speed and stamina.\n", Name);
            Console.WriteLine("{0} has become more hungry.\n", Name);
            Console.WriteLine("{0} has become less angry.\n", Name);
            Console.WriteLine("{0} has become more tired.\n", Name);

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

            Console.ReadKey();
        }

        public void Dance() //dance Method
        {
            Console.Clear();
            Console.WriteLine("You have a late night dance party with {0}!!!\n", Name);
            Console.WriteLine("{0} has become much less bored and gained speed and stamina.\n", Name);
            Console.WriteLine("{0} has become much more hungry and tired.\n", Name);
            Console.WriteLine("{0} has become much less angry.\n", Name);

            if (color == "YELLOW")
            {
                Speed += randomNumber.Next(3, 6);
                Stamina += randomNumber.Next(3, 6);
                Hunger += randomNumber.Next(20, 26);
                Anger -= randomNumber.Next(5, 13);
                Tiredness += randomNumber.Next(20, 26);
                Boredom -= randomNumber.Next(10, 19);
            }
            else if (color == "BLUE" || color == "GREEN")
            {
                Speed += randomNumber.Next(3, 6);
                Stamina += randomNumber.Next(3, 6);
                Hunger += randomNumber.Next(23, 31);
                Anger -= randomNumber.Next(5, 12);
                Tiredness += randomNumber.Next(23, 31);
                Boredom -= randomNumber.Next(10, 19);
            }
            else if (color == "BLACK")
            {
                Speed += randomNumber.Next(2, 6);
                Stamina += randomNumber.Next(2, 6);
                Hunger += randomNumber.Next(27, 36);
                Anger -= randomNumber.Next(4, 12);
                Tiredness += randomNumber.Next(27, 36);
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

            Console.ReadKey();
        }

        public void Sleep() //sleep Method
        {
            Console.Clear();
            Console.WriteLine("You allow {0} to get some sleep.\n", Name);
            Console.WriteLine("{0} has become much less tired and gained speed and stamina.\n", Name);
            Console.WriteLine("{0} has become much more hungry and bored.\n", Name);
            Console.WriteLine("{0} has become less angry.\n", Name);

            if (color == "YELLOW")
            {
                Speed += randomNumber.Next(1, 3);
                Stamina += randomNumber.Next(1, 3);
                Hunger += randomNumber.Next(25, 36);
                Anger -= randomNumber.Next(5, 13);
                Tiredness = 0;
                Boredom += randomNumber.Next(25, 36);
            }
            else if (color == "BLUE" || color == "GREEN")
            {
                Speed += randomNumber.Next(1, 3);
                Stamina += randomNumber.Next(1, 3);
                Hunger += randomNumber.Next(28, 39);
                Anger -= randomNumber.Next(3, 10);
                Tiredness = 0;
                Boredom += randomNumber.Next(28, 39);
            }
            else if (color == "BLACK")
            {
                Speed++;
                Stamina++;
                Hunger += randomNumber.Next(30, 41);
                Anger -= randomNumber.Next(2, 6);
                Tiredness = 0;
                Boredom += randomNumber.Next(30, 41);
            }
            else //color Gold
            {
                Speed++;
                Stamina++;
                Hunger += randomNumber.Next(34, 46);
                Anger -= randomNumber.Next(1, 4);
                Tiredness = 0;
                Boredom += randomNumber.Next(34, 46);
            }

            Console.ReadKey();
        }

        public void Tick() //Tick Method, if the user wants to pass time, or in case the user is misbehaving
        {
            Console.WriteLine("...");

            if (color == "YELLOW")
            {
                Hunger += randomNumber.Next(5, 16);
                Anger += randomNumber.Next(5, 16);
                Tiredness += randomNumber.Next(10, 21);
                Boredom += randomNumber.Next(10, 21);
            }
            else if (color == "BLUE" || color == "GREEN")
            {
                Hunger += randomNumber.Next(8, 19);
                Anger += randomNumber.Next(8, 19);
                Tiredness += randomNumber.Next(14, 25);
                Boredom += randomNumber.Next(14, 25);
            }
            else if (color == "BLACK")
            {
                Hunger += randomNumber.Next(15, 21);
                Anger += randomNumber.Next(15, 21);
                Tiredness += randomNumber.Next(20, 31);
                Boredom += randomNumber.Next(20, 31);
            }
            else //color Gold
            {
                Hunger += randomNumber.Next(18, 29);
                Anger += randomNumber.Next(18, 29);
                Tiredness += randomNumber.Next(25, 36);
                Boredom += randomNumber.Next(25, 36);
            }

            Console.ReadKey();
        }

        //Race Method ---Complicated; results based on Speed and Stamina stats (this is the only way to win the game)
        public void Race() 
        {
            Console.Clear();

            if (Speed >= 50 && Speed <=99)
            {
                if (Stamina >= 50)
                {
                    Console.WriteLine("{0} puts up an incredible fight but comes in second by a nose.\n\n", Name);
                    Console.WriteLine("{0} has gained speed and stamina.\n", Name);
                    Console.WriteLine("{0} has become much less angry and bored.\n", Name);
                    Console.WriteLine("{0} has become much more hungry and tired.\n", Name);

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
                    Console.WriteLine("{0} comes in a somewhat respectable third place.\n\n", Name);
                    Console.WriteLine("{0} has gained a little speed and stamina.\n", Name);
                    Console.WriteLine("{0} has become a little less bored.\n", Name);
                    Console.WriteLine("{0} has become more hungry, tired, and angry.\n", Name);

                    if (color == "YELLOW")
                    {
                        Speed += randomNumber.Next(3, 7);
                        Stamina += randomNumber.Next(3, 7);
                        Hunger += randomNumber.Next(20, 31);
                        Anger += randomNumber.Next(3, 7);
                        Tiredness += randomNumber.Next(20, 31);
                        Boredom -= randomNumber.Next(3, 7);
                    }
                    else if (color == "BLUE" || color == "GREEN")
                    {
                        Speed += randomNumber.Next(2, 6);
                        Stamina += randomNumber.Next(2, 6);
                        Hunger += randomNumber.Next(22, 34);
                        Anger += randomNumber.Next(2, 6);
                        Tiredness += randomNumber.Next(22, 34);
                        Boredom -= randomNumber.Next(2, 6);
                    }
                    else if (color == "BLACK")
                    {
                        Speed += randomNumber.Next(5, 10);
                        Stamina += randomNumber.Next(5, 10);
                        Hunger += randomNumber.Next(24, 36);
                        Anger += randomNumber.Next(5, 13);
                        Tiredness += randomNumber.Next(24, 36);
                        Boredom -= randomNumber.Next(5, 13);
                    }
                    else //color Gold
                    {
                        Speed += randomNumber.Next(4, 8);
                        Stamina += randomNumber.Next(4, 8);
                        Hunger += randomNumber.Next(25, 41);
                        Anger += randomNumber.Next(4, 12);
                        Tiredness += randomNumber.Next(25, 41);
                        Boredom -= randomNumber.Next(4, 12);
                    }


                }
                else if (Stamina > 0 && Stamina < 30)
                {

                }
            }

            Console.ReadKey();
        }
    }
}
