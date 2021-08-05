using System;


namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int result;
            double y;
            double resulty;

            Console.WriteLine("Enter a number:");
            x = Convert.ToInt32(Console.ReadLine());
            result = x * 50;
            Console.WriteLine("The result is: {0} x {1} = {2}", x, 50, result);
            Console.ReadLine();

            Console.WriteLine("Enter another number:");
            x = Convert.ToInt32(Console.ReadLine());
            result = x + 25;
            Console.WriteLine("The result is: {0} + {1} = {2}", x, 25, result);
            Console.ReadLine();

            Console.WriteLine("Enter another number for division:");
            y = Convert.ToDouble(Console.ReadLine());
            resulty = y / 12.5;
            Console.WriteLine("The result is: {0} / {1} = {2}", y, 12.5, resulty);
            Console.ReadLine();
        }
    }
}
