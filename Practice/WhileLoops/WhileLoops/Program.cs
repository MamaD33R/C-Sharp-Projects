using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your favorite color: ");
            string color = Console.ReadLine();

            bool favcolor = color == "yellow";          // if answer is yellow from user it's true

            while (!favcolor)                       // while the favorite color isn't true (yellow)
            {
                switch (color)
                {
                    case "red":
                        Console.WriteLine("You chose red. It's almost not ugly.");          
                        Console.WriteLine("Your favorite color: ");
                        color = Console.ReadLine();
                        break;
                    case "green":
                        Console.WriteLine("You chose green. Kinda cute, but still gross.");
                        Console.WriteLine("Your favorite color: ");
                        color = Console.ReadLine();
                        break;
                    case "blue":
                        Console.WriteLine("You chose blue. Gross.");
                        Console.WriteLine("Your favorite color: ");
                        color = Console.ReadLine();
                        break;
                    case "yellow":
                        Console.WriteLine("You chose Yellow. Awesome, you chose the best worst color.");        // the correct choice, yellow, will skip to the next do/while loop
                        Console.ReadLine();
                        favcolor = true;
                        break;
                    default:
                        Console.WriteLine("Terrible taste in colors you have.");
                        Console.WriteLine("Your favorite color: ");
                        color = Console.ReadLine();
                        break;

                }
            }

            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine(); ;
            bool favanimal = animal == "dog";


            
                do                                                                  // if dogs are guessed first try, program will end with do/while loop
                {
                    switch (animal)
                    {
                        case "cats":
                            Console.WriteLine("You like cats. They're cute demons. Wrong answer.");
                            Console.WriteLine("Try again?");
                            animal = Console.ReadLine();
                            break;
                        case "dogs":
                            Console.WriteLine("You like dogs! AMAZING.");
                            favanimal = true;
                            break;
                        default:
                            Console.WriteLine("All animals are great. But try again.");
                            Console.WriteLine("Try again?");
                            animal = Console.ReadLine();
                            break;
                    }
                }
                while (!favanimal);                 // to keep program going until correct answer is entered
           

            Console.ReadLine();
        }
    }
}
