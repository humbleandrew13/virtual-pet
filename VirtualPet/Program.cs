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
            while (true)
            {
                Random randomNumber = new Random();

                Chocobo choco = new Chocobo();

                while (choco.Hunger < 100 && choco.Anger < 100 && choco.Boredom < 100 && choco.Tiredness < 100 && choco.Speed > 0 && choco.Stamina > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Current stats for {0}:\n", choco.Name);
                    Console.WriteLine("Speed: {0}\nStamina: {1}\nHunger: {2}", choco.Speed, choco.Stamina, choco.Hunger);
                    Console.WriteLine("Tiredness: {0}\nBoredom: {1}\n", choco.Tiredness, choco.Boredom);

                    if (choco.Anger <= 20)
                    {
                        Console.WriteLine("{0} is in a good mood otherwise.\n", choco.Name);
                    }
                    else if (choco.Anger > 20 && choco.Anger <= 50)
                    {
                        Console.WriteLine("{0} is getting a little feisty.\n", choco.Name);
                    }
                    else if (choco.Anger > 50 && choco.Anger < 80)
                    {
                        Console.WriteLine("{0} is incredibly salty.\n", choco.Name);
                    }
                    else
                    {
                        Console.WriteLine("{0} is rather fired up. \nYou better do something to calm {0} down.\n", choco.Name);
                    }

                    Console.WriteLine("        __");
                    Console.WriteLine("       ;oo;");
                    Console.WriteLine("       `\\/'");
                    Console.WriteLine("        ||\n");

                    Console.WriteLine("What would you like to do? (Please enter the corresponding number)");
                    Console.WriteLine("1: Feed {0}\n2: Play with {0}\n3: Dance with {0}", choco.Name);
                    Console.WriteLine("4: Let {0} go to sleep\n5: Race {0} against other Chocobos", choco.Name);
                    Console.WriteLine("6: Just let some time pass\n");
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
                            
                            for(int i = 0; i < randomNumber.Next(1, 4); i++)
                            {
                                choco.Tick();
                            }
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

                    if (choco.Hunger < 0)
                    {
                        choco.Hunger = 0;
                    }

                    if (choco.Boredom < 0)
                    {
                        choco.Boredom = 0;
                    }

                    if (choco.Tiredness < 0)
                    {
                        choco.Tiredness = 0;
                    }

                    if (choco.Anger < 0)
                    {
                        choco.Anger = 0;
                    }
                }

                if (choco.Hunger >= 100)
                {
                    Console.WriteLine("\aYou have made {0} so hungry that they ate you while you were sleeping.\n", choco.Name);
                    Console.WriteLine("{0} will never win the race...\n\n\n\n", choco.Name);
                }
                else if (choco.Tiredness >= 100)
                {
                    Console.WriteLine("{0} has gotten so tired that they've fallen asleep for the", choco.Name);
                    Console.WriteLine("foreseeable future. \n\n{0} will never win the race...\n\n\n\n", choco.Name);
                }
                else if (choco.Boredom >= 100)
                {
                    Console.WriteLine("You have bored {0} to tears and now your chocobo just sits in the corner crying.\n", choco.Name);
                    Console.WriteLine("{0} will never win the race...\n\n\n\n", choco.Name);
                }
                else if (choco.Anger >= 100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0} has become so enfuriated that your chocobo has plotted your demise.\n", choco.Name);
                    Console.WriteLine("{0} will never win the race...\n\n\n\n", choco.Name);
                }



                Console.WriteLine("Would you like to restart? (yes or no)");
                string yesOrNo = Console.ReadLine();
                yesOrNo = yesOrNo.ToUpper();

                if (yesOrNo == "YES")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    continue;
                }
                else
                {
                    Console.WriteLine("I guess not...");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
