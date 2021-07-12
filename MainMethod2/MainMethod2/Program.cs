using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You may enter another number to be multiplied with. Or not.");
    
            string num2 = Console.ReadLine();

            if (num2 == "")
            {
                Math.Add(x);
            }
            else
            {
                int y = Convert.ToInt32(num2);
                Math.Add(x, y);
            }

            Console.ReadLine();
        }
    }
}
