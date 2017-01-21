using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            bool trueFalse = true;
            while (trueFalse == true)
            {
                Chocobo choco = new Chocobo();

                while (choco.Hunger < 100 && choco.Anger < 100 && choco.Boredom < 100 && choco.Tiredness < 100 && choco.Speed > 0 && choco.Stamina > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Current stats for {0}\n", choco.Name);
                    Console.WriteLine("Speed: {0}\nStamina: {1}\nHunger: {2}", choco.Speed, choco.Stamina, choco.Hunger);
                    Console.WriteLine("Tiredness: {0}\nBoredom: {1}\n\n\n", choco.Tiredness, choco.Boredom);
                    Console.WriteLine("What would you like to do? (Please enter the corresponding number)");
                    Console.WriteLine("1: Feed {0}\n2: Play {0}\n3: Dance with {0}", choco.Name);
                    Console.WriteLine("4: Let {0} go to sleep\n5: Race {0} against other Chocobos", choco.Name);
                    Console.WriteLine("6: Just let some time pass\n\n");
                    string response = Console.ReadLine();

                    switch (response)
                    {
                        case "1":
                            choco.Feed();
                            break;
                        case "2":
                            choco.Play();
                            break;
                        case "3":
                            choco.Dance();
                            break;
                        case "4":
                            choco.Sleep();
                            break;
                        case "5":
                            choco.Race();
                            break;
                        case "6":
                            choco.Tick();
                            break;
                        default:
                            Console.WriteLine("You shouldn't have done that. A lot of time has passed for your misbehavior...");
                            choco.Tick();
                            choco.Tick();
                            choco.Tick();
                            Console.ReadKey();
                            break;
                    }

                    if (choco.Speed > 100)
                    {
                        choco.Speed = 100;
                    }

                    if (choco.Stamina > 100)
                    {
                        choco.Stamina = 100;
                    }
                }



                Console.WriteLine("Would you like to restart? (yes or no)");
                string yesOrNo = Console.ReadLine();
                yesOrNo = yesOrNo.ToUpper();

                if (yesOrNo == "YES")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("I guess not...");
                }

                trueFalse = false;
            }

            Console.ReadKey();
        }
    }
}
