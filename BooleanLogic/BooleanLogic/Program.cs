using System;


namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string dui;
            int ticket;


            //Console.WriteLine(true && false); // && = AND - are both/all true
            //Console.WriteLine(true && true);

            //Console.WriteLine(true || true); // || = OR if one is true

            //Console.WriteLine(true == true); // == is equals

            //Console.WriteLine(true != true); // != - does not equal
            //Console.WriteLine(true != false);

            //Console.WriteLine(true ^ true); // ^ = XOR if one is true, but not both

            Console.WriteLine("What is your age?: ");
            age = Convert.ToInt32(Console.ReadLine()); // getting age int for qualified

            Console.WriteLine("Have you ever had a DUI? Answer yes or no: ");
            dui = Console.ReadLine();                  // getting yes or no answer for qualified

            Console.WriteLine("How many speeding tickets do you have?: ");
            ticket = Convert.ToInt32(Console.ReadLine());      // getting ticket amount int for qualified

            Console.WriteLine("Qualified?: ");  // this asks: is age greater than or equal to 15, does the dui answer equal "no" instead of "yes,
            bool qualified = (age >= 15 && dui == "no" && ticket <= 3);  // and is their total tickets less than or equal to 3
            Console.WriteLine(qualified);
            Console.ReadLine();

        }
    }
}
