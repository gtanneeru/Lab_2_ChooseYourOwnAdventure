using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeads;
            Console.WriteLine("Welcome! \t What is Your Name?");
            string name = Console.ReadLine();
            Console.WriteLine("Would you like to play the game?\n Please enter 'yes' or 'no' ");
            string wantToPlay = Console.ReadLine();
            string yes = wantToPlay.ToLower();

            if (yes == "yes" || yes == "y")
            {
                Console.WriteLine("Excellent! You are walking across a field and you encounter a fire-breathing dragon!");
                Console.WriteLine("What would you do? \t Face the beast? or runaway");
                string dare = Console.ReadLine();

                if (dare == "Face the beast")
                {

                    Console.WriteLine("Enter '1' or '2' or '3'");
                    bool b = int.TryParse(Console.ReadLine(), out numberOfHeads);
                    Console.WriteLine("You approach the dragon. You see he has..." + " " + numberOfHeads + "number of heads!");
                    Console.WriteLine("No one has ever faced a" + numberOfHeads + "head dragon before!");
                    Console.WriteLine("Choose your wepon. Enter 'Slingshot' or 'Sword' or 'bow and arrow'");
                    string wepon = Console.ReadLine();

                    switch (wepon)
                    {
                        case "Slingshot":
                            Console.WriteLine("Armed with your Slingshot, you approach the dragon.");
                            break;

                        case "Sword":
                            Console.WriteLine("Armed with your Sword, you approach the dragon.");

                            break;
                        case "bow and arrow":
                            Console.WriteLine("Armed with your Bow and Arrow, you approach the dragon.");
                            break;

                        default:
                            {
                                Console.WriteLine("Armed with" +" "+ wepon + ", "+" "+"you approach the dragon");
                                break;
                            }

                    }
                    Console.WriteLine("Enter the eye color of the dragon.\t 'red' or 'blue'");
                    string eyeColor = Console.ReadLine();

                    Console.WriteLine("It stares at you with its" + " " + eyeColor + " "+ "eyes");
                    Console.WriteLine("Oh Thank Goodness!" +" "+ eyeColor + "-eyed dragons are friendly. You pet it and become friends.");

                    Console.WriteLine("You can name the dragon! Enter the name for the dragon:");
                    string dragonName = Console.ReadLine();
                    Console.WriteLine(name +" "+ "and" +" "+ dragonName +" "+ "lived happily ever after.");
                    Console.WriteLine("Do you want to play again? " + " " + "enter 'yes' or 'no'");
                    wantToPlay = Console.ReadLine();


                }
                else
                    Console.WriteLine("Wise Choice!");
            }
            else
                Console.WriteLine("Thank you for playing");
            Console.ReadKey();
        }
    }
}
