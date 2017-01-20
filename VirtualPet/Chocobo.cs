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
        private float speed;
        private int hunger;
        private int boredom;
        private int tiredness;
        private int stamina;
        private int anger;  //anger will be a hidden stat that will affect the pet behind the scenes

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

        public float Speed
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
        public Chocobo(string name, string color, float speed)
        {
            Console.WriteLine("Thank you for using ChocoPet2000. \n\nPlease enter a name for your Chocobo:\n");
            Name = Console.ReadLine();
            Console.WriteLine("\nPlease choose a color for your Chocobo from the following:\n\n");
            Console.WriteLine("Yellow (well-rounded, easygoing)");
            Console.WriteLine("\nGreen (forest-dweller, fast, loves food)");
            Console.WriteLine("\nBlue (swimmer, fast, loves play)");
            Console.WriteLine("\nBlack (faster, but high-maintenance)");
            Console.WriteLine("\nGold (incredible, but moody and volatile)\n");
            Color = Console.ReadLine();
        }
    }
}
