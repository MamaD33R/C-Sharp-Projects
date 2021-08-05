using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Kaia";           // \ for "" quotes and \n for new line and \t on a new tab and \\ for backslash in a string (OR you can use @ to say everything in the string is how it's suppose to be without escape sequences)
            //string quote = "The man said, \"Hello\", Kaia. \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = "C:\\Users\\Kaia";

            //bool trueOrFalse = name.Contains("a");
            //// asks if the variable name contains the letter "a"

            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;
            //// ask length of a string (name)

            //name = name.ToUpper();
            //// makes name uppercase or lowercase (ToLower)



            //Console.WriteLine(trueOrFalse);
            //Console.WriteLine(fileName);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder(); // dynamic object that doesn't take up memory to make new strings

            sb.Append("My name is Kaia");

            Console.WriteLine(sb);

        }
    }
}
