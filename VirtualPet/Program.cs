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

                //Intro
                Console.WriteLine("Thank you for using ChocoboPet2000.\n");
                Console.WriteLine("Max out your Chocobo's Speed and Stamina, then dominate the race!\n");
                Console.WriteLine("Be careful not to make your Chocobo too hungry, bored, tired, or angry,");
                Console.WriteLine("or terrible things will happen...");

                Chocobo choco = new Chocobo(); //Construct a Chocobo

                while (choco.Hunger < 100 && choco.Anger < 100 && choco.Boredom < 100 && choco.Tiredness < 100 && choco.Speed > 0 && choco.Stamina > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Current stats for {0}:\n", choco.Name);
                    Console.WriteLine("Speed: {0}\nStamina: {1}\nHunger: {2}", choco.Speed, choco.Stamina, choco.Hunger);
                    Console.WriteLine("Tiredness: {0}\nBoredom: {1}\n", choco.Tiredness, choco.Boredom);

                    //doesn't give a direct number of the anger, but a general idea of mood
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
                        Console.WriteLine("{0} is rather fired up. \nYou'd better do something to calm {0} down.\n", choco.Name);
                    }

                    Console.WriteLine("        __");
                    Console.WriteLine("       ;oo;");  //lame Chocobo ASCII
                    Console.WriteLine("       `\\/'");
                    Console.WriteLine("        ||\n");

                    Console.WriteLine("What would you like to do? (Please enter the corresponding number)");
                    Console.WriteLine("1: Feed {0}\n2: Play with {0}\n3: Dance with {0}", choco.Name);
                    Console.WriteLine("4: Let {0} go to sleep\n5: Race {0} against other Chocobos", choco.Name);
                    Console.WriteLine("6: Just let some time pass\n");
                    string response = Console.ReadLine();

                    if (response == "5" && choco.Speed >= 100 && choco.Stamina >= 100)
                    {
                        Console.Clear();
                        break;
                    }

                    switch (response) //This makes input do something
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
                            Console.WriteLine("\nYou shouldn't have done that. A lot of time has passed for your misbehavior...");

                            for (int i = 0; i < randomNumber.Next(1, 4); i++) //random number of ticks (up to 3) when bad input is entered
                            {
                                choco.Tick();
                            }
                            break;
                    }

                    //checking and correcting various criteria
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


                if (choco.Speed >= 100 && choco.Stamina >= 100) //this is the only way to "win"
                {
                    Console.Clear();
                    Console.WriteLine("\aYou have entered {0} in the Chocobo Grand Prix and dominated the field!!!\n", choco.Name);
                    Console.WriteLine("{0}'s name will go down in the annals of history!!!\n", choco.Name);
                    Console.WriteLine("Unfortunately, {0} has become cocky and left you for a better trainer...\n\n\n\n", choco.Name);
                }
                else if (choco.Hunger >= 100) //All the rest are a bummer
                {
                    Console.Clear();
                    Console.WriteLine("\aYou have made {0} so hungry that they ate you while you were sleeping.\n", choco.Name);
                    Console.WriteLine("{0} will never win the race...\n\n\n\n", choco.Name);
                }
                else if (choco.Tiredness >= 100)
                {
                    Console.Clear();
                    Console.WriteLine("\a{0} has gotten so tired that they've fallen asleep for the", choco.Name);
                    Console.WriteLine("foreseeable future. \n\n{0} will never win the race...\n\n\n\n", choco.Name);
                }
                else if (choco.Boredom >= 100)
                {
                    Console.Clear();
                    Console.WriteLine("\aYou have bored {0} to tears and now your chocobo just sits\nin the corner crying.\n", choco.Name);
                    Console.WriteLine("{0} will never win the race...\n\n\n\n", choco.Name);
                }
                else if (choco.Anger >= 100)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\a{0} has become so enfuriated that your chocobo has plotted your demise.\n", choco.Name);
                    Console.WriteLine("{0} will never win the race...\n\n\n\n", choco.Name);
                }
                else if (choco.Speed <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("\a{0} has become so slow that your Chocobo will never walk again.\n", choco.Name);
                    Console.WriteLine("{0} will never win the race...\n\n\n\n", choco.Name);
                }
                else if (choco.Stamina <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("\a{0} can't put one foot in front of the other without falling over.\n", choco.Name);
                    Console.WriteLine("{0} will never win the race...\n\n\n\n", choco.Name);
                }

                Console.WriteLine("Would you like to restart? (yes or no)\n");
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
                    Console.WriteLine("\n\nWell, have a nice day then...");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
