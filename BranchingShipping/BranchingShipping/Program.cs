using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingShipping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("---vvv---");
            Console.WriteLine("Please enter package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());           // created weight variable for if else statement, will exit program if user enters a package weight more than 50

            if (weight > 50)                                           // if weight > 50, exit program, ELSE proceed for package width
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            else
            {
                Console.WriteLine("Please enter package width: ");
            }
            int width = Convert.ToInt32(Console.ReadLine());            // collecting width, height, length for dimensions

            Console.WriteLine("Please enter package height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter package length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int dimensions = height * length * width * weight;          // gathering total dimensions of package
            float quote = dimensions / 100;                             // taking measurements and dividing by 100 for quote for shipping price

            Console.WriteLine("Your estimated total for shipping this package is: ${0}", quote);
            Console.WriteLine("Thank you!");

            Console.ReadLine();
        }
    }
}
