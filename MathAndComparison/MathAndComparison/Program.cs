using System;


namespace MathAndComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int result;
            int result2;
            int z;
            int w;
            


            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("-----------");
            Console.WriteLine("Person 1: ");
            Console.WriteLine("Hourly Rate?");
            w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-----------");
            Console.WriteLine("Person 2: ");
            Console.WriteLine("Hourly Rate?");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            y = Convert.ToInt32(Console.ReadLine());

            result = w * z * 52;  // person 1 input x the number of weeks in a year
            Console.WriteLine("Annual salary of Person 1: {0}", result); 

            result2 = x * y * 52; // person 2 input x the number of weeks in a year
            Console.WriteLine("Annual salary of Person 2: {0}", result2);

            bool trueOrFalse = result > result2; // compares the results of person 1 and 2 to see if the below question is true or false
            Console.WriteLine("Does Person 1 make more money than Person 2? : {0}", trueOrFalse);

            Console.ReadLine();

        }
    }
}
