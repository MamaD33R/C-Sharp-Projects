using System;




class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("---vvv---");
        Console.WriteLine("Please enter package weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());                   // if weight > 50, exit program, ELSE proceed for package width

        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
        }

        else
        {
            Console.WriteLine("Please enter package width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            // collecting width, height, length for dimensions
            Console.WriteLine("Please enter package height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter package length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            double dimensions = height * length * width * weight;       // gathering total dimensions of package



            if (dimensions > 50)
            {
                Console.WriteLine("Package too large to be shipped via Package Express. Have a good day.");

            }
            else
            {
                double quote = dimensions / 100;                           // taking measurements and dividing by 100 for quote for shipping price

                Console.WriteLine("Your estimated total for shipping this package is: ${0}", quote);
                Console.WriteLine("Thank you!");
            }
            Console.ReadLine();

        }
    }
}

