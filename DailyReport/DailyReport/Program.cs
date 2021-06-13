using System;


namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("------------------"); // dashes for extra pizzazz

             // beginning console questions
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();

            Console.WriteLine("What page number?");     // converted string to int 
            string yourPageNumber = Console.ReadLine();
            int pageNumber = Convert.ToInt32(yourPageNumber);

            Console.WriteLine("Do you need help with anything? Please answer: True or False");
            string yourHelp = Console.ReadLine();
            bool trueorfalse = bool.Parse(yourHelp); // converting string to boolean and returned converted answer

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string yourExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string yourHours = Console.ReadLine();
            int studyHours = Convert.ToInt32(yourHours);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.ReadLine(); // to keep console window open until closed
        }
    }
}
