using System;




    class Program
    {
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("---vvv---");
        Console.WriteLine("Please enter package weight: ");
        int weight = Convert.ToInt32(Console.ReadLine());                   // if weight > 50, exit program, ELSE proceed for package width

        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
        }

        else
        {
            Console.WriteLine("Please enter package width: ");
        }

        int width = Convert.ToInt32(Console.ReadLine());        // collecting width, height, length for dimensions

        Console.WriteLine("Please enter package height: ");
        int height = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter package length: ");
        int length = Convert.ToInt32(Console.ReadLine());

        int dimensions = height * 2 + length + width * 2;          // gathering total dimensions of package
        float quote = dimensions * weight / 100;                           // taking measurements and dividing by 100 for quote for shipping price


        if (dimensions > 50)
        {
            Console.WriteLine("Package too large to be shipped via Package Express. Have a good day.");
        }
        else
        {
            Console.WriteLine("Your estimated total for shipping this package is: ${0}", quote);
            Console.WriteLine("Thank you!");
        }
        Console.ReadLine();

    }
}

