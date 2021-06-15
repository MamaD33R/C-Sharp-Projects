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
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Answer yes or no: ");
            dui = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?: ");
            ticket = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?: ");
            bool qualified = (age >= 15 && dui == "no" && ticket <= 3); 
            Console.WriteLine(qualified);
            Console.ReadLine();

        }
    }
}
